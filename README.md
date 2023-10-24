Secure-Trade - Getting Started Guide

Secure-Trade is an online platform that simplifies online commerce by providing a secure and convenient buying and selling experience. This guide will walk you through the steps to set up and run the Secure-Trade project on your local machine.
Prerequisites
Before you can run Secure-Trade on your machine, make sure you have the following prerequisites installed:

- .NET Core SDK
- MySQL or MSSQL Database Server
- Visual Studio or Visual Studio Code (optional but recommended)
  Installation and Setup
  Follow these steps to get Secure-Trade up and running on your machine:

1. Clone the Secure-Trade repository to your local machine:
   git clone https://github.com/Ogidan-s-Mentorship-Program/Secure_Trade.git
2. Navigate to the project directory:
   cd secure-trade
3. Create a database for Secure-Trade on your MySQL or MSSQL server.
4. Update the database connection string in the `appsettings.json` file to point to your database:

"ConnectionStrings": {
"DefaultConnection": "Server=LAPTOP-IIGPTMUN\\SQLEXPRESS;Database=BootCampdb;Trusted_Connection=True;"

} 5. Open a terminal or command prompt and run the following commands to apply the database migrations:

 add InitialMigration
 database-update

6. Restore NuGet packages by running the following command:
   restore
7. Build the project:
8. Run the Secure-Trade project:
   Secure-Trade should now be up and running on your machine, accessible at `https://localhost:5001`.

Usage

You can explore the various endpoints provided by Secure-Trade by referring to the list of endpoints and their descriptions in the project's README. Make sure to authenticate yourself if required to access certain routes.
