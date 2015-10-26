<Query Kind="Expression">
  <Connection>
    <ID>0470e71a-0ced-4baa-957b-195905dfd7b1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//grouping 
from food in Items 
group food by food.MenuCategory.Description

//requires the creation of an anyomous type
from food in Items 
group food by new {food.MenuCategory.Description, food.CurrentPrice}