using System;
using System.Collections.Generic;

namespace DotNetCoreConsoleApplication
{

    // Example form class
    public class TestForm : Form
    {
        public FormField<string> FirstName { get; set; }
        public FormField<string> Surname { get; set; }
        public FormField<string> PickAColour { get; set; }

        public TestForm(IReadOnlyDictionary<string, object> values) : base(values)
        {
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Running...");

            // Eventually values will come from the controller...
            var values = new Dictionary<string, object>
            {
                {"FirstName", "bar"},
                {"Surname", "foo"},
                {"PickAColour", "Green"}
            };

            // Instantiating the class with values populates them...
            var form = new TestForm(values);

            // Should be able to render the form even if values aren't instantiated, need to fix
            Console.WriteLine(form.Render());

        }
    }
}
