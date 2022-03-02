select * from Emp;

select Empno,Nam,Dept,Desig,Basic, 
ROW_NUMBER() OVER (Order By Nam )
From Emp;

-- Display numbering to Employees based on their basic in descending order 

-- ROW_NUMER() : used to generate numbering to the table field records.

select Empno,Nam,Dept,Desig,Basic,
ROW_NUMBER() OVER(Order By Basic Desc) RNO
from Emp
GO

-- RANK() : used to generate rank number on the field specified 

select Empno,Nam,Dept,Desig,Basic,
RANK() OVER(Order By Basic Desc) RNO
from Emp
GO

-- Dense_Rank() : Used to generate sequential ranking on the field specified


select Empno,Nam,Dept,Desig,Basic,
DENSE_RANK() OVER(Order By Basic Desc) RNO
from Emp
GO

-- Top keyword : used to display top most records of condition specified 

select top 5 * 
from Emp order by Basic Desc 

