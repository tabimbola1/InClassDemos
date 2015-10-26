<Query Kind="Program">
  <Connection>
    <ID>0470e71a-0ced-4baa-957b-195905dfd7b1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	//anoymous type 
	//from food in Items 
	//where food.MenuCategory.Description.Equals("Entree") && food.Active 
	//orderby food.CurrentPrice descending 
	//select new {  
	//
	//Description = food.Description, 
	//Price = food.CurrentPrice ,
	//Cost= food.CurrentCost, 
	//profit = food.CurrentPrice - food.CurrentCost
	//}
	//
	//
	//from food in Items 
	//where food.MenuCategory.Description.Equals("Entree") && food.Active 
	//orderby food.CurrentPrice descending 
	//select new {  
	//
	//Description = food.Description, 
	//food.CurrentPrice ,
	//food.CurrentCost, 
	////profit = food.CurrentPrice - food.CurrentCost
	//}
	
	// type query set 
	 var results = from food in Items 
	where food.MenuCategory.Description.Equals("Entree") && food.Active 
	orderby food.CurrentPrice descending 
	select new foodMargin() 
	{  
	
	Description = food.Description, 
	Price = food.CurrentPrice ,
	Cost= food.CurrentCost, 
	Profit = food.CurrentPrice - food.CurrentCost
	};
	results.Dump();
	
	var results2= from orders in Bills 
	 where orders.PaidStatus && 
	 (orders.BillDate.Month ==9 && orders.BillDate.Year==2014)
	 orderby orders.Waiter.LastName, orders.Waiter.FirstName 
	 select new BillOrders()
	 {
	  BillID = orders.BillID,
	  Waiter = orders.Waiter.LastName+ ","+ orders.Waiter.FirstName,
	  Orders= orders.BillItems
	 };
	 
	 results2.Dump();
}




// Define other methods and classes here
//sample of a Poco type class flat data set no structures 
public class foodMargin {
public string Description {get;set;}
public decimal Price{get;set;}
public decimal Cost {get;set;}
public decimal Profit {get;set;} 

}


//Sample of a DTO type class: flat date set with possible structures 
public class BillOrders {
public int BillID {get;set;}
public string Waiter {get;set;}
public IEnumerable Orders {get;set;}

}
