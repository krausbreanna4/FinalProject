﻿using System;
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

       
        //button click method
        public void ButtonClicked (object sender, EventArgs args)
        {
            var rnd = new System.Random();
            output.Text = options[rnd.Next(0, options.Length - 1)];
        }

        //   void OnContentViewSizeChanged(object sender, EventArgs args)
        //{
        //    ContentView Content = (ContentView)sender;
        //}

      }

    }

