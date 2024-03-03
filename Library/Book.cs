using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book: Buybook
    {
        string Author;
        public Book(string title, string author, double number_copies, double cost):base(title, number_copies, cost)
        {
            this.Author = author;
        }

        public double Buyy()
        {
            double cost;
            cost = base.GetTotalCost();
            return cost;
        }

        public string PrintResult()
        {
            return "" + Buyy();
        }
    }
}
