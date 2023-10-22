//int counter = 1000;

//while (counter > 1) {

//    //if (counter == 0) {
//    //	Console.WriteLine("im zero");
//    //}

//    //if (counter > 5) {
//    //	Console.WriteLine("Im bigger than 5");
//    //} else {
//    //	Console.WriteLine("Im less than 5");
//    //}

//    Console.WriteLine("counter: " + counter);

//    counter--;

//    if (counter > 20) {
//		counter -= 2;
//	}

//	if (counter > 80) {
//		counter -= 5;
//	}

//}

//counter = 1000;

//Console.WriteLine("Im the end! " + counter);


//Console.WriteLine("select an option:");
//Console.WriteLine("1: Add apples");
//Console.WriteLine("2: Add cars");
//Console.WriteLine("3: thermal nuclear war");
//Console.WriteLine("4: Delete all data");
//Console.WriteLine("99: Exit");

//string input = Console.ReadLine();
//int selection = int.Parse(input);

//int maxCommands = 10;
//int commandCount = 0;

//while (selection != 99 && commandCount < maxCommands) {
//	if (selection == 1) {
//		Console.WriteLine("apples added");
//	} else if (selection == 2) {
//		Console.WriteLine("cars added");
//	} else if (selection == 3) {
//		Console.WriteLine("lets play a game");
//	} else if (selection == 4) {
//		Console.WriteLine("all data deleted!");
//	} else if (selection == 99) {
//		Console.WriteLine("EXIT");
//	} else {
//		Console.WriteLine("unknown command");
//	}

//	commandCount++;

//	Console.WriteLine("select an option:");
//	Console.WriteLine("1: Add apples");
//	Console.WriteLine("2: Add cars");
//	Console.WriteLine("3: thermal nuclear war");
//	Console.WriteLine("4: Delete all data");
//	Console.WriteLine("99: Exit");

//	input = Console.ReadLine();
//	selection = int.Parse(input);



//}
//Console.WriteLine("bye");


//do {
//	i++;
//    Console.WriteLine("Hello from the do loop, " + i);
//} while (false);

//Console.WriteLine("Hello from the end of the program");
/*
string input2 = "";
int selection2 = 0;
do {
	Console.WriteLine("select an option:");
	Console.WriteLine("1: Add apples");
	Console.WriteLine("2: Add cars");
	Console.WriteLine("3: thermal nuclear war");
	Console.WriteLine("4: Delete all data");
	Console.WriteLine("99: Exit");

	bool parsedOK = true;
	int maxTries = 3;
	int tries = 0;
	do {
		Console.WriteLine("enter a numeric value:");
		input2 = Console.ReadLine();
		parsedOK = int.TryParse(input2, out selection2);
		if (!parsedOK) {
			tries++;
			Console.WriteLine("invalid input, try again (tries: "+ tries +")");
		}
		if (tries > maxTries) {
			parsedOK = true;
			selection2 = 99;
		}
	} while (!parsedOK);

	switch (selection2) {
		case 1:
			Console.WriteLine("apples added");
			break;
		case 2:
			Console.WriteLine("cars added");
			break;
		case 3:
			Console.WriteLine("lets play a game");
			break;
		case 4:
			Console.WriteLine("all data deleted!");
			break;
		case 99:
			Console.WriteLine("EXIT");
			break;
		default:
			Console.WriteLine("unknown command");
			break;
	}

} while (selection2 != 99);

Console.WriteLine("bye");

// tab = "\t"
// newline = "\n"
// backslash = "\\"
// quote = "\""

/*
1	2	3	4	5	
11	22	33	44	55	
111	222	333	444	555
*/
// Write a program that outputs the times table for numbers 1-10
// as a bonus - allow the user to input the number of times
// tables to output
/*
1 2  3  4  5
2 4  6  8  10
3 6  9  12 15
4 8  12 16 20
5 10 15 20 25
*/

/*int range;
do {
	Console.WriteLine("Enter a value for the table:");
    Console.WriteLine("(a negative value will exit)");

	bool parsedOK;
	do {
		Console.WriteLine("enter a numeric value:");
		string input2 = Console.ReadLine();
		parsedOK = int.TryParse(input2, out range);
		if (!parsedOK) {
			Console.WriteLine("invalid input, try again");
		}
	} while (!parsedOK);

	int row = 1;
	while (row <= range) {
		int col = 1;
		while (col <= range) {
			int result = col * row;

			Console.Write(result + "\t");

			col++;
		}
		Console.WriteLine();
		row++;
	}
} while (range > 0);*/
/*
int s = 0;
while (s < 10) {
	//Console.WriteLine("......");

	s++;
}

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
int topRange = int.Parse(input);

for (int i = 0; i < topRange; i++) {
	Console.WriteLine("for loop: " + i);
}

for (int i = topRange; i > 0; i--) {
	Console.WriteLine("for loop: " + i);
}

Console.WriteLine("end..");
*/
// take the code above (the times table)
// and convert it to a for loop

/*
while (true) { 
	Console.WriteLine("enter a number:");
	string input2 = Console.ReadLine();
	int topRange = int.Parse(input2);

	if (topRange < 0) {
		break;
	}

	for (int row = 1; row <= topRange; row++) {
		for (int col = 1; col <= topRange; col++) {
			Console.Write((col * row) + "\t");

			if (col > 4) {
				break;
			}
		}

		if (row > 6) {
			break;
		}

		Console.WriteLine();
	}
}*/


// DIE - Duplication is Evil
// DRY - Don't Repeat Yourself


/*returnType/void MethodName(int x, string joke, bool youOK) {
	// code
}*/



//void SaySomething(string message) {
//	Console.WriteLine(message);
//	Console.WriteLine(message + "!");
//}

//SaySomething("Hello");
//SaySomething("Goodbye");





/*
Exercise1: Number Guessing Game
Objective: Implement a number guessing game where the computer randomly selects a number between 1 and 100, and the user has to guess it.

// Generate a random number between 1 and 100.
Random random = new Random();
int secretNumber = random.Next(1, 101);

Steps:
The computer should randomly select a number between 1 and 100.
Prompt the user to enter a guess.
If the user's guess is too high, display "Too high! Try again."
If the user's guess is too low, display "Too low! Try again."
If the user guesses the number, display "Congratulations! You've guessed the right number in [number of attempts] attempts."
The game should continue until the user guesses the correct number.
Bonus:

Limit the user to a maximum of 10 attempts. If they don't guess the number within these attempts, reveal the number to them and end the game.
*/
/*

Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine("Welcome to my game");
Console.WriteLine("Try to guess my number between 1 and 100");
Console.WriteLine("------------------------------------------");

int numberOfAttempts = 0;
const int maxAttempts = 10;

while (true) {
	Console.WriteLine("Enter your guess:");
	string input = Console.ReadLine();
	int guess = 0;

	if (!int.TryParse(input, out guess) || guess < 1 || guess > 100) {
		Console.WriteLine("Sorry, not a valid value, please try again");
		continue;
	}

	numberOfAttempts++;

	if (guess > secretNumber) {
		Console.WriteLine("Wrong! your guess is too high");
	} else if (guess < secretNumber) {
		Console.WriteLine("Wrong! your guess is too low");
	} else {
        Console.WriteLine("Congratulations, you guessed it in " + numberOfAttempts + " tries");
		break;
    }


	if (numberOfAttempts > maxAttempts) {
        Console.WriteLine("You have tried too many times, sorry, goodbye.");
        Console.WriteLine("the correct answer was: " + secretNumber);
        break;
    }
}

Console.WriteLine("End of game");*/

/*

Exercise: FizzBuzz with a Twist
Objective: Implement the FizzBuzz program with a twist. Instead of the traditional rules, allow the user to set their own multiples and terms, then display the results.

Traditional FizzBuzz: For numbers from 1 to 100:

If the number is a multiple of 3, print "Fizz".
If the number is a multiple of 5, print "Buzz".
If the number is a multiple of both 3 and 5, print "FizzBuzz".
Otherwise, print the number.



FizzBuzz with a Twist Steps:

Prompt the user for two integers (between 1 and 100) - these will replace the traditional 3 and 5.
Prompt the user for two terms (words or phrases) - these will replace the traditional "Fizz" and "Buzz".
For numbers from 1 to 100:
If the number is a multiple of the first user-provided integer, print the first term.
If the number is a multiple of the second user-provided integer, print the second term.
If the number is a multiple of both integers, print both terms concatenated.
Otherwise, print the number.
 
 */

//void FizzBuzzLogic2(int num1 = 3, string val1 = "Fizz", int num2 = 5, string val2 = "Buzz", int max = 100) {
//	for (int i = 1; i <= max ; i++) {
//		if (i % num2 == 0 && i % num1 == 0) {
//			Console.WriteLine(val1 + val2 + " (" + i + ")");
//		} else if (i % num1 == 0) {
//			Console.WriteLine(val1 + " (" + i + ")");
//		} else if (i % num2 == 0) {
//			Console.WriteLine(val2 + " (" + i + ")");
//		} else {
//			Console.WriteLine(i);
//		}
//	}
//}

//void FizzBuzzLogic(int num1, string val1, int num2, string val2, int max = 150) {
//	for (int i = 1; i <= max; i++) {
//		string result = "";

//		if (i % num1 == 0) {
//			result = val1;
//		}

//		if (i % num2 == 0) {
//			result += val2;
//		}

//		if (result == "") {
//			result = i.ToString();
//		}

//		Console.WriteLine(result);
//	}
//}

//int GetANumber(string name) {
//	Console.WriteLine("Enter the " + name + " number:");
//	string input = Console.ReadLine();
//	int result = 0;
//	if (int.TryParse(input, out result)) {
//		return result;
//	}

//	Console.WriteLine("Invalid input, setting to 0");

//	return 0;
//}

//string GetAWord(string name) {
//	Console.WriteLine("Enter the " + name + " word:");
//	return Console.ReadLine();
//}

//const string name1 = "first";
//const string name2 = "second";

//int limit = GetANumber("upper limit");

//int firstNumber = GetANumber(name1);
//int secondNumber = GetANumber(name2);

//string firstWord = GetAWord(name1);
//string secondWord = GetAWord(name2);

//Console.WriteLine("-------------------------------------");

//FizzBuzzLogic(firstNumber, firstWord, secondNumber, secondWord, limit);

//Console.WriteLine("-------------------------------------");

//FizzBuzzLogic2(firstNumber, firstWord, secondNumber, secondWord);

//Console.WriteLine("-------------------------------------");

//FizzBuzzLogic2(firstNumber, firstWord, secondNumber, secondWord, limit);

//Console.WriteLine("-------------------------------------");

//FizzBuzzLogic2();



/* Exercises:

1. Basic Price Calculation:

Write a method named CalculatePrice that:

Takes in the number of books purchased by a customer.
Each book costs $10.
Returns the total cost.
*/
//decimal CalculatePrice(int numberOfBooks) {
//    return numberOfBooks * 10; 
//}

//decimal response = CalculatePrice(5);

//Console.WriteLine("5 books cost: " + response);


//2. Applying Discounts:

//Write a method named ApplyDiscount that:

//Takes in the original price.
//Takes an optional discount parameter. If no discount is provided, use a default discount of 5%.
//Returns the price after applying the discount.
//*/

//decimal ApplyDiscount(decimal originalPrice, decimal discountPercentage = 0.05M) {
//	if (discountPercentage > 0.5M) {
//        Console.WriteLine("Too much discount, not allowed");
//		return originalPrice;
//		//discountPercentage = 0.5M;
//    }

//	decimal totalPercentage = 1 - discountPercentage;
//	decimal result = originalPrice * totalPercentage;
//	return result;
//}

//response = ApplyDiscount(100);
//Console.WriteLine("Discount of 5% on 100$ is: " + response);
//response = ApplyDiscount(200, 0.10M);
//Console.WriteLine("Discount of 10% on 200$ is: " + response);
//response = ApplyDiscount(500, 0.30M);
//Console.WriteLine("Discount of 30% on 500$ is: " + response);
//response = ApplyDiscount(1000, 0.60M);
//Console.WriteLine("Discount of 60% on 1000$ is: " + response);

//3. Printing Purchase Summary:

//Write a method named PrintSummary that:

//Takes in the number of books.
//Calls CalculatePrice to get the original price.
//Calls ApplyDiscount to get the discounted price.
//Prints out the number of books, the original price, the discount applied, and the final price.
//*/

//void PrintSummary(int numberOfBooks){
//    decimal totalPrice = CalculatePrice(numberOfBooks);
//	decimal discount = 0.05M;
//	if (numberOfBooks > 10) {
//		discount = 0.12M;
//	} else if (numberOfBooks > 5) {
//		discount = 0.11M;
//	}
//	decimal discountedPrice = ApplyDiscount(totalPrice, discount);

//	Console.WriteLine("-----------------------------------");
//    Console.WriteLine("Number of books: " + numberOfBooks);
//	Console.WriteLine("Price before discount: " + totalPrice + "$");
//	Console.WriteLine("the discount amount is: " + (discount * 100) + "%");
//	Console.WriteLine("Price after discount: " + discountedPrice + "$");

//	Console.WriteLine("-----------------------------------");
//}

//PrintSummary(3);
//PrintSummary(6);
//PrintSummary(14);


//void DisplayPerson(string firstName, string lastName, int age) {
//	Console.WriteLine("Name: " + firstName + " " + lastName + " age: " + age); ;
//}

//DisplayPerson("Simon", "Stirling", 30);

//DisplayPerson(age: 20, firstName: "Bob", lastName: "Smith");

//1. Create a method DisplayProduct with parameters for name, price, and quantity. 
//   Call this method using named parameters.

//*/

//void DisplayProduct(string name, decimal price, int quantity) {
//	Console.WriteLine("name: " + name);
//	Console.WriteLine("price: " + price);
//	Console.WriteLine("quantity: " + quantity);
//}

//DisplayProduct("Product 1", 123.0M, 10);
//DisplayProduct(quantity: 10, price: 111.0M, name: "Product 2");
//DisplayProduct(name: "Product 3", price: 33.0M, quantity: 10);

/*
bool GetPersonInfo(out string firstName, out string lastName, out int age) {
	firstName = "Simon";
	lastName = "Stirling";
	age = 30;

	return true;
}

string fName = "Bob";
string lName = "Smith";
int age = 20;

GetPersonInfo(out fName, out lName, out age);
Console.WriteLine("fname: " + fName);
Console.WriteLine("lname: " + lName);
Console.WriteLine("age: " + age);
*/


using System.Runtime.InteropServices;
///*
///*
///*
///*
///*
string val = "Hello World!";
string upper = val.ToUpper();
Console.WriteLine(upper);
string lower = val.ToLower();
Console.WriteLine(lower);
bool contains = val.Contains("Hello");
Console.WriteLine(contains);
contains = val.Contains("hello");
Console.WriteLine(contains);
string newVal = val.Replace("Hello", "Goodbye");
Console.WriteLine(newVal);
string val2 = " from simon";

newVal = val + val2;
Console.WriteLine(newVal);


string fName = "Simon";
string lName = "Stirling";
int age = 20;


Console.WriteLine("the persons name is: " + fName + " " + lName + " and his age is: " + age);
Console.WriteLine(string.Format("the persons name is: {0} {1} and {0}'s age is: {2}", fName, lName, age));
Console.WriteLine($"the persons name is: {fName} {lName} and {fName}'s age is: {age}");

if (fName.ToUpper() == "SIMON") {
    Console.WriteLine("Im Simon");
} else {
    Console.WriteLine("Im not Simon");
}