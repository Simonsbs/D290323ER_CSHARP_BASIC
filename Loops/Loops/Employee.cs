namespace Loops {
	public class Employee {
		public string firstName;
		public string lastName;
		public int age;
		public string eyeColor;
		public string fullName;

		public Employee(string fName, string lName, int age) {
			firstName = fName;
			lastName = lName;
			
			this.age = age;


			fullName = fName + " " + lName;

            Console.WriteLine("Created a new Employee");
        }


		public void PrintName() {
            Console.WriteLine($"{this.firstName} {this.lastName} age: {this.age}");
        }
	}
}
