-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO actor (first_name, last_name)  
VALUES ('Hampton', 'Avenue');

INSERT INTO actor (first_name, last_name)  
VALUES ('Lisa', 'Byway');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	

insert into film (title, description, release_year,	language_id, original_language_id, rental_duration,	rental_rate, length, replacement_cost, rating)
values ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008,	1, NULL, 1,	3.99, 198, 18.99, 'PG-13')

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

insert into film_actor (actor_id, film_id)
values ( 201,1003)

insert into film_actor (actor_id, film_id)
values ( 202,1003)

-- 4. Add Mathmagical to the category table.

insert into category (name)
values ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

insert into film_category (film_id, category_id)
values (1003, 17)

update film_id
set category_id = 17
where film_id = 274 or film_id = 494 or film_id = 714 or film_id = 996 or film_id = 1003

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)

update film
set rating = 'G'
from film_category fc
join film f on fc.film_id = f.film_id
where fc.category_id = 17


-- 7. Add a copy of "Euclidean PI" to all the stores.

insert into inventory(film_id, store_id)
values (1003, 1)

insert into inventory(film_id, store_id)
values (1003, 2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)

delete from film 
where film_id = 1003

-- Doesn't work because film id 1003 is being used in another table.

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)

delete from category 
where category_id = 17

-- Doesn't work because category_id 17 is being used in another table.

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)

delete from film_category
where category_id = 17

-- Worked because no other table was relying on the deleted information

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)

delete from category 
where category_id = 17

-- worked because film_category is no longer using the category_id 17

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.


