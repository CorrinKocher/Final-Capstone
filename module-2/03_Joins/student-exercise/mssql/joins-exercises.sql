-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Nick'
AND actor.last_name = 'Stallone';

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Rita'
AND actor.last_name = 'Reynolds';
-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT *
FROM actor
WHERE actor.first_name = 'River'

SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.actor_id = '35'
OR actor.actor_id = '143';

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT film.title
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = '6';

SELECT *
FROM category

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT film.title
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = '5';
-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT film.title
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = '3'
AND film.rating = 'G';
-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT film.title
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = '8'
AND film.rating = 'G'
AND film.length < 120;

select*
FROM ACTOR
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT film.title
FROM film_actor
JOIN actor ON film_actor.actor_id = actor.actor_id
JOIN film on film_actor.film_id = film.film_id
WHERE film.rating = 'G'
AND actor.actor_id = '103';
-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT film.title
FROM film_category
JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = '14'
AND film.release_year = 2006;
-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)


SELECT film.title
FROM film_category
JOIN film on film_category.film_id = film.film_id
join film_actor on film.film_id = film_actor.film_id
WHERE film_actor.actor_id ='44'
AND film_category.category_id ='1';
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT address.address, city, district, country
FROM store
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN country ON city.country_id = country.country_id

SELECT address.address, city, district, country -- how does it know where you are pulling city and district from???
FROM store --store tells you where you are matching the address ID but it isnt where you are displaying FROM. I thought thats what from meant.
JOIN address ON address.address_id = store.address_id --how can you join address to itself??? I thought you were join one table to another, and telling it what criteria youare matching on 
JOIN city ON city.city_id = address.city_id --so instead you are just saying join one peice of info from address to the entire row on city when these two fields match
JOIN country ON city.country_id = country.country_id  -- saying take everything from the row in country that has country id that matches but which country


--WHERE address.address_id = '1'
--OR address.address_id = '2';

SELECT *
FROM store

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address.address, staff.first_name, staff.last_name
FROM store
JOIN Staff on store.manager_staff_id = staff.staff_id
JOIN address ON store.address_id = address.address_id



-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)


SELECT customer.first_name, customer.last_name
FROM customer
WHERE customer.customer_id
IN(
SELECT TOP (10) rental.customer_id --count(*) AS 'Number  Of Rentals'
from rental
JOIN customer on rental.customer_id = customer.customer_id
GROUP BY rental.customer_id
ORDER BY count(rental.customer_id) DESC)



SELECT TOP (10) rental.customer_id, customer.first_name, customer.last_name
from rental
JOIN customer on rental.customer_id = customer.customer_id
GROUP BY rental.customer_id, customer.first_name, customer.last_name
ORDER BY count(rental.customer_id) DESC

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

select TOP (10) SUM(payment.amount) AS 'total spent by customer', payment.customer_id
FROM payment
GROUP BY payment.customer_id
ORDER BY [total spent by customer] DESC

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT address.address, store.store_id
FROM store
JOIN address ON store.address_id = address.address_id
JOIN ;



SELECT *
FROM payment

SELECT *
FROM rental

SELECT *
FROM store

SELECT *
FROM inventory
-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
