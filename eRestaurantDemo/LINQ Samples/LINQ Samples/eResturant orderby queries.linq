<Query Kind="Expression">
  <Connection>
    <ID>0470e71a-0ced-4baa-957b-195905dfd7b1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//order by 

//defualt ascending
from food in Items 
orderby food.Description 
select food 

//defualt  descending
from food in Items 
orderby food.CurrentPrice descending
select food 

//defualt ascending  descending
from food in Items 
orderby food.CurrentPrice descending, food.Calories ascending
select food 

//defualt  where clause ascending  descending
from food in Items 
where food.MenuCategory.Description.Equals("Entree")
orderby food.CurrentPrice descending, food.Calories ascending
select food 

