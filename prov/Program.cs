using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Book hej = new Book();
            System.Console.WriteLine("hur många kunder vill du skapa");
            string input = Console.ReadLine();
            //tar in värdet om hur många kunder det ska finnas
            int amount = Int32.Parse(input);
            //för stringen till en int
            
            for (int i = 0; i < amount; i++)
            {
                customer person = new customer(); 
                //skapar så många kunder som spelaren sa att den ville ha
                //men alla har samma namn så de kommer bara ersätta varandra 
            }
            while (true){
                System.Console.WriteLine("1: skrive ut bokens värden");
                Console.ReadLine();
            }
            
        }
        public void duThing(string input, Book hej){
            if (input == "1"){
                hej.printInfo();
            }
                
            
        }
    }
}
