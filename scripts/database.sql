-- display names all databases from sql server
SELECT name FROM sys.databases

-- create database
CREATE DATABASE Testing

-- switch to typed database
USE Testing

-- create table in current context
CREATE TABLE Items (
    id INT NOT NULL PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
)

-- populate table
INSERT INTO Items (id, name) VALUES (1, 'Sword')
INSERT INTO Items (id, name) VALUES (2, 'Axe')
INSERT INTO Items (id, name) VALUES (3, 'Staff')
INSERT INTO Items (id, name) VALUES (4, 'Bow')
INSERT INTO Items (id, name) VALUES (5, 'Crossbow')

-- display all elements from Items table
SELECT * FROM Items