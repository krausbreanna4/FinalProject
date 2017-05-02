using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProject
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            //Content.SizeChanged += OnContentViewSizeChanged; //absolute value
        }

        //random fortunes
        string[] options = {
              "A new challenge is near."
                    , "A feather in the hand is better than a bird in the air."
                    , "A friend is a present you give yourself."
                    , "A new pair of shoes will do you a world of good!"
                    , "The road to riches is paved with homework."
                    , "Pick another fortune"
                    , "Ignore all previous fortunes"
                    , "You will be hungry in one hour."

                    , "Ask your mom."
                    , "Fortune Not Found: Abort, Retry, Ignore?"
                    , "A good time to start something new"
        };


        //button click methods

        private void Button_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Red" || button.Text == "Blue" || button.Text == "Green" || button.Text == "Yellow")
            {
                Button1.Text = "1";
                Button2.Text = "2";
                Button3.Text = "3";
                Button4.Text = "4";
            }
            else if (button.Text == "1" || button.Text == "2" || button.Text == "3" || button.Text == "4")
            {
                var rnd = new System.Random();
                output.Text = options[rnd.Next(0, options.Length - 1)];
            }
            
        }

        

    }

    }

