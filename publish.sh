#!/bin/bash

dotnet publish -c Release /p:GenerateRuntimeConfigurationFiles=true
pushd bin/Release/netstandard2.0/publish
zip -r AWSLambdaCSharp.zip *
popd