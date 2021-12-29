using ByteBank.Employees;

namespace ByteBank
{
    class program
    {
        static void Main(string[] args)
        {


            CalculateBonus();

            Console.ReadLine();

        }

        public static void CalculateBonus()
        {
            BonusManager Manager = new BonusManager();

            Designer Pedro = new Designer("Pedro", "012.321.452-8");

            Director Roberta = new Director("Roberta", "098.123.534-32");

            AccountManager Camila = new AccountManager("Camila", "543.674.352-43");

            Assistant Igor = new Assistant("Igor", "093.985.345-98");

            Manager.BonusRegister(Pedro);
            Manager.BonusRegister(Roberta);
            Manager.BonusRegister(Camila);
            Manager.BonusRegister(Igor);

            Console.WriteLine("Total Bonus Paid this Year = U$$ " + Manager.GetTotalBonusPaid());

        }
    }
}
