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

select (name + ', ' + district) name_and_state, population
from city
where district = 'Pennsylvania' or district ='West Virginia' or district ='Kentucky' or district ='Indiana' or district = 'Michigan'
order by district, name

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)

select (name + ', ' + code) country_and_code, region
from country
where region like '%africa'

-- 3. The per capita GNP (i.e. GNP divided by population) of all countries in the 
-- world sorted from highest to lowest 
-- (232 rows)

select name, gnp, population, (gnp / population) * 1000000 PCGNP
from country
where population is not null and population != 0
order by PCGNP desc

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)

select avg(lifeexpectancy) Average_lifeexpectancy_South_America
from country
where region like 'south america'

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)

select sum(population) California_Population
from city
where district = 'california'

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)

select sum(population) China_Population
from city
where countrycode = 'chn'


-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)

select max(population) population
from country


-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)

select max(population)
from city


-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)

select max(population)
from city
where countrycode = 'aus'

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)

select min(population)
from country
where population != 0

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)

select avg(population)
from city
where countrycode = 'usa'

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)

select avg(population)
from city
where countrycode = 'chn'

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")

SELECT continent, sum(surfacearea) continental_area
  FROM country
 GROUP BY continent
 order by continental_area desc

-- 14. The highest population density (surface area divided by population) of all 
-- countries in the world. 
-- (highest population density in world: 38.6801)

select max((surfacearea/population)) popdense
from country
where population != 0


-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 0.006, "Andorra")

select top 10 name, (surfacearea/population) popdense, lifeexpectancy
from country
where population != 0
order by lifeexpectancy desc

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")

select name, (gnp - gnpold) gnp_diff, abs((gnp - gnpold)) abs_gnp_diff
from country
order by abs_gnp_diff desc


-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
	
select countrycode, avg(population) average_pop
from city
group by countrycode
order by average_pop DESC

-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
	
select district, count(name) city_count
from city
where countrycode = 'usa'
group by district
order by city_count desc

-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")

select continent, count(name) country_count
from country
group by continent
	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
	
select countrycode, count(name) city_count
from city
group by countrycode
order by city_count desc

-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")

select countrycode, max(population) population
from city
group by countrycode
order by population DESC

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")

select avg(lifeexpectancy) avg_lifeexpectancy, min(lifeexpectancy) min_lifeexpectancy, max(lifeexpectancy) max_lifeexpectancy, continent
from country
where lifeexpectancy is not null
group by continent
order by avg_lifeexpectancy
