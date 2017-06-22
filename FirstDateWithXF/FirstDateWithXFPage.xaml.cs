using Xamarin.Forms;

namespace FirstDateWithXF
{
    public partial class FirstDateWithXFPage : ContentPage
    {
        public FirstDateWithXFPage()
        {
            InitializeComponent();
            this.BindingContext = new FirstDateWithXFPageViewModel();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Handle_Clicked)}");

            var viewModel = this.BindingContext as FirstDateWithXFPageViewModel;
            if (viewModel != null)
            {
                viewModel.OnRotateButtonClicked();
            }
        }
    }
}
