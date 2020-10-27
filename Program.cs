using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter the amount to convert: ");
      string amountString = Console.ReadLine();
      double amount = Convert.ToDouble(amountString);
      Console.WriteLine($"{amount} cents is equal to...");

      int goldValue = 10;
      int silverValue = 5;

      double goldCoins = Math.Floor(amount/goldValue);
      double remainder = amount%goldValue;

      double silverCoins = Math.Floor(remainder/silverValue);
      remainder = amount%silverValue;

      Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {remainder}");
    }
  }
}
