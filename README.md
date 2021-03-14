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
- Choose a username + password for your MySQL server
- Open up MySQL WorkBench
- Connect to your MySQL server,
- Create a new database called 'Defrag': https://dev.mysql.com/doc/workbench/en/wb-getting-started-tutorial-creating-a-model.html
- Restore Q3DF.API\Data\Dump20210303.sql into the database: https://dev.mysql.com/doc/workbench/en/wb-mysql-enterprise-backup-backup-recovery.html

5. Open up a terminal in VS Code (ctrl + `)
6. In the Q3DF.API directory, do:
- `dotnet user-secrets init`
- `dotnet user-secrets set "ConnectionStrings:Defrag" "Server=localhost;Database=Defrag;User ID=yourdbuser;Password=yourdbpassword"`
- `dotnet run`
8. Once done building, navigate to https://localhost:5001/swagger/index.html. If you see the swagger page for the project, you'd made it!
