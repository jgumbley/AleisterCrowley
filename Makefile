.PHONY: help test

help:
	@echo "Targets available:"
	@echo "   test: invoke the test runner using a local dotnet binary"

test:
	cd test/AleisterCrowley.UnitTest; dotnet test

