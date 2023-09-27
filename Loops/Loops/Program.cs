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