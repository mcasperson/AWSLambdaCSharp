#!/bin/bash

dotnet publish -c Release 
pushd bin/Release/netcoreapp2.0/publish
zip -r AWSLambdaCSharp.zip *
popd