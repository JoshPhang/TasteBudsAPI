# Recipe Suggestion App

## Overview
The Recipe Suggestion App is a user-friendly application designed to help students and busy individuals decide what to cook with the ingredients they have. It simplifies meal planning by providing recipe suggestions and generating shopping lists for selected dishes.

## Features
* **Ingredient-Based Recipes**: Suggests recipes based on the ingredients you input.
* **Shopping List Generator:** Creates a shopping list for missing ingredients.
* **Easy Navigation:** User-friendly design for quick access to recipes.
* **Recipe Details:** Provides cooking instructions, prep time, and nutritional information.

To run the App locally, follow these steps:

## Step 1: Save the database file 
### (I am not sure if we are sending the link or sending the sql file with the submission)

## Step 2: Install and Set Up SQL Server Management Studio (SSMS)
To manage the SQL Server database, you will need to install SQL Server Management Studio (SSMS), a powerful tool for querying, designing, and administering your database.

### 2.1 Download SSMS

1. Visit the official [SQL Server Management Studio (SSMS) download page](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).
2. Click on **Download SSMS** and follow the installation prompts to install SSMS on your computer.
3. After installation is complete, launch SSMS.

### 2.2 Connect to a Local Server

1. In the **Connect to Server** window, type **.** (period) or **localhost** in the **Server name** field to connect to your local SQL Server instance.
2. Choose **Windows Authentication** as the authentication method (default option) if you're using your Windows credentials to connect.
3. Click **Connect**.

### 2.3 Verify Database Connection and executing the SQL file

1. Once connected, you should see the **Object Explorer** window appear on the left.
2. Click on **New Query** in SSMS to open a new query window.
3. Open the SQL script containing the table creation commands which you saved in your computer in Step 1. To do this open the script from your local file system.
4. **Select** the whole query, click **Execute** to run the SQL script and create the necessary tables in your database.
5. After executing the script, refresh the **Databases** node in the **Object Explorer**.
6. You should now see the newly created database in the list of available databases.
7. "DO WE HAVE TO ADD STEPS FOR CREATING NEW LOGIN AND STUFF?" I ACTUALLY FORGOT THE EXACT STEP

## Step 3: Install and set upVisual Studio

To begin development of the Recipe Suggestion App, you will need to install **Visual Studio**, which includes support for **ASP.NET** applications.

### 3.1 Download and set up Visual Studio

1. Visit the official [Visual Studio download page](https://visualstudio.microsoft.com/downloads/).
2. Select the **Community** edition (free for individual use).
3. Run the installer and choose the **ASP.NET and web development** workload. This will include:
   - **ASP.NET Core**
   - **C#** language support
   - **Entity Framework Core**
4. Complete the installation process, it may take some time depending on your internet connection and system configuration.
5. Once the installation is complete, launch **Visual Studio**.





