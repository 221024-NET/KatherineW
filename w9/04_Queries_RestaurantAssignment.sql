use RestaurantAssignment

--1. Write a query to display the fields id, name, city and cuisine for all the restaurants.
SELECT restaurantId, restaurantName, city, cuisineName FROM Restaurants, Cuisines, RestaurantCuisines
WHERE restaurantId = rcRestaurantId AND cuisineId = rcCuisineId;

--2. Write a query to display all the restaurants which are in the city of Orlando.
SELECT restaurantName FROM Restaurants
WHERE city = 'Orlando';

--3. Write a query to display the top 5 restaurants in the state of New York.
SELECT TOP 5 restaurantName, city, AVG(score) AS avgScore FROM Restaurants
JOIN Scores ON scoredRestaurantId = restaurantId
WHERE state = 'New York'
GROUP BY city, restaurantName
ORDER BY AVG(score) DESC;

--4. Write a query to display restaurants who achieved a score more than 90.
SELECT restaurantName, city FROM (SELECT restaurantName, AVG(score) AS avgScore, cuisineName, city FROM Restaurants
                            JOIN Scores ON scoredRestaurantId = restaurantId
                            JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
                            JOIN Cuisines ON cuisineId = rcCuisineId
                            GROUP BY restaurantName, cuisineName, city) AS restaurantAvgs
WHERE avgScore > 90
GROUP BY restaurantName, city;

--5. Write a query to display restaurants who achieved a score more than 80 but less than 100.
SELECT restaurantName, city, AVG(score) AS avgScore FROM Restaurants, Scores
WHERE restaurantId = scoredRestaurantId AND score > 80 AND score < 100
GROUP BY restaurantName, city;

--6. Write a query to display restaurants that do not prepare any cuisine of 'American' and their score is more than 70.
SELECT restaurantName FROM (SELECT restaurantName, AVG(score) AS avgScore, cuisineName, city FROM Restaurants
                            JOIN Scores ON scoredRestaurantId = restaurantId
                            JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
                            JOIN Cuisines ON cuisineId = rcCuisineId
                            GROUP BY restaurantName, cuisineName, city) AS restaurantAvgs
WHERE avgScore > 70 AND cuisineName != 'American';


--7. Write a query to display restaurants that do not prepare any cuisine of 'American' and their score is more than 70 and are in the the city of Dallas.
SELECT restaurantName FROM (SELECT restaurantName, AVG(score) AS avgScore, cuisineName, city FROM Restaurants
                            JOIN Scores ON scoredRestaurantId = restaurantId
                            JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
                            JOIN Cuisines ON cuisineId = rcCuisineId
                            GROUP BY restaurantName, cuisineName, city) AS restaurantAvgs
WHERE avgScore > 70 AND cuisineName != 'American' AND city = 'Dallas';

--8. Write a query to display restaurants which do not prepare any cuisine of 'American' and achieved a grade point 'A', are not from Seattle. The data must be displayed according to the cuisine in descending order.
SELECT restaurantName, cuisineName FROM (SELECT * FROM Restaurants
                            JOIN Scores ON scoredRestaurantId = restaurantId
                            JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
                            JOIN Cuisines ON cuisineId = rcCuisineId) AS allData
WHERE cuisineName != 'American' AND grade = 'A' AND city != 'Seattle'
GROUP BY restaurantName, cuisineName
ORDER BY cuisineName DESC;

--9. Write a query to display the fields id, name, city and cuisine for all the restaurants that contain the letters "reg" somewhere in its name.
SELECT restaurantId, restaurantName, city, cuisineName AS cuisine FROM Restaurants
JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
JOIN Cuisines ON cuisineId = rcCuisineId
GROUP BY restaurantId, restaurantName, city, cuisineName
HAVING restaurantName LIKE '%reg%';

--10. Write a query to display restaurants from Los Angeles that serve Italian and Chinese cuisines.
SELECT restaurantName FROM Restaurants
JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
JOIN Cuisines ON cuisineId = rcCuisineId
GROUP BY restaurantName, cuisineName, city
HAVING city = 'Los Angeles' AND (cuisineName = 'Italian' OR cuisineName = 'Chinese')

--11. Write a query to display restaurants that scored less than 10.
SELECT restaurantName, AVG(score) AS avgScore FROM Restaurants
JOIN Scores ON scoredRestaurantId = restaurantId
GROUP BY restaurantName
HAVING AVG(score) < 10;

--12. Write a query to display restaurants that scored an average of more than 50 between 01-Jan-2022 and 30-Jun-2022. Display the data in descending order of the score.
SELECT restaurantName, date, avgScore FROM (SELECT restaurantName, AVG(score) AS avgScore, date FROM Restaurants
                            JOIN Scores ON scoredRestaurantId = restaurantId
                            JOIN RestaurantCuisines ON restaurantId = rcRestaurantId
                            GROUP BY restaurantName, restaurantId, date
                            HAVING AVG(score) > 50) AS restaurantAvgs
WHERE date BETWEEN '2022-01-01' AND '2022-06-30'
ORDER BY avgScore DESC;


--13. Write a query to display items served by restaurants that cost more than $20. Display the restaurant's name, address etc. along with the item and it's price in ascending order of price and restaurant name.
SELECT restaurantName, street, city, state, itemName, price FROM Restaurants
JOIN RestaurantMenus ON restaurantId = rmRestaurantId
JOIN MenuItems ON menuItemId = rmMenuItemId
GROUP BY restaurantName, street, city, state, itemName, price
HAVING price > 20
ORDER BY price, restaurantName ASC;