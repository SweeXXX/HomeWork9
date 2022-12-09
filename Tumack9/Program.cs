using System;

namespace Tumac
{
    class Program
    {
        static void Main(string[] args)
        {
            Song Raze = new Song("ShowDown", "ShadowRaze");
            Song Olimpos = new Song("Айсберг", "Папин Олимпос", Raze);
            Song Dora = new Song("Барбисайз", "Дора", Olimpos);
            Song Suicide = new Song("Antarctica", "$uicideboy$", Dora);

            BankAccount Nekit = new BankAccount(0, 228558, AccountType.Savings);
            BankAccount Kit = new BankAccount(Nekit.NewID(), 1000, AccountType.Current);

            Kit.Transition(Nekit, 228);
            Kit.Dispose();
            Nekit.Print();
            Kit.Print();
        }
    }
}