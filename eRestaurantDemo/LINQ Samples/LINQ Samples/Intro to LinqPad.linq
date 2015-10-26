<Query Kind="Program" />

void Main()
{
	//"Hello "+ " don"+ " world"
	//5+7
	//string name= "don"; 
	//string message= "Hello "+ name + " world";
	//message.Dump();
	SayHello("don");
}

// Define other methods and classes here
 public void SayHello(string name){
 string message= "Hello "+ name + " world";
	message.Dump();
 }