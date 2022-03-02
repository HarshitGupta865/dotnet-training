-- Date Functions 

/*
	getDate() : used to display today's date 
*/

select GETDATE() 

select convert(varchar,getdate(),1)

select convert(varchar,getdate(),2)

select convert(varchar,getdate(),3)


select convert(varchar,getdate(),105)

select convert(varchar,getdate(),1)

--+ Used to concatenate words/fields 

select 'Sai' + ' Akhil'

select nam + dept from Emp;

-- DatePart() : Used to display specific portion of given date. 

select DATEPART(dd,getdate())
select DATEPART(mm,getdate())
select DATEPART(yy,getdate())
select DATEPART(dy,getdate())
select DATEPART(qq,getdate())
select DATEPART(dw,getdate())
select DATEPART(hh,getdate())
select DATEPART(mi,getdate())
select DATEPART(ss,getdate())
select DATEPART(wk,getdate())

-- DateName() : Used to display in english words

select DATENAME(mm,getdate())

select DATENAME(dw,getdate())

-- DateAdd() : Used to add no.of years/months/days to the given date 

select DATEADD(dd,3,getdate())

select DateAdd(yy,3,getdate())

select DateAdd(mm,3,getdate())

-- DateDiff() : used to display diff. between two dates in terms of years/months/days 

select DATEDIFF(dd,'11/01/2001',getdate())/365.25

select DATEDIFF(YY,'11/01/2001',getdate())

select Floor(DATEDIFF(dd,'11/01/2001',getdate())/365.25) 'Years',

floor((DATEDIFF(dd,'11/01/2001',getdate())/365.25 - floor(DATEDIFF(dd,'11/01/2001',getdate())/365.25))*12) 'Months'


-- Month() : used to extract month 

select MONTH(getdate())

-- Year() : Used to extract Year

select Year(Getdate())  

-- Day() : Used to display day

select day(getdate())



