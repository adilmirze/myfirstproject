using System;

namespace MyProject
{
	class BankCardDetails
	{
		public string CardNumber { get; set; }
		public string CardCVV { get; private set; }
		public string BankName { get; set; }
		public string Ownername { get; set; }
		public string OwnerSurname { get; set; }
		public string PhoneNumber { get; set; }
		private decimal Balance { get; set; }
		public void IncreaseBalance(decimal sum)
		{
			if (sum <= 0) return;
			Balance += sum;
		}
		public void DecreaseBalance(decimal sum)
		{
			if (sum <= 0) return;
			Balance -= sum;
		}
		public class Program
		{
			public static void Main(string[] args)
			{
				BankCardDetails mybankCardDetails = new BankCardDetails();
				mybankCardDetails.CardNumber = "1234234534564567";
				mybankCardDetails.CardCVV = "987";
				mybankCardDetails.BankName = "Bank of America";
				mybankCardDetails.Ownername = "Kevin";
				mybankCardDetails.OwnerSurname = "Dean";
				mybankCardDetails.PhoneNumber = "+18783332211";
				mybankCardDetails.Balance = 560;

				mybankCardDetails.IncreaseBalance(100);
                Console.WriteLine(mybankCardDetails.Balance);

                mybankCardDetails.DecreaseBalance(140);
                Console.WriteLine(mybankCardDetails.Balance);
            }
		}
	}
}