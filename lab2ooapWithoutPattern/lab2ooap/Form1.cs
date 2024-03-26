using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2ooap
{
    public partial class Form1 : Form
    {
        bool teaTrue = false;
        string addDrink;

        public Form1()
        {
            InitializeComponent();          
        }



        private void coffee_Click(object sender, EventArgs e)
        {
            Clear();
            addDrink = "";
            Coffee coffee = new Coffee();
            

            var text = coffee.makeCoffee();;

            addDrink = coffee.name;

            boil.Text = text.Item1;
            boil.Visible = true;
            //Thread.Sleep(4000);

            grid.Text = text.Item2;
            grid.Visible = true;
            //Thread.Sleep(4000);

            brew.Text = text.Item3;
            brew.Visible = true;
            //Thread.Sleep(3000);

            cup.Text = text.Item4;
            cup.Visible = true;
            //Thread.Sleep(1000);

            coffee.addCream();
            addDrink += " со сливками"; 
            
            add.Visible = true;
            add.Text = coffee.addSugar();
            addDrink += " и сахаром";
            //Thread.Sleep(1000);

            drink.Text = addDrink;

            Show();


        }
        private void tea_Click(object sender, EventArgs e)
        {
            Clear();
            addDrink = "";

            Tea tea = new Tea();
            var text = tea.makeTea();

            addDrink = tea.name;

            boil.Text = text.Item1;
            boil.Visible = true;    
            //Thread.Sleep(4000);

            brew.Text = text.Item2;
            brew.Visible = true;    
            //Thread.Sleep(3000);

            cup.Text = text.Item3;
            cup.Visible = true;
            //Thread.Sleep(1000);


            tea.addMilk();
            add.Visible = true;
            addDrink += " с молоком";
            add.Text = tea.addSugar();
            addDrink += " и сахаром";
            //Thread.Sleep(1000);


            drink.Text = addDrink;
            Show();

        }


        public void Show()
        {
            GO.Visible = true;

            drink.Visible = true;

        }

        public void Clear()
        {
            boil.Text = string.Empty; ;
            grid.Text = string.Empty;
            brew.Text= string.Empty;
            cup.Text= string.Empty;
            add.Text = string.Empty;

        }

    }


    //public class Drinks
    //{

    //}

    public class Tea
    {
        public string name = "Чай";
        public (string, string, string) makeTea()
        {
            return (boilWater(), brewingTea(), pourInCup());
        }

        public string boilWater()
        {
            return "Вода кипятится";
        }

        public string brewingTea() 
        {
            return "Чай заваривается";
        }

        public string pourInCup()
        {
            return "Чай наливается в чашку";
        }

        public string addSugar()
        {
            return "Добавляются дополнения";
        }

        public string addMilk()
        {
            return "Добавляются дополнения";
        }


    }
    public class Coffee
    {

        public string name = "Кофе";

        public (string, string, string, string) makeCoffee()
        {
            return (boilWater(), grindingСoffee(), brewingCoffee(), pourInCup());
        }
        public string boilWater()
        {
            return "Вода кипятится";
        }

        public string grindingСoffee()
        {
            return "Зёрна мелятся";
        }

        public string brewingCoffee()
        {
            return "Кофе заваривается";
        }

        public string pourInCup()
        {
            return "Кофе наливается в чашку";
        }

        public string addSugar()
        {
            return "Добавляются дополнения";
        }

        public string addCream()
        {
            return "Добавляются дополнения";
        }

    }






}
