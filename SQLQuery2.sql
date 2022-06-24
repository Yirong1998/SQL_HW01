
Use AdventureWorks2019
go

Select * from Person.CountryRegion
Select * from Person.StateProvince
/* Q1 */
Select CountryRegion.Name AS Country, StateProvince.Name AS Province from Person.CountryRegion INNER JOIN Person.StateProvince ON CountryRegion.CountryRegionCode = StateProvince.CountryRegionCode

/* Q2 */
Select CountryRegion.Name AS Country, StateProvince.Name AS Province from Person.CountryRegion INNER JOIN Person.StateProvince ON CountryRegion.CountryRegionCode = StateProvince.CountryRegionCode WHERE CountryRegion.Name = 'Germany' or CountryRegion.Name = 'Canada'

go
Use Northwind
go
/* Q3 */
Select DISTINCT(ProductName) from ((Products INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID) INNER JOIN Orders ON [Order Details].OrderID = Orders.OrderID) Where Orders.OrderDate >= '1997-01-01 00:00:00.000'

/* Q4 */

/*Select TOP 5 ProductID AS Product1 from [Order Details] Group By ProductID ORDER BY Count(ProductID) DESC*/
Select TOP 5 ShipPostalCode from Orders Group By ShipPostalCode ORDER BY COUNT(ShipPostalCode) DESC





