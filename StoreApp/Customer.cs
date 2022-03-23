namespace Store;

    public class Customer
    {

        //Declare and intialize username and password attributes.
        private string username = "";
        private string password = "";

        //Default Constructor.
        public Customer() {
            this.username = "Default";
            this.password = "Default";
        }
        
        // Customer constructor which takes a username and password.
        public Customer(String user, String pass) {
            this.username = user;
            this.password = pass;
        }

        public void SignUp() {
            Console.WriteLine("Enter A Username: ");
            string username = Console.ReadLine() ?? "Username";
            Console.WriteLine("Your username is: " + username);
        }

        //Sets a customers username to the given string.
        public void SetUsername(String user) {
            this.username = user;
        }   

        //Sets a customers password to the given string.
        public void setPassword(String pass) {
            this.password = pass;
        }

        //Parse DB for a given Username matching the string.
        //If no match is found, return an appropriate error.
        public void LogIn() {
            Console.WriteLine($"Welcome back, {this.username}!");
        }

        
    }
