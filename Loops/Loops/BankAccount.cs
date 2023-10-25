namespace Loops {
	internal class BankAccount {
		public string accountHolderName;
		public decimal balance;

		public BankAccount(string accountHolderName, decimal balance) {
			this.balance = balance;
			this.accountHolderName = accountHolderName;
		}

		public void Deposit(decimal amount) {
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
