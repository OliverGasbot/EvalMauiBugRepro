using Controls.UserDialogs.Maui;
using Z.Expressions;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                string formula_percent = "double result; result = Math.PI + d; return result;";

                var percentage_result = Eval.Execute<double>(formula_percent, new { d = 1 });

                UserDialogs.Instance.Alert($"Success: {formula_percent} = {percentage_result}");

            }
            catch (Exception ex)
            {
                UserDialogs.Instance.Alert($"Fail: {ex.Message}");

            }
        }
    }

}
