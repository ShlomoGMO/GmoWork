--1.	For all sales in the month of October 2005, 
--	return the first and last name of the customer, 
--	the product name, and 
--	final sale price.

SELECT c.FirstName, c.LastName, p.ProductName, s.SalePrice
FROM Sales s
	Inner Join Customers c ON s.CustomerID = c.CustomerID
	Inner Join Products p ON s.ProductID = p.ProductID
WHERE s.SaleDate Between '2005-10-01' and '2005-10-31'

--2.	For all customers who have made no purchases, 
--	return the Customer ID, first and last name 
--	of those individuals from the customer table.

SELECT c.FirstName, c.LastName
FROM Customers c
	Left Join Sales s ON c.CustomerID = s.CustomerID
WHERE s.SaleID Is Null

--3.	For all sales, 
--	return the customer’s first and last name, the sale price, 
--		and the recommended sale price, 
--		and the difference between the sale price and recommended sale price.  
--	The difference must be returned as a positive number.

SELECT c.FirstName, c.LastName, s.SalePrice, p.RecommendedPrice,
	ABS(p.RecommendedPrice - s.SalePrice) AS Difference
FROM Sales s
	Inner Join Customers c ON s.CustomerID = c.CustomerID
	Inner Join Products p ON s.ProductID = p.ProductID

--4.	Return the average price by product category.

SELECT p.Category, AVG(p.RecommendedPrice) AS AveragePrice
FROM Products p
GROUP BY p.Category

-- 6.	Delete the customer(s) from the database who are from the state of California
-- how rude!

DELETE c
FROM Customers c
WHERE c.State = 'CA'

-- 8.	Update the sale price to the recommended sale price of those sales occurring 
--		between 6/10/2005 and 6/20/2005.

UPDATE s
	SET SalePrice = p.RecommendedPrice
FROM Sales s
	Inner Join Products p ON s.ProductID = p.ProductID
WHERE s.SaleDate Between '2005-06-10' and '2005-06-20'