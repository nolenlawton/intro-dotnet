Console.WriteLine("Hello, World!");

//  Make a string
string myString = "my string";

Console.WriteLine(myString);

//  Make a number (what kind? There are multiple!)
int a = 8;
double b = 8;
decimal c = 8;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//  Make a boolean
bool isBoolean = true;

Console.WriteLine(isBoolean);

//  Make an if / else if / else block
if (isBoolean) {
    Console.WriteLine("this is true");
} else {
    Console.WriteLine("this is false");
}

//  Make a switch block
switch(a) 
{
  case 1:
    Console.WriteLine("a is 1");
    break;
  case 2:
    Console.WriteLine("a is 2");
    break;
  default:
    Console.WriteLine("default");
    break;
}

//  Make an array of strings
string[] arrayOfStrings = {"One", "Two", "Three"};

Console.WriteLine("list of strings " + arrayOfStrings[0] + arrayOfStrings[1] + arrayOfStrings[2]);

//  Make a for loop
for (int i = 0; i < 3; i++){
    //  Log each item
    Console.WriteLine("for loop " + arrayOfStrings[i]);
};

//  Use a foreach loop
foreach (string i in arrayOfStrings) 
{
  Console.WriteLine("foreach loop " + i);
};

//  Use a List instead of an array (HINT)
List<string> listOfStrings = new List<string>();
listOfStrings.Add("One");
listOfStrings.Add("Two");
listOfStrings.Add("Three");

Console.WriteLine("list of strings " + listOfStrings[0] + listOfStrings[1] + listOfStrings[2]);

//  Make a class (object structure)
class Player 
{
  string color = "red";
  int shoes = 2;
  bool strong = true;
}

//  Instantiate a class (make a new object)

// class Game 
// {
//     Player player1 = new Player();
// }

//  Make a method (a function inside a class)

// class House
// {
//     string WashDishes(){
//         //  Return a value
//         return "wash dishes";
//     }


// }

//  Call from instance of class


//  Make an array of objects
//  Loop over array of objects