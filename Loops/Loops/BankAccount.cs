namespace Loops {
	internal class BankAccount {
		private string accountHolderName;
		public decimal balance;

		public BankAccount(string accountHolderName, decimal balance) {
			this.balance = balance;
			this.accountHolderName = accountHolderName;
		}

		public string AccountHolderName {
			get {
				return accountHolderName;
			}
			set {
				accountHolderName = value;
			}
		}

		public void Deposit(decimal amount) {
			if (amount > 5000) {
				Console.WriteLine("Need manager to approve");
				return;
			}
			balance += amount;
		}

		public bool Withdraw(decimal amount) {
			if (amount <= balance) {
				balance -= amount;
				return true;
			}
			return false;
		}

		public void DisplayAccountInfo() {
			Console.WriteLine($"Account Holder: {accountHolderName}");
			Console.WriteLine($"Balance: {balance:C}");
		}
	}
}
