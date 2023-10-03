# etiqa

Project Title:

1. CDNFreelancerAPI

Description:

1. A project to store the full list of freelancers

Installation:

1. Add NuGet: Microsoft.EntityFrameworkCore.SqlServer
2. Add NuGet Microsoft.EntityFrameworkCore.Design
3. Install .NET6 Runtime 
4. Create a database called EtiqaAssignment using MSSQL Server and run below table creation script.

Table Creation Script:

CREATE TABLE [dbo].[Users](
	[Id] [int] NULL,
	[username] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[phonenumber] [varchar](50) NULL,
	[skillsets] [varchar](50) NULL,
	[hobby] [varchar](50) NULL
) ON [PRIMARY]


Configuration:

1. Connection String can be configured at App Setting


Documentation:
User Guide can be obtained from: 
https://drive.google.com/file/d/1KiCG9jXETZa6HTmBXRWXnOToUA9tENQ9/view?usp=sharing


