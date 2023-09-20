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


Console.WriteLine("select an option:");
Console.WriteLine("1: Add apples");
Console.WriteLine("2: Add cars");
Console.WriteLine("3: thermal nuclear war");
Console.WriteLine("4: Delete all data");
Console.WriteLine("99: Exit");

string input = Console.ReadLine();
int selection = int.Parse(input);

int maxCommands = 10;
int commandCount = 0;

while (selection != 99 && commandCount < maxCommands) {
	if (selection == 1) {
		Console.WriteLine("apples added");
	} else if (selection == 2) {
		Console.WriteLine("cars added");
	} else if (selection == 3) {
		Console.WriteLine("lets play a game");
	} else if (selection == 4) {
		Console.WriteLine("all data deleted!");
	} else if (selection == 99) {
		Console.WriteLine("EXIT");
	} else {
		Console.WriteLine("unknown command");
	}

	commandCount++;

	input = Console.ReadLine();
	selection = int.Parse(input);
}
Console.WriteLine("bye");