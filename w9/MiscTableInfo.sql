USE RestaurantAssignment

SELECT * FROM Cuisines;
SELECT * FROM Restaurants;
SELECT * FROM MenuItems;
SELECT * FROM RestaurantCuisines;
SELECT * FROM RestaurantMenus;

SELECT restaurantId, restaurantName, cuisineName, city FROM Restaurants, Cuisines, RestaurantCuisines
WHERE Restaurants.restaurantId = RestaurantCuisines.rcRestaurantId
AND Cuisines.cuisineId =  RestaurantCuisines.rcCuisineId
AND Cuisines.cuisineId = 6;

SELECT menuItemId, itemName, cuisineName, price FROM MenuItems
JOIN Cuisines ON Cuisines.cuisineId = MenuItems.Menucuisine
WHERE Cuisines.cuisineId = 7;

SELECT restaurantName FROM Restaurants
WHERE restaurantId = 16;

SELECT * FROM MenuItems
WHERE itemName = 'Okonomiyaki'