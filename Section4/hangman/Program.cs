using System;
using System.Text;

namespace hangman
{

    class StickFigure{

        public int lives { get; set; }

        public StickFigure(){
            this.lives = 0;
        }

        public void printBody(int lives){//print stickman according to lives
            Console.WriteLine();
            switch (lives){
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("**************               ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*        ***                 ");
                    break;
                
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("**************               ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    break;
                
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("******************           ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       * * *                ");
                    Console.WriteLine("*      *  *  *               ");
                    Console.WriteLine("*         *                  ");
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("******************           ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       * * *                ");
                    Console.WriteLine("*      *  *  *               ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        * *                 ");
                    break;
                
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("******************           ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        ***                 ");
                    Console.WriteLine("*       * * *                ");
                    Console.WriteLine("*      *  *  *               ");
                    Console.WriteLine("*         *                  ");
                    Console.WriteLine("*        * *                 ");
                    Console.WriteLine("*       *   *                ");
                    Console.WriteLine("*      *     *               ");
                    Console.WriteLine("*");
                    Console.WriteLine("*");
                    Console.WriteLine("*");
                    Console.WriteLine("*");
                    Console.WriteLine("**********************");break;

            }
        }

        public void printGameOver(){ //print game over in console
            Console.WriteLine();
            Console.WriteLine("***    **   *   *  ****    ****  *   *  ****  ****");
            Console.WriteLine("*     *  *  ** **  *       *  *  *   *  *     *  *");
            Console.WriteLine("* **  ****  * * *  ****    *  *  *   *  ****  *** ");
            Console.WriteLine("*  *  *  *  *   *  *       *  *   * *   *     *  *");
            Console.WriteLine("****  *  *  *   *  ****    ****    *    ****  *  *");

        }
        public void printWin(){//print you win in console
            Console.WriteLine();
            Console.WriteLine("* *  ****  *  *    *   *  ***  *   *");
            Console.WriteLine("* *  *  *  *  *    *   *   *   **  *");
            Console.WriteLine(" *   *  *  *  *    * * *   *   * * *");
            Console.WriteLine(" *   *  *  *  *    ** **   *   *  **");
            Console.WriteLine(" *   ****  ****    *   *  ***  *   *");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string[] words = new string [8] {"collision","prefab","tileset","enemy","unity","projection","games","camera"};// word bank
            bool isWon = false;
            StickFigure stickman = new StickFigure();
            Random rnd = new Random();
            string chosen = words[rnd.Next(words.Length)];
            string guessed ="";//letters that were guessed
            for (int i = 0; i < chosen.Length; i++){
                guessed += "_";
            }
            Console.WriteLine(guessed);
            char c; 
            //Console.WriteLine(chosen);
            while(stickman.lives < 5 && isWon == false){
                Console.WriteLine("Guess a letter");
                c = char.Parse(Console.ReadLine());
                if (!Char.IsLetter(c)) {
                    Console.WriteLine("\nPlease enter a letter");
                }
                else {
                    int i = 0;
                    bool isIn = false;
                    while(i < chosen.Length){
                        if(c == chosen[i]){
                            StringBuilder sb = new StringBuilder (guessed);
                            sb[i] = c;
                            guessed = sb.ToString();
                            isIn = true;
                        }
                        i++;
                    }
                    if (isIn == false){
                        stickman.lives++;
                    }
                }
                if(string.Equals(guessed,chosen)){
                    isWon = true;
                }

              stickman.printBody(stickman.lives); 
              Console.WriteLine(guessed); 
            }
            if(isWon == true){
                stickman.printWin();
            }
            else {
                stickman.printGameOver();
            }
        }
    }
}
