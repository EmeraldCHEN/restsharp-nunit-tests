# restsharp-nunit-tests

Here’s a step-by-step guide to setting up RestSharp and NUnit for API testing in Visual Studio Code:

- Step 1: Install .NET SDK

Ensure you have the .NET SDK installed. You can download it from [Microsoft's .NET website](https://dotnet.microsoft.com/en-us/download)

- Step 2: Create a New NUnit Test Project

Open the terminal and run `dotnet new nunit -n ApiTestProject` to creates a new NUnit test project named ApiTestProject

- Step 3: Install Dependencies

Run `cd ApiTestProject` to navigate to the project folder then  `dotnet add package RestSharp` to install RestSharp via NuGet and `dotnet add package NUnit` & 
`dotnet add package NUnit3TestAdapter` to ensure NUnit is installed

Step 4: Write a Basic API Test

Create a new file *ApiTests.cs* inside the *ApiTestProject* folder and add the test code
