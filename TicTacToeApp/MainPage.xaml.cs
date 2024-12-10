namespace TicTacToeApp
{
    public partial class MainPage : ContentPage {

        string simbol = "X";

        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {

            Button button = (Button)sender;
            
            if (simbol == "X") {
                button.Text = "X";
                simbol = "O";
            } else {
                button.Text = "O";
                simbol = "X";
            }
        }
    }
}
