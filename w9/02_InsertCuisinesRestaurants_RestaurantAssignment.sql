USE RestaurantAssignment;

-- INITIALIZE CUISINES
INSERT INTO Cuisines ( cuisineName )
VALUES ('American');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Chinese');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Italian');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Korean');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Mexican');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Japanese');

INSERT INTO Cuisines ( cuisineName )
VALUES ('Indian');

SELECT * FROM Cuisines;


-- INITIALIZE RESTAURANTS
INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Regular Chow', 'D','114 W Hubert Ave','Buffalo','New York'); --American

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Regular Chow', 'B','7052 12th St','New York','New York'); --American

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Reggie''s', 'A','7054 12th St','New York','New York'); --Italian

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Taste and Sea', 'C','34574 Main St','Seattle','Washington'); --Indian

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Mario and Luigi''s', 'A','7485 Another Rd','Los Angeles','California'); --Italian

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Feasting Famiglia', 'C','606 Rodeo Dr','Los Angeles','California'); --Italian

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Festival Wok', 'A','2356 Blank St','Los Angeles','California'); --Chinese

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Big Man Big Food', 'A','4862 Avenue Ave','Orlando','Florida'); --American

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Mariner''s Marina', 'B','3428 E Sturgeon Rd','Seattle','Washington'); --American

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Umi no Yume', 'C','76379 Fun Dr','Orlando','Florida'); --Japanese, Chinese

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Abuelitamales', 'D','4650 Undertow Wy','Syracuse','New York'); --Mexican

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Taste and Sea', 'A','902 Autumn Ave','Rome','New York'); --Indian, Fusion, Korean

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Umi no Yume', 'A','32 E East Dr','Saratoga Springs','New York'); --Japanese

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Canaan Buffet', 'B','7486 Waverly Pl','Orlando','Florida'); --Chinese

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Heart and Seoul', 'B','4555 Seattle St','Seattle','Washington'); --Korean

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('THE Steakhouse', 'C','67878 Heather Rd','Dallas','Texas'); --American

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Tokyo, Texas', 'C','345 Steer St','Dallas','Texas'); --Japanese

INSERT INTO Restaurants ( restaurantName, grade, street, city, state)
VALUES ('Mas Grande', 'A','451568 Barrio Ave','Dallas','Texas'); --Mexican

SELECT * FROM Restaurants;


/*

*/