-- Group By : 

Used to generate summary reports on the field(s) specified, we need to use one aggregate function mandetory
in this

select dept,sum(basic) from Emp
group by Dept
Go


select dept, avg(basic) from Emp 
group by Dept
GO

select dept,max(basic) from Emp 
group by Dept 
GO

select dept, min(basic) from Emp 
group by Dept 
GO


select dept, count(*) From Emp 
group by Dept 
GO

-- Having : Used to generate aggregate conditions on the field specified 

select dept, count(*) From Emp 
group by Dept 
having count(*) > 1 
GO

