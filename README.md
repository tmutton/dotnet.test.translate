# dotnet.test.translate

From the Prog .NET Tutorials 2016 class "Up and Running with .NET Core" with Toby Henderson (@holytshirt)

This project was created by hand using Visual Studio Code.

Pre reqs: (Minimum) DotNetCore 1.0.0

To build.

- cd to root
- dotnet restore
- cd console
- dotnet build
- dotnet run "en"

This will run the console project from the cmd line. We can pass in a string parameter ie ("en", "fr", "es") which will display a hello world in that particular language.

There is also a test project. To run:

- cd to test
- dotnet restore
- dotnet build
- dotnet test
