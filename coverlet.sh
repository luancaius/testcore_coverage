#!/bin/bash
dotnet clean . > /dev/null 2>&1
dotnet restore . > /dev/null 2>&1
dotnet build . > /dev/null 2>&1
PROJECT_ASSEMBLY1="XUnitTestProject1"
TEST_ASSEMBLY1="XUnitTestProject1\bin\Debug\netcoreapp2.2\XUnitTestProject1.dll"
PROJECT_ASSEMBLY2="XUnitTestProject2"
TEST_ASSEMBLY2="XUnitTestProject2\bin\Debug\netcoreapp2.2\XUnitTestProject2.dll"
PROJECT_ASSEMBLY3="XUnitTestProject3"
TEST_ASSEMBLY3="XUnitTestProject3\bin\Debug\netcoreapp2.2\XUnitTestProject3.dll"

coverlet "$TEST_ASSEMBLY1" --target "dotnet" --targetargs "test $SOURCE_PROJECT --no-build -v q" --merge-with "./coverage.json" > /dev/null 2>&1
coverlet "$TEST_ASSEMBLY2" --target "dotnet" --targetargs "test $SOURCE_PROJECT --no-build -v q" --merge-with "./coverage.json"  > /dev/null 2>&1
coverlet "$TEST_ASSEMBLY3" --target "dotnet" --targetargs "test $SOURCE_PROJECT --no-build -v q" --merge-with "./coverage.json" --format opencover > temp.txt

grep -E "Total" temp.txt | awk -F'|' '{print $3}' 

#coverlet "$TEST_ASSEMBLY3" --target "dotnet" --targetargs "test $PROJECT_ASSEMBLY3 --no-build"  --merge-with "./coverage.json" --format json | grep -E "Total" | awk -F'|' '{print $2,$3}' 
