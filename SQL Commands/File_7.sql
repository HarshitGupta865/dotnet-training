-- Aggregate Functions 

-- Sum()  : Used to display sum.operation on the given field 

select sum(basic) from Emp
GO


select Sum(AnnualPremium)
from Policy
GO

-- Avg() : Used to display avg. operation on the given field 

select avg(basic) from Emp;

-- Max() : used to display max. value on the given field 

select max(basic) from Emp

-- Min() : Used to display min. value on the given field

select min(basic) from Emp 

-- Count(*) : Used to display total no.of records 

select count(*) from Emp 
