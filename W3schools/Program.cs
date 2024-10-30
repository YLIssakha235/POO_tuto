// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// int myInt = 9;
// double myDouble = myInt;
// Console.WriteLine(myInt);
// Console.WriteLine(myDouble);

// ici on comprends clairement que double renvoie une valeur float contrairement a int
// meme pour cela on doit tres bien mettre () int a fin d'avoir une bonne reponse
// il s'agit d'une conversion explicite
// double myDouble = 9.78;
// int myInt = (int) myDouble;
// Console.WriteLine(myInt);
// Console.WriteLine(myDouble);

int myInt = 10;
double myDouble = 5.25;
bool myBool = false;

// Console.WriteLine(Convert.ToString(myInt));    // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
// Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
// Console.WriteLine(Convert.ToDouble(myBool));

/* dans ces lignes de code on voit clairement la conversion de type 
il suffit de bien mettre les lignes de code puis on aura ce dont on cherche
- de int to float on Console.WriteLine(Convert.ToDouble(variable));
ce qui est intriguant ce que qd je convertis un Bool == 0 ou 1

*/


/*
// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

*/

// dans cette partie je dois utiliser la conversion car il n'accepete pas le string à la place de int

// Console.WriteLine("Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your age is: " + age);

// int x = 100 + 50;
// Console.WriteLine(x);

// string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// Console.WriteLine("The length of the txt string is: " + txt.Length);

// string txt = "Hello World";
// Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
// Console.WriteLine(txt.ToLower());   // Outputs "hello world"


// string firstName = "John ";
// string lastName = "Doe";
// string name = firstName + lastName;
// Console.WriteLine(name);

// string firstName = "John ";
// string lastName = "Doe";
// string name = string.Concat(firstName, lastName);
// Console.WriteLine(name);

// string firstName = "John";
// string lastName = "Doe";
// string name = $"My full name is: {firstName} {lastName}";
// Console.WriteLine(name);

// string myString = "Hello";
// Console.WriteLine(myString[0]);  // Outputs "H"

// string myString = "Helleeeeo";
// Console.WriteLine(myString.IndexOf("e"));  // Outputs "1

// commutateur switch

// int day = 4;
// switch (day) 
// {
//   case 1:
//     Console.WriteLine("Monday");
//     break;
//   case 2:
//     Console.WriteLine("Tuesday");
//     break;
//   case 3:
//     Console.WriteLine("Wednesday");
//     break;
//   case 4:
//     Console.WriteLine("Thursday");
//     break;
//   case 5:
//     Console.WriteLine("Friday");
//     break;
//   case 6:
//     Console.WriteLine("Saturday");
//     break;
//   case 7:
//     Console.WriteLine("Sunday");
//     break;
// }
// // Outputs "Thursday" (day 4)

// int day = 4;
// switch (day) 
// {
//   case 6:
//     Console.WriteLine("Today is Saturday.");
//     break;
//   case 7:
//     Console.WriteLine("Today is Sunday.");
//     break;
//   default:
//     Console.WriteLine("Looking forward to the Weekend.");
//     break;
// }
// // Outputs "Looking forward to the Weekend."


// int i = 0;
// while (i < 5) 
// {
//   Console.WriteLine(i);
//   i++;
// }


// int i = 0;
// do 
// {
//   Console.WriteLine(i);
//   i++;
// }
// while (i < 5);

// for (int i = 0; i < 5; i++) 
// {
//   Console.WriteLine(i);
// }

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// foreach (string i in cars) 
// {
//   Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++) 
// {
//   if (i == 2) 
//   {
//     break;
//   }
//   Console.WriteLine(i);
// }

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Console.WriteLine(cars[0]);
// int[] myNum = {10, 20, 30, 40};

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// for (int i = 0; i < cars.Length; i++) 
// {
//   Console.WriteLine(cars[i]);
// }


// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// foreach (string i in cars) 
// {
//   Console.WriteLine(i);
// }

// // Sort a string
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Array.Sort(cars);
// foreach (string i in cars)
// {
//   Console.WriteLine(i);
// }

// // Sort an int
// int[] myNumbers = {5, 1, 8, 9};
// Array.Sort(myNumbers);
// foreach (int i in myNumbers)
// {
//   Console.WriteLine(i);
// }


// int[] myNumbers = {5, 1, 8, 9};
// Console.WriteLine(myNumbers.Max());  // returns the largest value
// Console.WriteLine(myNumbers.Min());  // returns the smallest value
// Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    

// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
// Console.WriteLine(numbers[0, 2]);  // Outputs 2

