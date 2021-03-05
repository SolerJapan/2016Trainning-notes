using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Model
{
    // class Produce
    // {
    class Fruit
    {
        public Fruit()
        {

        }
        public Fruit(string name, double weight, int quantity)
        {

        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int quantity
        {
            get;
            set;

        }
    }

    class Vegetable
    {
        public Vegetable()
        {

        }
        public Vegetable(string name, double weight, int quantity)
        {

        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int quantity
        {
            get;
            set;

        }


    }
}

