using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandwichMaker
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Text = SandwichMaker();
        }

        public string SandwichMaker()
        {
            string[] Meats = { "Roast Beef", "Turkey", "Sliced Chicken", "Pastrami", "Salami" };
            string[] Greens = { "Lettuce", "Arugula", "Spinach" };
            string[] Condiments = { "Mustard", "Mayo", "Ketchup" };
            string[] Bread = { "Sourdough Bread", "French Bread", "Rye Bread", "Wheat Bread", "Pumpernickel", "Sliced Roll" };

            Random random = new Random();
            string randomMeat = Meats[(random.Next(Meats.Length))];
            string randomGreens = Greens[(random.Next(Greens.Length))];
            string randomCondiments = Condiments[(random.Next(Condiments.Length))];
            string randomBread = Bread[(random.Next(Bread.Length))];

            return randomMeat + " on a bed of " + randomGreens + " with " + randomCondiments + " on " + randomBread;
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
