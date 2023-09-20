// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


// this is a variable for name
string name = "Bob";
string lastName = "Smith"; // this is a variable for last name


string thePlaceILoveToGo = "Home";
// the variable above is a place i like to go

string livesacathas = "Cat";
string IMAVARIABLE = "Cat";

string my9Lives = "Cat";
string myNineLives = "Cat";

string Name = "Jim";

string Class = "Cat";

// Comments:
// RTFM - Read The F**** Message

/*sdfsdf
  sdffsdfs
  
  dfsdfsdf
  sdfsdfsdf
  sdfsdf
 */


int age = 0;

age = 25;

//age = "30";

Console.WriteLine("My age is: " + age);

byte myAge = 30;
byte numberOfWorkers = 50;

sbyte x = -10;

long myAccount = 100000000000;


double payPerHour = 16.5;

bool isHappy = true;
bool isSad = false;

//NO!
//bool isCat = 0;

char l = 'c';
char heb = 'א';
char zero = '0';
string word = "abcd";

const double pi = 3.14;
//pi = 3.1415;

myAge = 31;
Console.WriteLine("pi = " + pi);

int a = 5, b = 10;


string myName = "Bob";

string someValue = "";
string someOtherValue = string.Empty;

Console.WriteLine("Please enter your name:" + someValue);



int a2 = 55;
int b2 = 10;

//Console.WriteLine(a2 + b2);

int c2 = a2 + b2;
Console.WriteLine(a2 + "+" + b2 + "=" + c2);
c2 = a2 - b2;
Console.WriteLine(a2 + "-" + b2 + "=" + c2);
c2 = a2 * b2;
Console.WriteLine(a2 + "*" + b2 + "=" + c2);
c2 = a2 / b2;
Console.WriteLine(a2 + "/" + b2 + "=" + c2);

double d1 = 55;
double d2 = 10;
double d3 = d1 / d2;
Console.WriteLine(d1 + "/" + d2 + "=" + d3);

int i = 10;
Console.WriteLine(i);
i++;
i++;
i++;
i++;
i++;
Console.WriteLine(i);
i--;
Console.WriteLine(i);

int z = 10;
z += 5;
Console.WriteLine(z);
z -= 3;
Console.WriteLine(z);


int val1 = int.MaxValue;
val1 += 1000000;
Console.WriteLine(val1);

byte b1 = 10;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);
b1 += 200;
Console.WriteLine(b1);


double hourlyRate = 30.7;
int hoursPerDay = 8;
int daysPerMonth = 25;

double monthlySalary = hourlyRate * hoursPerDay * daysPerMonth;
Console.WriteLine(monthlySalary);

string s1 = "Hello";
string s2 = "World";
string s3 = s1 + " " + s2;

Console.WriteLine("This \n is \n multiline");

bool isWhiteSpace = char.IsWhiteSpace('\n');
bool isDigit = char.IsDigit('6');
Console.WriteLine("isDigit:" + isDigit);
bool isLetter = char.IsLetter('Z');
Console.WriteLine("isLetter:" + isLetter);


DateTime born = new(1989, 10, 1, 14, 20, 13);
DateTime died = born.AddDays(100);
died = died.AddMinutes(100);
Console.WriteLine(born);
Console.WriteLine(died.ToString("yyyy-dd-MM HH:mm"));

Console.WriteLine(born.ToShortTimeString());

DateTime now = DateTime.Now;


// will not work
//string name2 = "Simon";
//int name3 = "Bob";


byte age2 = 100;
int age3 = age2;

Console.WriteLine("age2: " + age2);
Console.WriteLine("age3: " + age3);

long bigNumber = 88;
int mediumNumber = (int)bigNumber;

Console.WriteLine("big: " + bigNumber);
Console.WriteLine("med: " + mediumNumber);


double dblNumber = 123.9999999;
int dblNumberCasted = (int)dblNumber;
double fromInt = dblNumberCasted;

Console.WriteLine("dbl: " + dblNumber);
Console.WriteLine("dblCasted: " + dblNumberCasted);
Console.WriteLine("fromInt: " + fromInt);


var someAge = 123;
var someName = "Simon";
var someWage = 123.456;
var someDate = DateTime.Now;
var someIsCool = false;

var somethingUnknown = (byte)123;



int age4 = 18;
int minAgeToGetIn = 21;

bool isAllowedIn = age4 == minAgeToGetIn;
bool isNotAllowedIn = age4 != minAgeToGetIn;
bool isBelowMinAge = age4 < minAgeToGetIn;
bool isAboveMinAge = age4 > minAgeToGetIn;
bool isAboveMinAge2 = minAgeToGetIn < age4;

bool isBelowOrEqualFromMinAge = age4 <= minAgeToGetIn;
bool isAboveOrEqualFromMinAge = age4 >= minAgeToGetIn;

Console.WriteLine("isAllowedIn: " + isAllowedIn);
Console.WriteLine("isNotAllowedIn: " + isNotAllowedIn);
Console.WriteLine("isBelowMinAge: " + isBelowMinAge);
Console.WriteLine("isAboveMinAge: " + isAboveMinAge);

// && - And
// || - Or

bool b3 = true && true; // true
b3 = true && false;     // false
b3 = false && true;     // false
b3 = false && false;    // false

bool b4 = true || true; // true
b4 = true || false;     // true
b4 = false || true;     // true
b4 = false || false;    // false


int age5 = 18;
int minAge = 21;
int maxAge = 60;

//                     false      &&      true
bool ageInRange = (age5 > minAge) && (age5 < maxAge);

//                         true      &&      false
bool ageOutOfRange = (age5 < minAge) && (age5 > maxAge);

//                    true      ||      false
ageOutOfRange = (age5 < minAge) || (age5 > maxAge);


bool b8 = (isAllowedIn && b3) || (isNotAllowedIn && b4);

bool isAgeLessThanMin = age5 < minAge;
bool isAgeGreaterThanMax = age5 > maxAge;
ageOutOfRange = isAgeLessThanMin || isAgeGreaterThanMax;


bool t = !true; // false
bool f = !false; // true

bool ageOutOfRange2 = !ageInRange;

// !(true) -> false
bool b9 = !(isAllowedIn && b3) || (isNotAllowedIn && b4);
// !true
bool b10 = (isAllowedIn && b3) || (!isNotAllowedIn && b4);


//Console.WriteLine("Please enter your age:");

//string input = Console.ReadLine();

////int age6 = int.Parse(input);
//int age6 = 0;

//bool parsedString = int.TryParse(input, out age6);

//if (parsedString) {
//	//int age6 = 60;
//	int minAge2 = 18;
//	int maxAge2 = 50;

//	if (age6 > minAge2 && age6 < maxAge2) {
//		Console.WriteLine("This is true");
//		Console.WriteLine("Wow, your in the range");
//	} else {
//		Console.WriteLine("This is false");
//		Console.WriteLine("Shame, your NOT in the range");
//	}
//} else {
//	Console.WriteLine("Sorry, that is not a valid age");

//}

//Console.WriteLine("Im after the if");

int age8 = 40;
string name8 = "Jane";

if (age8 > 60) {
	Console.WriteLine("True Section");
} else if (name8 == "Bob") {
	Console.WriteLine("Is bob");
} else if (name8 == "Joe") {
	Console.WriteLine("is joe");
} else if (name8 == "Jane") {
	Console.WriteLine("is Jane");
	if (age8 < 10) {
		Console.WriteLine("jane is younger than 10");
	} else if (age8 < 50) {
		Console.WriteLine("jane is too young");
	} else {
		Console.WriteLine("jane's age is ok");
	}
} else if (name8 == "Simon") {
	Console.WriteLine("is Simon");
} else if (name8 == "Sam") {
	Console.WriteLine("is Sam");
} else {
	Console.WriteLine("unknown name");
}

Console.WriteLine("Not the right age");


string name9 = "Joe";

switch (name9) {
	case "Joe":
		Console.WriteLine("im joe");

		if (name9 == "Joe") {
			Console.WriteLine("JOE IS THE KING!!!!");
		}
		break;
	case "Jane":
	case "Simon":
		Console.WriteLine("Im simon or jane");
		if (name9 == "Simon") {
			Console.WriteLine("Only im the best");
		} else {
            Console.WriteLine("im just ok");
        }
		if (name9 == "Joe") {
			Console.WriteLine("JOE IS THE KING!!!!");
		}
		break;
	default:
		Console.WriteLine("Someone else");
		break;
}



Console.WriteLine("im the end");



Console.ReadKey();