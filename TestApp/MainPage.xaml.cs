namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Button button = new()
            {
                Text = "Click me",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new HelloXamlPage());
            };

            Content = button;
        }

        
    }

}
