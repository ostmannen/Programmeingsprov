using System;
using System.Collections.Generic;

namespace prov
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private List<string> catagory = new List<string>();
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();
        public void Books(){
            rarity = generator.Next(10);
            actualValue = generator.Next(1, 100);
            int number = generator.Next(2);
            if (number == 1){
                cursed = true;
            }
            else if (number == 0){
                cursed = false;
            }
        }
        public void printInfo(){
            System.Console.WriteLine(rarity);
            System.Console.WriteLine(actualValue);
            System.Console.WriteLine(cursed);
        }
        public void evaluate(){
            int rightPrice = actualValue * rarity;
            int hej = generator.Next(1, 4);
            rightPrice = rightPrice * hej;
            rightPrice = rightPrice / 2;
        }
        public void addKatrigorier(){
            catagory.Add("Action");
            catagory.Add("Romance");
            catagory.Add("Fantasy");
        }
    }
}
