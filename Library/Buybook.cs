using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Buybook
    {

        //Properties 
        string Title;
        double Number_copies;
        double Unitary_cost;

        //Constructor
        public Buybook(string title, double number_copies, double unitary_cost)
        {
            this.Title = title;
            this.Number_copies = number_copies;
            this.Unitary_cost = unitary_cost;
        }

        public  double GetTotalCost ()
            {
            double tc=Unitary_cost*Number_copies;
            return tc;  
            }
    }
}
