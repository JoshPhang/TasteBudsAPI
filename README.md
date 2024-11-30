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
###(I am not sure if we are sending the link or sending the database file with the submission)

## Step 2: Install and Set Up SQL Server Management Studio (SSMS)

### 2.1 Download SSMS

1. Visit the official [SQL Server Management Studio (SSMS) download page](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).
2. Click on **Download SSMS** and follow the installation prompts to install SSMS on your computer.
3. After installation is complete, launch SSMS.

### 2.2 Connect to a Local Server

1. In the **Connect to Server** window, type **`.`** (period) or **`localhost`** in the **Server name** field to connect to your local SQL Server instance.
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

## Step 3: Install Visual Studio

To begin development of the Recipe Suggestion App, you will need to install **Visual Studio**, which includes support for **ASP.NET** applications.

### 3.1 Download Visual Studio

1. Visit the official [Visual Studio download page](https://visualstudio.microsoft.com/downloads/).
2. Select the **Community** edition (free for individual use) or any other edition based on your preference.
3. Click **Download** to get the installer file.

### 3.2 Install Visual Studio

1. Run the **Visual Studio Installer** after the download completes.
2. In the installer, select the **"ASP.NET and web development"** workload. This will install all the necessary tools and dependencies for **ASP.NET** development.
3. Click **Install** to begin the installation. The process may take some time depending on your internet connection and system configuration.
4. Once the installation is complete, launch **Visual Studio**.

### 3.3 Set Up Your Development Environment

1. Open the **Recipe Suggestion App** project in **Visual Studio**.




