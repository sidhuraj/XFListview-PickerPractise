using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewComPickerPractise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<DancersName> objDancers = new List<DancersName>();

            objDancers.Add(new DancersName { DancersPhoto = "Michael.jpg", Dancerscountry = "USA", Dancersuniverse = "world" });
            objDancers.Add(new DancersName { DancersPhoto = "shakria.jpg", Dancerscountry = "spanish", Dancersuniverse = "world" });
            objDancers.Add(new DancersName { DancersPhoto = "prabhu.jpg", Dancerscountry = "indian", Dancersuniverse = "world" });
            objDancers.Add(new DancersName { DancersPhoto = "hrithik.jpg", Dancerscountry = "indian", Dancersuniverse = "world" });

            lblDanersList.ItemsSource = objDancers;

        }
    }
}
