﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Uri youtube = new Uri("https://youtu.be/HYa39iXSt5E");
            Device.OpenUri(youtube);
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            Uri youtube = new Uri("https://youtu.be/ul389fICHtg");
            Device.OpenUri(youtube);
        }
    }
}
