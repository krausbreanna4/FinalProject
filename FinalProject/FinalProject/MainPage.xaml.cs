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
                    , "I find your lack of faith disturbing."
                    , "It’s a trap!"
                    , "Do. Or do not. There is no try.”"
                    , "Your mother was a hamster and your father smelt of elderberries."
                    , "I fart in your general direction."

        };


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
                output.Text = options[rnd.Next(0, options.Length - 1)];

                Button1.Text = "Red";
                Button2.Text = "Blue";
                Button3.Text = "Green";
                Button4.Text = "Yellow";
                colorOutput.Text = "Pick Again!";
            }
            
        }

        

    }

    }

