using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }

    public class pro
    {
        Rectangle rec = new Rectangle();
        Circle circle = new
        Circle();
        double a = 10;
        double b = 20;
        double c = 1.0;
        double area = 0.0;
        double perimeter = 0.0;
        rec.height=a;
        rec.width = b;
        area = rec.Area();

        Console.WriteLine($"Area of rectangle is : {area}");
        perimeter = rec.perimeter();
        public static void pro(Form1 obj)
        {
            obj.Text = 
        }
    }
}
