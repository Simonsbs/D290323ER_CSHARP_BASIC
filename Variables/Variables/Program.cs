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


//Console.ReadKey();