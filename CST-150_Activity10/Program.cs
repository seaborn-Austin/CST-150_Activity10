//use for IC08
//Lydia's code

//Code corrected by Austin Lippert

using System;using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;
namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }
            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }
    class Set
    {
        private List<int> elements;
        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            //Added brackets to make code easier to read for me
            if (containsElement(val))
            {
                return false;
            }
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                {
                    //return false;
                    //Changed return false to return true
                    return true;
                }
                //else return true
                //Removed the else statement since it would need to return false anyways
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            //Created new set since everything was being changed in the first set
            Set a = new Set();
            for (int i = 0; i < this.elements.Count; i++)
            {
                //this.addElement(rhs.elements[i]);
                //Check to see if the element already exists in the set
                if (!a.containsElement(elements[i])) 
                {
                    a.addElement(this.elements[i]);
                }
                
            }
            //Check the passed object's element list
            for(int i = 0; i < rhs.elements.Count; i++)
            {
                if (!a.containsElement(rhs.elements[i]))
                {
                    a.addElement(rhs.elements[i]);
                }
            }
            return a;
        }
    }
}