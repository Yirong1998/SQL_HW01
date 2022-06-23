Use AdventureWorks2019
go

Select * from Production.Product
/* Q1 */
Select ProductID, Name, Color, ListPrice From Production.Product;

/* Q2 */
Select ProductID, Name, Color, ListPrice From Production.Product Where ListPrice != 0;

/* Q3 */
Select ProductID, Name, Color, ListPrice From Production.Product Where Color IS NOT NULL;

/* Q4 */
Select ProductID, Name, Color, ListPrice From Production.Product Where Color IS NOT NULL And ListPrice > 0;

/* Q5 */
Select Name + Color From Production.Product Where Color IS NOT NULL;

/* Q6 */
Select 'NAME: ' + Name + ' -- COLOR: ' + Color From Production.Product Where Color IS NOT NULL;

/* Q7 */
Select ProductID, Name From Production.Product Where ProductID >= 400 AND ProductID <= 500;

/* Q8 */
Select ProductID, Name, Color From Production.Product Where Color = 'black' OR Color = 'blue';

/* Q9 */
Select * From Production.Product Where Name Like 'S%';

/* Q10 */
Select Name, ListPrice From Production.Product Where Name Like 'A%' Or Name Like 'S%' Order by Name;

/* Q11 */
Select * From Production.Product Where Name Like 'SPO[^K]%' Order by Name;

/* Q12 */
Select DISTINCT ProductSubcategoryID, Color From Production.Product Where Color IS NOT NULL AND ProductSubcategoryID IS NOT NULL;