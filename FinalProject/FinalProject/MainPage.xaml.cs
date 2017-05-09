using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace FinalProject
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("FinalProject.fortune.txt");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
                options.Add(text);
            }


            //Content.SizeChanged += OnContentViewSizeChanged; //absolute value
        }

        //random fortunes
        List<string> options = new List<string>();

       

        //button click method

        private void Button_OnClick(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if (button.Text == "Red" || button.Text == "Blue" || button.Text == "Green" || button.Text == "Yellow")
            {
                colorOutput.Text = "Pick a Number.";
                Button1.Text = "1";
                Button2.Text = "2";
                Button3.Text = "3";
                Button4.Text = "4";

                output.Text = "";
            }

            
            else if (button.Text == "1" || button.Text == "2" || button.Text == "3" || button.Text == "4")
            {
                
                var rnd = new System.Random();
                output.Text = options[rnd.Next(0, options.Count - 1)];

                Button1.Text = "Red";
                Button2.Text = "Blue";
                Button3.Text = "Green";
                Button4.Text = "Yellow";
                colorOutput.Text = "Pick Again!";
            }
            
        }

        

    }

    }

