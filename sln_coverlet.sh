#!/bin/bash
rm result1.json
dotnet clean .
dotnet restore .
dotnet build .
dotnet test TestCoverageFrameworks.sln /p:CollectCoverage=\"true\" /p:Exclude=\"[xunit*]*\" /p:CoverletOutput=\"./result1.json\" /p:MergeWith=\"./result1.json\" /maxcpucount:1
