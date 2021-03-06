-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
SELECT *
fROM actor

INSERT INTO actor
(first_name, last_name)
VALUES ('Hampton', 'Avenue')
INSERT INTO actor
(first_name, last_name)
VALUES
('Lisa', 'Byway')
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
select *
FROM film

INSERT INTO film
(title, description, release_year, language_id, original_language_id, rental_duration, rental_rate, length, replacement_cost, rating)
VALUES
('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 1, 3, 4.99, 198, 20.99, 'G')
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
SELECT *
FROM film_actor
WHERE film_id = 100;


SELECT *
FROM actor

INSERT INTO film_actor
(actor_id, film_id)
VALUES
(201, 1001)

INSERT INTO film_actor
(actor_id, film_id)
VALUES
(202, 1001)
-- 4. Add Mathmagical to the category table.
SELECT *
FROM category

INSERT INTO category
(name)
VALUES
('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
UPDATE film_category
SET category_id = 17
WHERE film_id IN
(Select film.film_id
FROM film
WHERE title = 'EGG IGBY')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(Select film.film_id
FROM film
WHERE title = 'KARATE MOON')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(Select film.film_id
FROM film
WHERE title = 'RANDOM GO')

UPDATE film_category
SET category_id = 17
WHERE film_id IN
(Select film.film_id
FROM film
WHERE title = 'YOUNG LANGUAGE')

SELECT *
FROM film_category

SELECT *
FROM film

INSERT INTO film_category
(film_id, category_id)
VALUES
(1001, 17)


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film
SET rating = 'G'
WHERE film_id IN
(SELECT film_category.film_id
FROM film_category
WHERE film_category.category_id = 17)

-- 7. Add a copy of "Euclidean PI" to all the stores.
-- insert into inventory
SELECT *
FROM inventory

INSERT INTO inventory
(film_id, store_id)
VALUES
(1001, 1)

INSERT INTO inventory
(film_id, store_id)
VALUES
(1001, 2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
--This failed  because film id 1001 is a foreign key in film_actor 
SELECT *
FROM film
WHERE title = 'Euclidean PI';

DELETE
FROM film
WHERE title = 'Euclidean PI';

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- it failed because mathmagical is a foreign key in film_category
SELECT *
FROM category

DELETE
FROM category
WHERE name = 'Mathmagical';
-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
Yes, because category ID was a primary key and a foreign key
SELECT *
FROM film_category

DELETE
FROM film_category
WHERE category_id = 17;

--UPDATE film
--SET rating = null
--WHERE film_id IN
--(SELECT film_id
--FROM film_category
--WHERE film_category.category_id = 17)
-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
-- I was able to delete the mathmagical category because it did not have any remaining foreign keys, but I
-- couldnt delete the movie because it had foriegn keys in the film_Actor table
SELECT *
FROM category

DELETE
FROM CATEGORY
WHERE name = 'Mathmagical';

DELETE
FROM film
WHERE title = 'Euclidean PI';
-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
--Film ID needs to be deleted from film_actor so that film ID has no other foreignkeys and then the film can be deleted. 