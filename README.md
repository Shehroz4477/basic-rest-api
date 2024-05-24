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

# FILE-SCOPED NAMESPACE DECLARATION
#### 1. From C# 10, you can use a new form of namespace declaration,
#### 2. file-scoped namespace declaration. 
#### 3. All the members in this file are in the same namespace. It saves space and reduces indentation.

# NULLABLE REFERENCE TYPES
#### 1. You may be wondering why we assign an empty string to the Title and Body properties. 
#### 2. This is because the properties are of type string. 
#### 3. If we do not initialize the property, the compiler will complain:

# Non-nullable property 'Title' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#### 1. Nullable reference types were introduced in C# 8.0. They can minimize the likelihood of errors that cause the runtime to throw a System.NullReferenceException error. 
#### 2. By default, the ASP.NET Core web API project template enabled the nullable reference types annotation in the project properties. If you check the project file, you will find <Nullable>enable</Nullable> in the <PropertyGroup> section.

# Create a new file named PostController.cs in the Controllers folder
#### You can manually add it, or install the dotnet-aspnet-codegenerator tool to create it. To install the tool, run the following commands from the project folder:
##### 1. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
##### 2. dotnet tool install -g dotnet-aspnet-codegenerator

# TARGET-TYPED NEW EXPRESSIONS
#### 1. This feature was introduced in C# 9.0.
#### 2. When the list is declared as List<Post>, the type is known, so it is not necessary to use new Post() here when adding new elements. The type specification can be omitted for constructors, such as new().

# Group registration
#### As the project grows, we may have more and more services. If we register all services in Program.cs, this file will be very large. For this case, we can use group registration to register multiple services at once.
##### 1.  Extension method for the IServiceCollection interface
##### 2.  It is used to register all services at once in the Program.cs file

# Action injection
#### Sometimes, one controller may need many services but may not need all of them for all actions. If we inject all the dependencies from the constructor, the constructor method will be large. For this case, we can use action injection to inject dependencies only when needed. 
##### 1. The [FromServices] attribute enables the service container to inject dependencies when needed without using constructor injection.
##### 2. Keep in mind that this kind of action injection only works for actions in the controller.
##### 3. Additionally, since ASP.NET Core 7.0, the [FromServices] attribute can be omitted as the framework will automatically attempt to resolve any complex type parameters registered in the DI container.

# Using primary constructors to inject dependencies
#### .NET 8 and C# 12, we can use the primary constructor to inject dependencies. A primary constructor allows us to declare the constructor parameters directly in the class declaration, instead of using a separate constructor method.
#### If a class declares a parameter named postService in the class declaration, it cannot be accessed as a class member using this.postService or from external code. 