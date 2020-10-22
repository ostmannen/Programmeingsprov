using System;
using System.Collections.Generic;

namespace prov
{
    public class customer
    {
        private Random generator = new Random();
        public int money;
        public void createcustomer(){

            money = generator.Next(200);
            
        }
    }
}
