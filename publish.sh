#!/bin/bash

dotnet publish -c Release
pushd bin/Release/netstandard2.0/publish
zip -r AWSLambdaCSharp.zip *
popd