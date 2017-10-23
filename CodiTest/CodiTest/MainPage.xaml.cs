using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CodiTest
{
    public partial class MainPage : ContentPage
    {
       
        public static readonly BindableProperty ImageNameTextProperty =
                    BindableProperty.Create("ImageNamet", typeof(string), typeof(MainPage), "");

        public static readonly BindableProperty PersonNameTextProperty =
                    BindableProperty.Create("PersonName", typeof(string), typeof(MainPage), "");


        public string ImageName
        {
            set { SetValue(ImageNameTextProperty, value); }
            get { return (string)GetValue(ImageNameTextProperty); }
        }

        public string PersonName
        {
            set { SetValue(PersonNameTextProperty, value); }
            get { return (string)GetValue(PersonNameTextProperty); }
        }

        public MainPage()
        {
            InitializeComponent();

            ImageName = "meR4.png";
            PersonName = "Alex Chukanov";
        }        
    }
}
