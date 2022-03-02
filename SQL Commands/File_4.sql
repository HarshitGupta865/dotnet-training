-- String Functions 

-- charindex() : display's the first occurrence of given char in a string 

select CHARINDEX('l','hello') 

select Empno,Nam, CHARINDEX('a',nam) from Emp;

-- len() : Displays total no.of characters in a string 

select LEN('Yash') 

select Nam,LEN(nam) 'Length' From Emp
Go

-- Reverse() : Used to display string in reverse order 

select REVERSE('Manali') 

select Nam,REVERSE(nam)
from Emp 
GO


-- lower() 

select nam,lower(nam), Upper(nam) from Emp 
GO

-- left() : Display's no.of left-side characters 

select Nam,Left(nam,4) from Emp;

-- Right() : Displays no.of right-side characters

select nam,right(nam,4) from Emp;

--substring() :Used to display part of string 

select SUBSTRING('welcome to sql',3,5) 

-- replace() : Used to replace old string/char with new string/char in all occurrences 

select REPLACE('Dotnet Training','Dotnet','Sql') 

