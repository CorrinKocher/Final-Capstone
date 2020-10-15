-- SELECT ... FROM
-- Selecting the names for all countries
Select * FROM country;

Select name FROM country;
-- Selecting the name and population of all countries

Select name, population FROM country;
-- Selecting all columns from the city table
SELECT * FROM CITY;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT * 
FROM city 
where district = 'Ohio';

-- Selecting countries that gained independence in the year 1776
SELECT *
from country
where indepyear = 1776;

-- Selecting countries not in Asia
SELECT *
from country
where continent != 'Asia';

select*
from country;

-- Selecting countries that do not have an independence year
SELECT *
FROM country
where indepyear IS NULL;
-- Selecting countries that do have an independence year
SELECT *
FROM country
where indepyear IS NOT NULL;

-- Selecting countries that have a population greater than 5 million
SELECT *
from country
where population > 5000000;



-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000

SELECT *
FROM city
WHERE district = 'Ohio'
AND population > 400000

-- Selecting country names on the continent North America or South America

SELECT name Name, continent Continent
from country
where continent = 'North America'
OR continent = 'South America';


-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword

SELECT surfacearea, population, population/surfacearea 'pop density'
FROM country

