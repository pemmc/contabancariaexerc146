using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Exceptions;

public class ProcessFile
{
    public static void Main()
    {
        CultureInfo idiomaptBR = new CultureInfo("pt-BR");

        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Holder: ");
        String holder = Console.ReadLine();

        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine(), idiomaptBR);

        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine(), idiomaptBR);

        Account acc = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");

        double amount = double.Parse(Console.ReadLine(), idiomaptBR);

        try
        {

            acc.Withdraw(amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("C", idiomaptBR));

        }
        catch (DomainException e)
        {

            Console.WriteLine("Withdraw error: " + e.Message);

        }
    }
}
