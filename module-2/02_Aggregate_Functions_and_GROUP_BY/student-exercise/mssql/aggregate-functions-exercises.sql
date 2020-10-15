-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT * --need help
FROM city
WHERE district = 'Pennsylvania', 'West Virginia', 'Kentucky', 'Indiana', 'Michigan'
ORDER BY
GROUP BY

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT CONCAT(country.name, ' (', country.region, ')') AS 'country_and_code'
FROM country
WHERE country.continent ='Africa'

-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)
SELECT (country.gnp*1000000)/country.population AS 'percapitaGNP' -- need help
FROM country
ORDER BY [percapitaGNP] DESC;

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)
SELECT AVG(lifeexpectancy)
FROM country
WHERE country.continent= 'South America';

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)
SELECT SUM(city.population) AS 'Total population of Cali'
FROM city
WHERE city.district = 'California';

select *
from city
-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)
SELECT SUM(city.population) AS 'Total Population in China'
FROM city
WHERE city.countrycode = 'CHN'

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)
SELECT MAX(country.population) AS 'Most populated country in the world'
FROM country

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)
SELECT MAX(city.population) AS 'Most populated City in the World'
FROM city

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)
SELECT MAX(city.population) AS 'Austrailias Most Populated City'
FROM city
WHERE city.countrycode = 'AUS'

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)
SELECT MIN(country.population) AS 'Least populated country in the world'
FROM country
WHERE country.population > 0;

SELECT *
FROM country
-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)
SELECT AVG(city.population) -- did not get decimal is that wrong??
FROM city
WHERE city.countrycode = 'USA';

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)
SELECT AVG(city.population) -- did not get decimal is that wrong?? convert(decimal)
FROM city
WHERE city.countrycode = 'CHN';
-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")
SELECT SUM(country.surfacearea) AS 'Continents Surface Area', country.continent -- why AM I 5 off?
FROM country
GROUP BY country.continent
ORDER BY country.continent DESC;

SELECT country.surfacearea
FROM country

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)
SELECT MAX(country.population/country.surfacearea)
FROM country

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")
SELECT TOP (10)country.lifeexpectancy, (country.population/country.surfacearea) AS 'Population Density', country.name
FROM country
ORDER BY country.lifeexpectancy DESC

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")
SELECT ABS(country.ABSDifference)--- why wont it recognize the column name i created? I know I need to make one pos and one NEG, but I cant even get the ABS to work
FROM country
Group BY name
WHERE country.ABSDifference -- what am I doing wrong here? 
IN(
SELECT SUM(country.gnp-country.gnpold) AS 'ABSDifference'
FROM country
GROUP BY name)


-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
SELECT AVG(city.population) AS 'AVGPOP', city.countrycode
FROM city
GROUP BY city.countrycode
ORDER BY AVGPOP DESC
-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
SELECT COUNT(city.name) AS 'Number Of Cities', city.district
FROM city 
WHERE city.countrycode = 'USA'
GROUP BY city.district
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")
SELECT COUNT(country.name) AS 'Number Of Countries', country.continent
FROM country
GROUP BY country.continent
ORDER BY [Number Of Countries] DESC
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
SELECT COUNT(city.name) AS 'Number Of Cities', city.countrycode
FROM city 
GROUP BY city.countrycode
ORDER BY [Number Of Cities] DESC
-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")
SELECT MAX(city.population) AS 'city with largest population', city.countrycode
FROM city
GROUP BY city.countrycode
ORDER BY [city with largest population] DESC
-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")
SELECT country.continent, AVG(country.lifeexpectancy) AS 'avg expectancy', MIN(country.lifeexpectancy) AS' min life expectancy', MAX(country.lifeexpectancy) AS 'MAX life expectancy'
FROM country
WHERE country.lifeexpectancy IS NOT NULL
GROUP BY country.continent
ORDER BY [avg expectancy] DESC