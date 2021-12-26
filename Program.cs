using ByteBank.Employees;

namespace ByteBank
{
    class program
    {
        static void Main(string[] args)
        {
            BonusManager Manager = new BonusManager();

            Employee Carlos = new Employee("Carlos", "012.321.452-8", 3000);
            Director Hans = new Director("Hans", "098.123.534-32", 15000);
            Manager.BonusRegister(Carlos);
            Manager.BonusRegister(Hans);


            Console.WriteLine("Employee: " + Carlos.Name);
            Console.WriteLine("Current Wage: R$ " + Carlos.Wage);
            Console.WriteLine(" ");

            Console.WriteLine("Director: " + Hans.Name);
            Console.WriteLine("Current Wage: R$ " + Hans.Wage);
            Console.WriteLine(" ");

            Console.WriteLine("Total Bonus Paid this year = R$ " + Manager.GetTotalBonusPaid());
            Console.ReadLine();

        }
    }
}
