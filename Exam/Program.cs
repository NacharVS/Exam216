using System;

namespace Exam
{
    class BancAccount
    {
        class BankAccount
        {
            public string name;
            public string surname;
            public int accountNumber;
        }
        class Program
        {
            public static object Enviroment { get; private set; }

            static void Main(string[] args)
            {
                BankAccount user = new BankAccount();
                user.name = Console.ReadLine();
                user.surname = Console.ReadLine();
                user.accountNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 1, если хотите пополнитиь счет" + Enviroment.NewLine +
                "Введите 2,если хотите снять деньги" + Environment.NewLine +
                "Введите 3,если хотите перевести деньги на другой счет");
                
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                }
    }
}
