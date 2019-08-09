#!/bin/bash
#rm coverage.json
#dotnet clean .
#dotnet restore .
#dotnet build .
echo "Starting coverage"
PROJECT_ASSEMBLY1="XUnitTestProject1"
TEST_ASSEMBLY1="XUnitTestProject1\bin\Debug\netcoreapp2.2\XUnitTestProject1.dll"
PROJECT_ASSEMBLY2="XUnitTestProject2"
TEST_ASSEMBLY2="XUnitTestProject2\bin\Debug\netcoreapp2.2\XUnitTestProject2.dll"
PROJECT_ASSEMBLY3="XUnitTestProject3"
TEST_ASSEMBLY3="XUnitTestProject3\bin\Debug\netcoreapp2.2\XUnitTestProject3.dll"

#coverlet "$TEST_ASSEMBLY1" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY1 --no-build" --merge-with "./coverage.json" --format json
#coverlet "$TEST_ASSEMBLY2" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY2 --no-build" --merge-with "./coverage.json" --format json
#coverlet "$TEST_ASSEMBLY3" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY3 --no-build"  --merge-with "./coverage.json" --format json
#result=$(ls -l | grep -E "lramos")
#echo $result

result=$(coverlet "$TEST_ASSEMBLY3" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY3 --no-build"  --merge-with "./coverage.json" --format json | grep -E "Total.*?([0-9]{1,3})(,[0-9]{1,2})?%/")
echo $result
