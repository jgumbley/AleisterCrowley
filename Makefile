.PHONY: help test

help:
	@echo "Targets available:"
	@echo "   test: invoke the test runner using a local dotnet binary"

test:
	cd tests; dotnet test

