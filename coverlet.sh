#!/bin/bash
dotnet clean .
dotnet restore .
dotnet build .

PROJECT_ASSEMBLY="XUnitTestProject1"
TEST_ASSEMBLY="XUnitTestProject1\bin\Debug\netcoreapp2.2\XUnitTestProject1.dll"
PROJECT_ASSEMBLY2="XUnitTestProject2"
TEST_ASSEMBLY2="XUnitTestProject2\bin\Debug\netcoreapp2.2\XUnitTestProject2.dll"
PROJECT_ASSEMBLY3="XUnitTestProject3"
TEST_ASSEMBLY3="XUnitTestProject3\bin\Debug\netcoreapp2.2\XUnitTestProject3.dll"

coverlet "$TEST_ASSEMBLY" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY --no-build" --merge-with "./coverage.json" --format json
coverlet "$TEST_ASSEMBLY2" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY2 --no-build" --merge-with "./coverage.json" --format json
coverlet "$TEST_ASSEMBLY3" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY3 --no-build" --merge-with "./coverage.json" --format json
