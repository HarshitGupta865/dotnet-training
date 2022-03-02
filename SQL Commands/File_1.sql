-- To change to the particular database

use sqlpractice 
go

-- To see the structure of Emp table, 

sp_help Emp
go


-- Display all records from Emp table 

select * from Emp 
GO


-- Project Operator (used to display particular field(s) from given table)

select
   Empno,nam,basic
from Emp
GO

-- Where clause : Used to display records based on condition . (Filter Data) {Restrict Operator}

-- Display all records whose Basic > 50000

select * from Emp where Basic > 50000;

-- Display all records whose Dept is 'Dotnet' 

select * from Emp where dept='Dotnet';

-- Between...AND : Used to display records from start to end range 

-- Display all records whose Sal between 30000 and 60000 

select * from Emp where basic between 30000 and 60000
Go

select * from Emp where basic NOT between 30000 and 60000
Go

-- IN Clause : Used to display records that matching multiple column values 

-- Display All records whose nam is satish or akhilesh or dattu

select * from Emp 
where nam IN('Satish','Akhilesh','Dattu') 
GO

select * from Emp 
where Nam NOT IN('Satish','Akhilesh','Dattu') 
GO

-- LIKE Operator : Used to display values w.r.t. Wild Cards % and _ are wild cards

-- Display all records whose name starts with 'A' 

select * from Emp where nam Like 'A%'
GO

-- Display all records whose name ends with 's' 

select * from Emp where nam like '%h' 
Go

-- Order By : Used to display values w.r.t. Specific field(s) in ascending or descending order 

select * from Emp 
ORDER BY nam 
GO

select * from Emp 
ORDER BY Dept Desc  
GO

select * from Emp 
order By Dept,Nam 
Go

select * from Emp 
Order By Dept, Nam Desc
GO

select dept from Emp;

-- Distinct : Used to Eliminate duplicates at the time of display 

select distinct dept from Emp 
Go

select * from Emp 

-- Write a query as display manager name as 
-- if dept is dotnet then 'ram'
-- if dept is java then 'raghu'
-- if dept is mvc then 'girish'
-- else give as 'bindu'

select Empno,nam,dept,basic,
CASE Dept
   when 'Java' then 'Ram'
   when 'Dotnet' then 'Raghu'
   WHEN 'MVC' then 'Girish'
   else 'Bindu'
END 'Manager'
from Emp 
GO
-- Write a Query as Increase your basic as
-- if dept is dotnet then basic+1000
-- if dept is java then basic+1500
-- if dept is mvc then basic+2000
-- else no increment 

select Empno,nam,Dept,Basic,
CASE Dept
   When 'Dotnet' then Basic+1000
   WHEN 'Java' then Basic+1500
   WHEN 'MVC' Then Basic+2000
   else Basic 
END 'Incremented Salary'
from Emp 
GO

select * from Agent 
GO

select 
   AgentID,FirstName,LastName,City,SSN,MaritalStatus,
CASE MaritalStatus
	WHEN 0 THEN 'Unmarried'
	WHEN 1 THEN 'Married'
END 'Status'
from Agent 
Go

select * from Policy 
Go

select PolicyID, AppNumber,ModalPremium, AnnualPremium,PayMentModelID,
CASE PayMentModelID
  WHEN 1 THEN 'Yearly'
  WHEN 2 THEN 'Half-Yearly'
  WHEN 3 THEN 'Quarterly'
END 'PayMode'
from Policy
GO

-- Ranking Functions 

select * from Emp;

-- Display numbering to Employees based on their basic in descending order 

-- ROW_NUMER() : used to generate numbering to the table field records.

select Empno,Nam,Dept,Desig,Basic,
ROW_NUMBER() OVER(Order By Basic Desc) Rno
from EMp 
GO
