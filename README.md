# BASIC-REST-API

## Here is a list of software, SDKs, and tools you need to install:
#### 1. VS Code: https://code.visualstudio.com/download
#### 2. .NET 8 SDK: https://dotnet.microsoft.com/en-us/download

## Configuring VS Code
#### 1. C# Dev Kit

## Checking the .NET SDK
#### 1. Once you install the .NET SDK, you can check the version by running thefollowing command:
#### dotnet --version
#### 2. You can list all available SDKs by running the following command:
#### dotnet --list-sdks

# Creating a simple REST web APIprojectdotnet
#### create a web API project by running the following command:
#### dotnet new webapi -n basic-rest-api -controllers
#### cd basic-rest-api
#### code .

# To support HTTPS, you may need to trust the HTTPS development certifi-cate by running the following command:
#### dotnet dev-certs https --trust

# Changing the port number
#### 1. open launchSettings.json file in the Properties folder
#### 2. 5000 to 5300 for HTTP
#### 3. 7000 to 7300 for HTTPS
