using Xamarin.Forms;

namespace LottieDemo
{
    public partial class LottieDemoPage : ContentPage
    {
        public LottieDemoPage()
        {
            InitializeComponent();

            //lottieAnim.WidthRequest = 100;
            lottieAnim.HeightRequest = 1;

            lottieAnim.VerticalOptions = LayoutOptions.FillAndExpand;
            lottieAnim.HorizontalOptions = LayoutOptions.FillAndExpand;

            startStopBtn.Clicked += (object sender, System.EventArgs e) => 
            {
                if(lottieAnim.IsPlaying)
                {
                    lottieAnim.Pause();
                }
                else
                {
                    lottieAnim.Play();
                }
            };
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            lottieAnim.Progress = (float)e.NewValue;
        }
    }
}
