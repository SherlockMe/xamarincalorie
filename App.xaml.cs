using System;
using Ornek_2.DatabaseHelper;
using Ornek_2.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ornek_2
{
    public partial class App : Application
    {
        private static DatabaseAccess database;

        public static DatabaseAccess Database
        {
            get { return database; }
        }

        public App()
        {
            InitializeComponent();

            string db_filePath = DependencyService.Get<IFileHelper>().GetFilePath("ornekSQLiteDB.db3");
            database = new DatabaseAccess(db_filePath);

            MainPage = new NavigationPage(new BesinListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
