using Xamarin.Forms;

namespace LottieDemo
{
    public partial class LottieDemoPage : ContentPage
    {
        public LottieDemoPage()
        {
            InitializeComponent();

            //lottieAnim.WidthRequest = 100;

            //@podonnell: This is needed to stop an error occuring when running the LottieLogo1.json animation
            //LottieAnimationView not displayed because it is too large to fit into a software layer (or drawing cache)
            lottieAnim.HeightRequest = 1;

            lottieAnim.VerticalOptions = LayoutOptions.FillAndExpand;
            lottieAnim.HorizontalOptions = LayoutOptions.FillAndExpand;

            lottieAnim.Animation = "LottieDemoAnim.json";
            //lottieAnim.Animation = "hamburger.json";
            //lottieAnim.Animation = "LottieLogo1.json";
            lottieAnim.Loop = true;
            lottieAnim.AutoPlay = true;

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
