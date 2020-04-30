using System;

namespace hangman
{

    class StickFigure{

        public bool rightArm { get; set; } 
        public bool leftArm { get; set; }
        public bool rightLeg { get; set; }
        public bool leftLeg { get; set; }
        public bool head { get; set; }

        public StickFigure(){
            this.rightArm = false;
            this.leftArm = false;
            this.rightLeg = false;
            this.leftLeg = false;
            this.head = false;
        }



        public void printHead(){}

        public void printHands(){}

        public void printLegs(){}
    }

    class Program
    {

        static void Main(string[] args)
        {
            string[] words = new string [8] {"collision","prefab","tileset","enemy","unity","projection","games","camera"};
            StickFigure stickman = new StickFigure();
            Random rnd = new Random();
            string chosen = words[rnd.Next(words.Length)];
            //Add an empty string that will store the chosen letters
            Console.WriteLine(chosen);
        }
    }
}
