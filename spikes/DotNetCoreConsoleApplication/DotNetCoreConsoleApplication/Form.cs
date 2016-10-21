using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DotNetCoreConsoleApplication
{
    public class Form
    {
        public Form(IReadOnlyDictionary<string, object> values = null)
        {
            if (values == null) return;

            Populate(values);
        }

        private void Populate(IReadOnlyDictionary<string, object> values)
        {
            var properties = GetType().GetProperties();

            foreach (var propertyInfo in properties)
            {
                var field = (IFormField) Activator.CreateInstance(typeof(FormField<string>), new FormBody());
                var value = "missing";

                try
                {
                    value = (string) values[propertyInfo.Name];
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Missing Key {0}", propertyInfo.Name);
                }


                field.SetField(value);

                propertyInfo.SetValue(this, field);
            }
        }

        public string Render()
        {
            var properties = GetType().GetProperties();
            var builder = new StringBuilder();

            foreach (var propertyInfo in properties)
            {
                var field = (IFormField) propertyInfo.GetValue(this);
                builder.Append(field.Render());
            }

            return builder.ToString();
        }

    }

    public interface IFormField
    {
        void SetField(object value);
        object GetFieldValue();
        string Render();
    }

    public class FormField<T> : IFormField
    {
        private readonly FormBody _formBody;
        public T Value { get; set; }

        public FormField(FormBody FieldType)
        {
            _formBody = FieldType;
        }

        public object GetFieldValue()
        {
            return Value;
        }

        public string Render()
        {
            return _formBody.Render(Value.ToString());
        }

        public void SetField(object value)
        {
            Value = (T) value;
        }
    }

    public class FormBody
    {
        private const string _template = "<label>{0}</label><input type=\"text\" id=\"{0}\"></input>";

        public string Render(string name)
        {
            return string.Format(_template, name);
        }
    }
}
