<Query Kind="Statements">
  <Connection>
    <ID>0470e71a-0ced-4baa-957b-195905dfd7b1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//step 1 connect to the desired database
// click on add connection 
// take defaults press next
// change server to . (dot) select database from drop down list 
//optionally press Test Connection 
// press ok 
//remember to check the connection drop down list to see which database is active connection

//result should show database tables in connection object area 
//expanding table  will reveal talbe attrributes and any relationships

//View waiter data
Waiters

//query syntax to also view waiter data 
from item in Waiters
select item

//method syntax to view waiter data 
Waiters.Select (item => item)

//alter the query syntax into a C# statement
var results = from item in Waiters 
select item;
results.Dump();

//once the query is created/tested you will be able to
//transfer the wuery with minor modifications into your
//Bll Methods
//public List<pocoObject> SommBLLMethodName() 
//{
//Connect to your DAL Odject : var contextVariable
//do your query
//var results = from item in contextVariable.nWaiters 
//select item;
//return results.ToList();

//}