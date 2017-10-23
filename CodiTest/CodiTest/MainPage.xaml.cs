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
                    BindableProperty.Create("ImageNamet", typeof(string), typeof(MainPage), "meR4.png");
       

        public string ImageName
        {
            set { SetValue(ImageNameTextProperty, value); }
            get { return (string)GetValue(ImageNameTextProperty); }
        }
       
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLabelTapped(object sender, EventArgs e)
        {

        }
    }
}
