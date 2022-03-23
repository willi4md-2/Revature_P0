namespace StoreApp;

    public class Authentication
    {

        // private string username 
        // {
        //     get { return username; }   // get method
        //     set { username = value; }  // set method
        // }
        // private string passWord  
        // {
        //     get { return passWord; }   // get method
        //     set { passWord = value; }  // set method
        // }

        // public Authentication() {
        //     this.username = "Default";
        //     this.passWord = "Default";
        // }

        // public Authentication(string user, string pass) {
        //     this.username = user;
        //     this.passWord = pass;
        // }

        public void GetStarted() {

            //Initial Prompt for User Authentication
            Prompt:
            Console.WriteLine("===============================================================");
            Console.WriteLine("  Welcome to X Shop! Do you already have an account with us?");
            Console.WriteLine("===============================================================");
            Console.WriteLine(" Type [Y] for YES and [N] for NO --> [Y][N] \n");

            string response = "";
            char[] responseArray = new char[1];
            //variable stores users response and it is then parsed and converted to an integer for validation.
            try 
            {
            response = Console.ReadLine() ?? "X";
            responseArray = response.Trim().ToUpper().ToCharArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: " + e.ToString());
                //e.toString();
                //Add error logging to text files
                goto Prompt;
            }

            if (response == "") {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: ");
                goto Prompt;
            }

            //If the user already has an account.
            if (responseArray[0].Equals('Y')) 
            {
                Console.WriteLine("\n" + "===============================================================");
                Console.WriteLine("Great! Let's move to the login screen.");
                Console.WriteLine("===============================================================");
                Login();
            }
            //User does not have an account and answered no.
            else if (responseArray[0].Equals('N'))
            {
                Console.WriteLine("\n\n\n\n\n\n" + "===============================================================");
                Console.WriteLine("Great! Let's create an account.");
                Console.WriteLine("===============================================================");
                SignUp();
            }
            //User did not answer with a Y or N
            else
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: ");
                goto Prompt;
            }
        }

        public void Login() {

            Username:
            Console.WriteLine("===============================================================");
            Console.WriteLine("Username: ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n [To go back and sign up, type 'X' and hit enter at any time.] \n");

            string user = "";

            try 
            {
            user = Console.ReadLine() ?? "X";
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: " + e.ToString());
                //e.toString();
                //Add error logging to text files
                goto Username;
            }

            if (user.Equals("X")) 
            {
                GetStarted();
                goto End;
            }

            if (user.Length < 3 || user.Length > 12) {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: ");
                //e.toString();
                //Add error logging to text files
                goto Username;
            }
                // Verify given string matches a database entry and then proceed to password
                //If (response matches DB entry) { proceed } else { Console.WriteLine("Username not found."); goto Username;  }
            Password:
            Console.WriteLine("===============================================================");
            Console.WriteLine("Password: ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n [To go back to the username screen, type 'X' and hit enter at any time.] \n");

            string pass = "";

            try 
            {
            pass = Console.ReadLine() ?? "X";
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: " + e.ToString());
                //e.toString();
                //Add error logging to text files
                goto Password;
            }

            if (pass.Equals("X")) 
            {
                goto Username;
            } else {

            }

            End:
            if (user.Equals("X")) {
                // Do something?
            }
        }

        public void SignUp() {

            Username:
            Console.WriteLine("===============================================================");
            Console.WriteLine("Enter your new username below: ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n [To go back and login, type 'X' and hit enter at any time.] \n");

            string user = "";

            try 
            {
            user = Console.ReadLine() ?? "X";
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: " + e.ToString());
                //e.toString();
                //Add error logging to text files
                goto Username;
            }

            if (user.Equals("X")) 
            {
                GetStarted();
                goto End;
            }
                // Verify given string matches a database entry and then proceed to password
                //If (response matches DB entry) { proceed } else { Console.WriteLine("Username not found."); goto Username;  }
            Password:
            Console.WriteLine("===============================================================");
            Console.WriteLine("Enter Your New Password: ");
            Console.WriteLine("===============================================================");
            Console.WriteLine("\n [To go back to the username screen, type 'X' and hit enter at any time.] \n");

            string pass = "";

            try 
            {
            pass = Console.ReadLine() ?? "X";
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Sorry, I didn't quite get that. Let's try again: " + e.ToString());
                //e.toString();
                //Add error logging to text files
                goto Password;
            }

            if (pass.Equals("X")) 
            {
                goto Username;
            } else {
                //ask for password confirmation
                //send message saying "congrats on making your new account at X shop!"
                //"Your new username is: {}"
                int dollars = new Random().Next(10, 150);
                int cents = new Random().Next(1, 100);
                //"Your total balance is: {num}"
                //Propogate database with UUID, Login, Password, and new Balance
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");
                Thread.Sleep(300);
                Console.WriteLine("===============================================================");

                Console.WriteLine($"\n    |  You're all set! Your remaining balance is: ${dollars}.{cents}  |");                
            }

            End:
            if (user.Equals("X")) {
                // Do something?
            }
        }
        
    }
