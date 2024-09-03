CREATE DATABASE CustomerDB;

USE CustomerDB;

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20)
);
