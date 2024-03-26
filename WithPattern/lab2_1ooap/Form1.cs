using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1ooap
{
    public partial class Form1 : Form
    {
        bool teaTrue = false;
        string addDrink;
        int time = 0, step = 1;

        public Form1()
        {
            InitializeComponent();

            //timer1.Interval = 500; // 500 миллисекунд
            //timer1.Enabled = true;
            //timer1.Tick += timer1_Tick;
        }



        private void coffee_Click(object sender, EventArgs e)
        {   
            Clear();
            
            timer1.Start();

            addDrink = "";
            Coffee coffee = new Coffee();


            var text = coffee.makeDrink();

            addDrink = coffee.name;

            boil.Text = text.Item1;
      
            brew.Text = text.Item2;

            cup.Text = text.Item3;

            add.Text = text.Item4;


            drink.Text = addDrink;

        }

        private void tea_Click(object sender, EventArgs e)
        {
            Clear();

            timer1.Start();

            addDrink = "";

            Tea tea = new Tea();
            var text = tea.makeDrink();

            addDrink = tea.name;

            boil.Text = text.Item1;            

            brew.Text = text.Item2;

            cup.Text = text.Item3;

            add.Text = text.Item4;

            drink.Text = addDrink;
            

        }


        public void Clear()
        {
            boil.Text = string.Empty;
            brew.Text = string.Empty;
            cup.Text = string.Empty;
            add.Text = string.Empty;
            boil.Visible = true;

            brew.Visible = false;

            cup.Visible = false;

            add.Visible = false;

            GO.Visible = false;

            drink.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += step;

            if (time == 7)
                boil.Visible = true;

            if (time == 13)
                brew.Visible = true;

            if (time == 18)
                cup.Visible = true;

            if (time == 22)
                add.Visible = true;

            if (time == 25)
                GO.Visible = true;

            if (time == 27)
            {
                drink.Visible = true;
                timer1.Stop();
                time = 0;
            }
        }
    }

    public abstract class Drinks
    {
        public (string, string, string, string) makeDrink()
        {
            return (boilWater(), brew(), pourInCup(), addComps());
        }
        public string boilWater()
        {
            return "Вода кипятится";
        }

        public abstract string brew();

        public string pourInCup()
        {
            return "Напиток наливается в чашку";
        }

        public abstract string addComps();


    }

    public class Tea : Drinks
    {
        public string name = "Чай";

        public override string brew()
        {
            return "Чай заваривается";
        }

        public override string addComps()
        {
            return "Добавляются молоко и сахар";
        }
    }


    public class Coffee : Drinks
    {

        public string name = "Кофе";

        public override string brew()
        {
            //string str = addComps();
            return "Кофе заваривается";
        }



        public override string addComps()
        {
            return "Добавляются сливки и сахар";
        }

    }


}
