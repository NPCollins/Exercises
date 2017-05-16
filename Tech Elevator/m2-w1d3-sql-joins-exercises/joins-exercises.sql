-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
--    Rows: 30

select * from film f
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name = 'Nick' and a.last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
--    Rows: 20

select * from film f
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where a.first_name = 'Rita' and a.last_name = 'Reynolds' 

-- 3. All of the films that Judy Dean or River Dean have appeared in
--    Rows: 46

select * from film f
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where (a.first_name = 'River' or a.first_name = 'Judy') and a.last_name = 'Dean' 

-- 4. All of the the ‘Documentary’ films
--    Rows: 68

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
where cat.category_id = 6

-- 5. All of the ‘Comedy’ films
--    Rows: 58

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
where cat.category_id = 5

-- 6. All of the ‘Children’ films that are rated ‘G’
--    Rows: 10 

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
where cat.category_id = 3 and f.rating = 'g'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
--    Rows: 3

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
where cat.category_id = 8 and f.rating = 'g' and f.length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
--    Rows: 9

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where f.rating = 'g' and a.first_name = 'matthew' and a.last_name = 'leigh'

-- 9. All of the ‘Sci-Fi’ films released in 2006
--    Rows: 61

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
where cat.category_id = 14 and f.release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
--     Rows: 2

select distinct f.title
from film_category fc
join film f on f.film_id = fc.film_id
join film_category cat on cat.category_id = fc.category_id
join film_actor fa on f.film_id = fa.film_id
join actor a on a.actor_id = fa.actor_id
where cat.category_id = 1 and a.first_name = 'Nick' and a.last_name = 'Stallone'

-- 11. The address of all stores, including street address, city, district, and country
--     Rows: 2

select st.address_id, addr.address, cit.city, addr.district, c.country
from address addr
join city cit on cit.city_id = addr.city_id
join country c on cit.country_id = c.country_id
join store st on st.address_id = addr.address_id


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
--     Rows: 2

select st.address_id, addr.address, cit.city, addr.district, c.country
from address addr
join city cit on cit.city_id = addr.city_id
join manager
join store st on st.address_id = addr.address_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
--     Hint: #1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals

select c.first_name, c.last_name, count(r.rental_id) Rentals
from customer c
join rental r on c.customer_id = r.customer_id
group by c.first_name, c.last_name
order by Rentals desc

-- 14. The first and last name of the top ten customers ranked by dollars spent 
--     Hint: #1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent



-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
--     Hint: Store 1 has 7928 total rentals and Store 2 has 8121 total rentals

-- 16. The top ten film titles by number of rentals 
--     Hint: #1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals

-- 17. The top five film categories by number of rentals 
--     Hint: #1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals

-- 18. The top five Action film titles by number of rentals 
--     Hint: #1 should have 30 rentals and #5 should have 28 rentals

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
--     Hint: #1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
--     Hint: #1 should have 87 rentals and #5 should have 72 rentals
