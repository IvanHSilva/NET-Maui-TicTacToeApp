﻿namespace TicTacToeApp
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {

            Button button = (Button)sender;
            button.Text = "X";
        }
    }
}
