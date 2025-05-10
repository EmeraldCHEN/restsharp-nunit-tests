# restsharp-nunit-tests

Here’s a step-by-step guide to setting up RestSharp and NUnit for API testing in Visual Studio Code:

- Step 1: Install .NET SDK

Ensure you have the .NET SDK installed. You can download it from [Microsoft's .NET website](https://dotnet.microsoft.com/en-us/download)

- Step 2: Create a New NUnit Test Project

Open the terminal and run `dotnet new nunit -n ApiTests` to creates a new NUnit test project named ApiTestProject

- Step 3: Install Dependencies

Run `cd ApiTests` to navigate to the project folder then  `dotnet add package RestSharp` to install RestSharp via NuGet and `dotnet add package NUnit` & 
`dotnet add package NUnit3TestAdapter` to ensure NUnit is installed

- Step 4: Write a Basic API Test

Rename the file *UnitTest1.cs* inside the *ApiTests* folder and add the test code 


- Step 5: Run the Test

Run `dotnet test` and if everything is set up correctly, you should see a *ApiTests succeeded* message confirming the test ran successfully 🚀

- Steo 6: Push to GitHub Repo

If you’ve already linked your repo, run 1) `git add .` to add all changes in your repo; 2) `git status` to verify the changes to show all staged files and confirm what’s ready to be committed; 3) `git commit -m "Initial commit with ... or another message to describe your changes"` to commit the changes; 4) `git push origin [main or other branch]` to push changes to GitHub.



- [Reference](https://g33klady.com/2019/12/15/c-advent-calendar-2019-refactoring-restsharp-sample-tests-to-make-them-more-maintainable/?utm_source=chatgpt.com)


