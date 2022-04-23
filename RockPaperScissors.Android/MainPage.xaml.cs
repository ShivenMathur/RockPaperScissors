using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RockPaperScissors
{
    public partial class MainPage : ContentPage
    {
       
    private string myStringProperty;
        public string final
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(final)); // Notify that there was a change on this property
            }
        }

        private string computerProperty;
        public string finalComputer
        {
            get { return computerProperty; }
            set
            {
                computerProperty = value;
                OnPropertyChanged(nameof(finalComputer)); // Notify that there was a change on this property
            }
        }

        private string playerProperty;
        public string finalPlayer
        {
            get { return playerProperty; }
            set
            {
                playerProperty = value;
                OnPropertyChanged(nameof(finalPlayer)); // Notify that there was a change on this property
            }
        }

        private int computerScoreS;
        public int finalCompScore
        {
            get { return computerScoreS; }
            set
            {
                computerScoreS = value;
                OnPropertyChanged(nameof(finalCompScore)); // Notify that there was a change on this property
            }
        }

        private int playerScoreS;
        public int finalPlayScore
        {
            get { return playerScoreS; }
            set
            {
                playerScoreS = value;
                OnPropertyChanged(nameof(finalPlayScore)); // Notify that there was a change on this property
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Console.WriteLine(computerChoice);

            BindingContext = this;
            final = "RPS"; // It will be shown at your label

            BindingContext = this;
            finalComputer = "👊";

            BindingContext = this;
            finalPlayer = "👊";

            BindingContext = this;
            finalCompScore = 0;

            BindingContext = this;
            finalPlayScore = 0;


        }

        string computerChoice = "";

        string playerChoice = "";

        string done = "";

        

        

        void rock_Clicked(System.Object sender, System.EventArgs e)
        {
            playerChoice = "rock";
            finalPlayer = "👊";


            Random rnd = new Random();

            for (int j = 0; j < 4; j++) ;

            int computerNumber = (rnd.Next(1, 4));


            string computerChoice = "";

            if (computerNumber == 1)
            {
                computerChoice = "rock";
                finalComputer = "👊";
            }

            else if (computerNumber == 2)
            {
                computerChoice = "paper";
                finalComputer = "✋";
            }

            else
            {
                computerChoice = "scissors";
                finalComputer = "✌️";
            }

            ;

            if (computerChoice == "scissors")
            {
                done = "playerWon";
                ++finalPlayScore;

            }

            else if (computerChoice == "rock")
            {
                done = "tie";
               
            }

            else
            {
                done = "computerWon";
                ++finalCompScore;
            }

            if (done == "playerWon")
            {
                final = "Player Won!";
            }

            else if (done == "computerWon")
            {
                final = "Computer Won!";
            }

            else
            {
                final = "Tie!";
            }

            
        }

        void paper_Clicked(System.Object sender, System.EventArgs e)
        {
            playerChoice = "paper";
            finalPlayer = "✋";

            Random rnd = new Random();

            for (int j = 0; j < 4; j++) ;

            int computerNumber = (rnd.Next(1, 4));


            string computerChoice = "";

            if (computerNumber == 1)
            {
                computerChoice = "rock";
                computerChoice = "👊";
            }

            else if (computerNumber == 2)
            {
                computerChoice = "paper";
                finalComputer = "✋";
            }

            else
            {
                computerChoice = "scissors";
                finalComputer = "✌️";
            }

            ;

            if (computerChoice == "scissors")
            {
                done = "computerWon";
                ++finalCompScore;
            }

            else if (computerChoice == "rock")
            {
                done = "playerWon";
                ++finalPlayScore;
            }

            else
            {
                done = "tie";
            }
            if (done == "playerWon")
            {
                final = "Player Won!";
            }

            else if (done == "computerWon")
            {
                final = "Computer Won!";
            }

            else
            {
                final = "Tie!";
            }
        }

        void scissors_Clicked(System.Object sender, System.EventArgs e)
        {
            playerChoice = "scissors";
            finalPlayer = "✌️";

            Random rnd = new Random();

            for (int j = 0; j < 4; j++) ;

            int computerNumber = (rnd.Next(1, 4));


            string computerChoice = "";

            if (computerNumber == 1)
            {
                computerChoice = "rock";
                finalComputer = "👊";

            }

            else if (computerNumber == 2)
            {
                computerChoice = "paper";
                finalComputer = "✋";
            }

            else
            {
                computerChoice = "scissors";
                finalComputer = "✌️";
            }

            ;

            if (computerChoice == "scissors")
            {
                done = "tie";
                
            }

            else if (computerChoice == "rock")
            {
                done = "computerWon";
                ++finalCompScore;
            }

            else
            {
                done = "playerWon";
                ++finalPlayScore;
            }

            if (done == "playerWon")
            {
                final = "Player Won!";
            }

            else if (done == "computerWon")
            {
                final = "Computer Won!";
            }

            else
            {
                final = "Tie!";


            }



        }

        void clear_Clicked(System.Object sender, System.EventArgs e)
        {
            finalCompScore = 0;
            finalPlayScore = 0;
            DisplayAlert("RPS - SM", "scores are set to 0", "OK");
        }
    }
}