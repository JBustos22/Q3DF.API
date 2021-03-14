q3df.org new API

This project contains the code for q3df.org's mDd web API for accessing data from the mdd records database.
- To learn more about what web APIs are: https://www.tutorialsteacher.com/webapi/what-is-web-api

Setting up the project:
1. Download the following:
- ASP.NET Core SDK: https://dotnet.microsoft.com/download/dotnet/3.1
- Visual Studio Code: https://code.visualstudio.com/download
- MySQL Community Server and MySQL Workbench: https://dev.mysql.com/downloads/


2. Install the following:
- dotnet:
  - The dotnet ef tool: `dotnet tool install --global dotnet-ef`
- Visual Studio Code (Through the extensions downloader):
  - C# for Visual Studio Code (powered by OmniSharp)
  - MySQL by Jun Han
  - NuGet Package Manager by jmrog

3. Clone the repository

4. Set up the database:
- Open up MySQL WorkBench
- Create Database 'Defrag' and choose a username + password for it
- Connect to the database, restore Q3DF.API\Data\Dump20210303.sql

5. Open up a terminal in VS Code (ctrl + `)
6. In the Q3DF.API directory, do:
- `dotnet user-secrets set ConnectionStrings:Defrag "Server=localhost;Database=Defrag;User ID=yourdbuser;Password=yourdbpassword"`
- `dotnet run`
7. Once done building, navigate to https://localhost:5001/swagger/index.html. If you see the swagger page for the project, you'd made it!
