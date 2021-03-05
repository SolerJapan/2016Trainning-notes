using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

// Stack class represents a LIFO-->last in first out stack of objects.
// stack is implemented as a circular buffer. but it follows LIFO system.
//In others words, we can push items into a stack and get in reverse order.
// stack returns last item first.
//elements are added to a stack, the capacity is automatically increased as required
//through relocation.
//push = add an item in stack
//pop = return the last item from the stack
namespace stackCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stackCollection_Click(object sender, EventArgs e)
        {
            //define an object called weekday
            Stack weekday = new Stack();
            weekday.Push("Sunday");
            weekday.Push("Monday");
            weekday.Push("Tuesday");
            weekday.Push("Wednesday");
            weekday.Push("Thursday");
            weekday.Push("Friday");
            weekday.Push("Saturday");
            

            if(weekday.Count==7)
            {
  
                MessageBox.Show(weekday.Pop().ToString());
            }
            else
            {

                MessageBox.Show("Saturday does not exist ");
            }
        }
    }
}
