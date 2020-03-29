using System;

namespace DesignPatterns.ZoranHorvat.State
{
    class Program
    {
        static void Main()
        {
            var account = new Account(() => Console.WriteLine("Account unfrozen."));

            // NotVerified  - An account's initial state. Account holder can deposit but not withdraw and it becomes Active when HolderVerified
            account.Deposit(100);
            account.Withdraw(100);
            account.HolderVerified();

            // Active       - The active state allows all account actions to be performed except holder verification, the account is already verified
            account.Withdraw(50);
            account.Deposit(100);
            account.Freeze();

            // Frozen       - Depositing into or withdrawing from a frozen account will cause it to transition to its Active state and invoke the OnUnfreeze callback
            account.Withdraw(50);

            // Closed       - no more activity allowed on this account
            account.Close();

            Console.WriteLine(account.Balance);
        }
    }
}
