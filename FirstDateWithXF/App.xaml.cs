using Xamarin.Forms;

namespace FirstDateWithXF
{
    public partial class App : Application
    {
        public App()
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(App)}:  Constructor");
            InitializeComponent();

            MainPage = new FirstDateWithXFPage();
        }

        protected override void OnStart()
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
            // Handle when your app resumes
        }
    }
}
