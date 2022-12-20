USE RestaurantAssignment

-- INITIALIZE MENUITEMS ----------- 
INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Hamburger', 10.00, 1);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Hotdog', 12.50, 1);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Milkshake', 23.00, 1);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Milkshake', 20.00, 1);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Pork Buns', 11.00, 2);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Fried Lotus Root', 14.50, 2);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Ginger Noodles', 20.65, 2);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Spaghetti', 30.00, 3);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Risotto', 15.50, 3);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Gelato', 7.00, 3);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Bi Bim Bap', 51.25, 4);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Tteokbokki', 20.00, 4);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Bulgogi', 10.50, 4);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Sopapilla', 7.50, 5);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Pozole', 16.25, 5);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Fish Tacos', 20.00, 5);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Fish Tacos', 17.50, 5);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Sashimi', 16.30, 6);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Okonomiyaki', 20.00, 6);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Mochi Ice Cream', 10.00, 6);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Tikka Masala', 16.00, 7);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Samosas', 7.25, 7);

INSERT INTO MenuItems ( itemName, price, menuCuisine )
VALUES ('Tandoori Chicken', 23.00, 7);

GO

-- SET RESAURANT-CUISINE RELATIONSHIPS
INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 1, 1);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 2, 1);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 3, 3);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 4, 7);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 5, 3);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 6, 3);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 7, 2);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 8, 1);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 9, 1);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 10, 2);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 10, 6);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 11, 5);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 12, 4);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 12, 7);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 13, 6);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 14, 2);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 15, 4);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 16, 1);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 17, 6);

INSERT INTO RestaurantCuisines ( rcRestaurantId, rcCuisineId )
VALUES ( 18, 5);

GO

-- SET RESAURANT-MENU RELATIONSHIPS
INSERT INTO RestaurantMenus ( rmRestaurantId, rmMenuItemId )
VALUES  -- wow look who realized I only needed one query for this
--American
( 1, 1), ( 1, 2 ), ( 1, 3 ),
( 2, 1 ), ( 2, 2 ), ( 2, 4 ),
( 8, 1 ), ( 8, 2 ), ( 8, 3 ),
( 9, 1 ), ( 9, 2 ), ( 9, 4 ),
( 16, 1 ), ( 16, 2 ), ( 16, 3 ),
--Chinese
( 7, 5 ), ( 7, 6 ), ( 7, 7 ),
( 10, 5 ), ( 10, 6 ),
( 14, 5 ), ( 14, 6 ),
--Italian
( 3, 8 ), ( 3, 9 ), ( 3, 10 ),
( 5, 8 ), ( 5, 9 ),
( 6, 8 ), ( 6, 9 ), ( 6, 10 ),
--Korean
( 12, 11 ), ( 12, 12 ), ( 12, 13 ),
( 15, 11 ), ( 15, 12 ),
--Mexican
( 11, 14 ), ( 11, 15 ), ( 11, 17 ),
( 18, 14 ), ( 18, 15 ), ( 18, 16 ),
--Japanese
( 10, 19 ),
( 13, 18 ), ( 13, 19 ), ( 13, 20 ),
( 17, 18 ), ( 17, 19 ), ( 17, 20 ),
--Indian
( 4, 21 ), ( 4, 22 ), ( 4, 23 ),
( 12, 21 ), ( 12, 22 ), ( 12, 23 );

GO

-- INITIALIZE SCORES
INSERT INTO Scores ( score, date, scoredRestaurantId )
VALUES
( 96, '2022-11-19', 1),
( 92, '2022-10-16', 1),
( 100, '2022-04-18', 1),
( 58, '2022-07-15', 2),
( 36, '2022-12-05', 2),
( 12, '2022-07-09', 2),
( 81, '2022-03-23', 3),
( 30, '2022-02-22', 3),
( 17, '2022-04-06', 3),
( 13, '2022-05-31', 4),
( 82, '2022-08-01', 4),
( 38, '2022-12-11', 4),
( 37, '2022-06-28', 5),
( 96, '2022-04-12', 5),
( 58, '2022-08-31', 5),
( 13, '2022-07-24', 6),
( 91, '2022-04-10', 6),
( 68, '2022-04-14', 6),
( 3, '2022-05-27', 7),
( 42, '2022-07-02', 7),
( 3, '2022-10-29', 7),
( 85, '2022-12-03', 8),
( 21, '2022-09-17', 8),
( 83, '2022-02-20', 8),
( 81, '2022-11-25', 9),
( 45, '2022-01-21', 9),
( 2, '2022-07-08', 9),
( 85, '2022-05-07', 10),
( 15, '2022-10-31', 10),
( 3, '2022-03-26', 10),
( 63, '2022-07-29', 11),
( 64, '2022-09-25', 11),
( 29, '2022-03-06', 11),
( 50, '2022-01-01', 12),
( 70, '2022-06-29', 12),
( 75, '2022-05-06', 12),
( 45, '2022-12-11', 13),
( 84, '2022-10-22', 13),
( 96, '2022-03-31', 13),
( 61, '2022-09-27', 14),
( 14, '2022-06-02', 14),
( 25, '2022-04-05', 14),
( 65, '2022-10-12', 15),
( 12, '2022-09-24', 15),
( 28, '2022-08-18', 15),
( 0, '2022-07-17', 16),
( 10, '2022-11-07', 16),
( 5, '2022-04-21', 16),
( 80, '2022-06-10', 17),
( 1, '2022-03-15', 17),
( 60, '2022-01-04', 17),
( 97, '2022-02-08', 18),
( 87, '2022-10-30', 18),
( 86, '2022-12-20', 18);