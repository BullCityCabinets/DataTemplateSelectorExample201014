using DataTemplateSelectorExample.Models;
using DataTemplateSelectorExample.ViewModels;
using DataTemplateSelectorExample.Views;
using Xamarin.Forms;

namespace DataTemplateSelectorExample
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();

        public static User CurrentUser{get;set;} = new User(111, "Super User", "SuperUser@Znoozle.com", SomeEnum.ILikeDT1);


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
