# Rest-Basic


## C# -.NET Core 3.1  
## SQL Server 
## Podejście First Code z EF Core 

Prosty rest z połączeniem do bazy danych z dwoma tabelami. 
U mnie działa xd 

# Część zadania, które zostało zrealizowane 



Create a database and two tables [User], [Address]
[User] Columns:

• Id Primary Key int Not Null

• FirstName NVARCHAR(50) Not Null

• LastName NVARCHAR(50) Not Null
• DateOfBirth Datetime2(0) Not Null

• Gender bit Not Null

• Weight decimal(5,2) Nullable

• AddressId Foreign Key to Address Not Null

[Address] Columns:

• Id Primary Key int Not Null

• Country NVARCHAR(100) Not Null

• City NVARCHAR(100) Not Null

• PostCode NVARCHAR(10) Not Null 

• Street NVARCHAR(100) Not Null

• HouseNumber NVARCHAR(10) Not Null 

• LocalNumber NVARCHAR(10) Nullable


Please create a RESTful API which will be able to

• Create a user – POST

• Read all users – GET

• Get details about single user by the Id - GET

• Update a user – POST

• Delete a user – POST

**This API must use the EntityFramework**




