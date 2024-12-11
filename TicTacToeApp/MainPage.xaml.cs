namespace TicTacToeApp
{
    public partial class MainPage : ContentPage {

        string simbol = "X";

        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {

            Button button = (Button)sender;
            button.IsEnabled = false;
            
            if (simbol == "X") {
                button.Text = "X";
                simbol = "O";
            } else {
                button.Text = "O";
                simbol = "X";
            }

            if(S1.Text == "X" && S2.Text == "X" && S3.Text == "X") {
                DisplayAlert("Fim de Jogo!", $"{simbol} venceu!", "ok");
                Reset();
            }
        }

        void Reset() {
            S1.Text = "";
            S1.IsEnabled = true;
            S2.Text = "";
            S2.IsEnabled = true;
            S3.Text = "";
            S3.IsEnabled = true;
            S4.Text = "";
            S4.IsEnabled = true;
            S5.Text = "";
            S5.IsEnabled = true;
            S6.Text = "";
            S6.IsEnabled = true;
            S7.Text = "";
            S7.IsEnabled = true;
            S8.Text = "";
            S8.IsEnabled = true;
            S9.Text = "";
            S9.IsEnabled = true;
        }
    }
}
