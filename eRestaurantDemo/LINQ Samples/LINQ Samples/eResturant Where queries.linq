<Query Kind="Expression">
  <Connection>
    <ID>0470e71a-0ced-4baa-957b-195905dfd7b1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//simple where clause

//List all tables that hold more than three people 
from row in Tables 
where row.Capacity > 3
select row

//List all items that are  with more than 500 Calories 
//more than 10.00
from row in Items 
where row.Calories>500  && row.CurrentPrice>10.00m
select row

//list all items with more tan 500 Calrioes and are
//entrees on the menu
//Hint: navigational propertis of the database and LinQpad Knowededge
from row in Items 
where row.Calories>500  && row.MenuCategory.Description.Equals("Entree")
select row
