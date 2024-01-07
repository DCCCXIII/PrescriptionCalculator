using PrescriptionCalculator.Core.Interfaces;

namespace PrescriptionCalculator
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
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";


            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnWorkingClicked(object sender, EventArgs e)
        {
            var medCore = this.Handler.MauiContext.Services.GetService<IMedicineCore>();
            WorkingBtn.Text = medCore.Working();
        }
    }

}
