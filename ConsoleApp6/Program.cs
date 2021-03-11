using System;

namespace ConsoleApp6
{
    class Program
    {
        public class ClientApplication
        {
            static void Main()
            {
                CardFactory factory = null;
                Console.Write("Introduceti tipul de card: ");
                string car = Console.ReadLine();

                switch (car.ToLower())
                {
                    case "moneyback":
                        factory = new MoneyBackFactory(50000, 0);
                        break;
                    case "titanium":
                        factory = new TitaniumFactory(100000, 500);
                        break;
                    case "platinum":
                        factory = new PlatinumFactory(500000, 1000);
                        break;
                    default:
                        break;
                }

                CreditCard creditCard = factory.GetCreditCard();
                Console.WriteLine("\nDetaliile cardului dumneavoastra : \n");
                Console.WriteLine("Tipul Cardului: {0}\nLimita de Credit: {1}\nAlimentare anuala: {2}",
                    creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
                Console.ReadKey();
            }
        }
    }
}
