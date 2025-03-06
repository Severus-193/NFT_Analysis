# NFT Sales Analysis Platform

## Overview  
This project is a **web-based NFT sales analysis platform** built using **ASP.NET WebForms**. It connects to an **SQL Server 2008 database** via **ADO.NET** and employs a **Linear Regression model** to analyze and predict **NFT sales trends**. The application is developed in **Visual Studio 2022** and utilizes **Web Services** for API calls, while **jQuery and AJAX** enhance the front-end interactivity.  

## Key Features  
- **NFT Sales Data Analysis** – Retrieves and analyzes NFT sales records from the database.  
- **Predictive Modeling** – Uses **Linear Regression** to forecast NFT sales trends.  
- **SQL Server 2008 Integration** – Stores and processes NFT-related data.  
- **ASP.NET WebForms** – Provides a structured, interactive web interface.  
- **ADO.NET Connectivity** – Ensures efficient communication between the application and the database.  
- **Web Services for API Calls** – Enables seamless data fetching and processing.  
- **jQuery & AJAX Support** – Enhances user experience with smooth data updates.  

## Technology Stack  

| **Component**        | **Technology Used**          |
|----------------------|----------------------------|
| **Frontend**        | ASP.NET WebForms, jQuery, AJAX  |
| **Backend**         | C# (.NET Framework)         |
| **Database**        | SQL Server 2008            |
| **Connectivity**    | ADO.NET                     |
| **Machine Learning**| Linear Regression Model    |
| **API Call**        | Web Services (SOAP/REST)   |
| **Development Tool**| Visual Studio 2022         |

## Installation & Setup  

### Steps to Run the Application  

1. **Clone the Repository**  
```sh
git clone https://github.com/Severus-193/NFT_Analysis.git
cd NFT_Analysis
```

2. **Set Up SQL Server Database**  
- Open SQL Server Management Studio (SSMS).  
- Create a new database named **NFTSalesDB**.  
- Execute the SQL script found in `database/schema.sql` to create tables and seed data.  
- Update the **connection string** in `Web.config`:  
  ```xml
  <connectionStrings>
      <add name="NFTDBConnection"
           connectionString="Server=YOUR_SERVER;Database=NFTSalesDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
           providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```

3. **Build and Run the Application**  
- Open **Visual Studio 2022**.  
- Load the project solution (`Crypto.sln`).  
- Restore NuGet packages.  
- Build and run the project using **IIS Express**.  

4. **Access the Web Application**  
- Open a browser and navigate to `http://localhost:5000 `  

## API Endpoints (Web Services)  

| **Method** | **Endpoint** | **Description** |
|------------|------------|----------------|
| **GET** | `/api/nfts` | Fetch all NFT sales data |
| **POST** | `/api/predict` | Predict NFT sales using Linear Regression |
| **GET** | `/api/stats` | Retrieve market trend statistics |


