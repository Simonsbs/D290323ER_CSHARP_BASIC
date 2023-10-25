namespace Loops {
	internal class BankAccount {
		private string accountHolderName;
		public decimal balance;

		public static string bankName;
		public static int bankID;

		public BankAccount() {
			this.balance = 0;
			this.accountHolderName = "UNKNOWN";
		}
		
		public BankAccount(string accountHolderName) {
			this.accountHolderName = accountHolderName;
			this.balance = 0;
		}

		public BankAccount(decimal balance) {
			this.accountHolderName = "UNKNOWN";
			this.balance = balance;
		}

		public BankAccount(string accountHolderName, decimal balance) {
			this.balance = balance;
			this.accountHolderName = accountHolderName;
		}

		static BankAccount() {
			bankName = "INIT BANK NAME";
			bankID = 0;

		}

		public string AccountHolderName {
			get {
				if (balance > 1000) {
					return accountHolderName + " IS RICH!!!";
				}
				return accountHolderName + " IS POOR!!!";
			}
			set {
				if (value.Length > 5) {
					accountHolderName = value;
				}
			}
		}

		public static string GetName() {
			return bankName;
		}

		public static void SetName(string value) {
			bankName = value;
		}

		public static string BankName {
			get {
				return bankName;
			}
			set {
				bankName = value;
			}
		}

		public string GetAccountHolderName() {
			if (balance > 1000) {
				return accountHolderName + " IS RICH!!!";
			}
			return accountHolderName + " IS POOR!!!";
		}

		public void SetAccountHolderName(string value) {
			if (value.Length > 5) {
				accountHolderName = value;
			}
		}


		public int Add(int a, int b) {
			return a + b;
		}
		public int Add(int a, int b, int c) {
			return Add(a, b) + c;
		}
		public int Add(int a, int b, int c, int d) {
			return Add(a, b, c) + d;
		}


		public void Deposit(decimal amount) {
			if (amount > 5000) {
				Console.WriteLine("Need manager to approve");
				return;
			}
			balance = MyFunctions.Add(balance, amount);
		}

		public bool Withdraw(decimal amount) {
			if (amount <= balance) {
				balance -= amount;
				return true;
			}
			return false;
		}

		public void DisplayAccountInfo() {
			Console.WriteLine("--------------------------");
			Console.WriteLine($"{bankID} | {BankName}");
			Console.WriteLine("--------------------------");
			Console.WriteLine($"Account Holder: {accountHolderName}");
			Console.WriteLine($"Balance: {balance:C}");

		}
	}
}
