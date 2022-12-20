--CREATE DATABASE RestaurantAssignment;

USE RestaurantAssignment;


DROP TABLE RestaurantMenus;
DROP TABLE RestaurantCuisines;
DROP TABLE Scores;
DROP TABLE MenuItems;
DROP TABLE Cuisines;
DROP TABLE Restaurants;

CREATE TABLE Restaurants (
    restaurantId INT IDENTITY PRIMARY KEY,
    restaurantName VARCHAR(255),
    grade CHAR,
    street VARCHAR(255),
    city VARCHAR(255),
    state VARCHAR(255)
);

CREATE TABLE MenuItems (
    menuItemId INT IDENTITY PRIMARY KEY,
    itemName VARCHAR(255),
    price DECIMAL(10, 2),
    menuCuisine INT
);

CREATE TABLE Cuisines (
    cuisineId INT IDENTITY PRIMARY KEY,
    cuisineName VARCHAR(255)
);

ALTER TABLE MenuItems
ADD FOREIGN KEY (menuCuisine) REFERENCES Cuisines(cuisineId);

CREATE TABLE Scores (
    scoreId INT IDENTITY PRIMARY KEY,
    score INT,
    date DATE,
    scoredRestaurantId INT FOREIGN KEY REFERENCES Restaurants(restaurantId)
);

CREATE TABLE RestaurantCuisines (
    rcId INT IDENTITY PRIMARY KEY,
    rcRestaurantId INT FOREIGN KEY REFERENCES Restaurants(restaurantId),
    rcCuisineId INT FOREIGN KEY REFERENCES Cuisines(cuisineId),
)

CREATE TABLE RestaurantMenus (
    rmId INT IDENTITY PRIMARY KEY,
    rmRestaurantId INT FOREIGN KEY REFERENCES Restaurants(restaurantId),
    rmMenuItemId INT  FOREIGN KEY REFERENCES MenuItems(menuItemId)
)