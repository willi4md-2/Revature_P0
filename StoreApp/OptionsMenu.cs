namespace StoreApp
{
    public class OptionsMenu
    {

        private bool open;

        public OptionsMenu() {
            this.open = true;
        }

        public OptionsMenu(bool action) {
            this.open = action;
        }
        

        public int openMenu() {

            MenuOpen:
            Console.WriteLine("===============================================================");
            Console.WriteLine("                         Options Menu                          ");
            Console.WriteLine("      [S]- Go To Shop   [O] - Order History  [X] - Exit        ");
            Console.WriteLine("===============================================================");

            string response = "";
            char[] responseArray = new Char[1];

            try 
            {
                response = Console.ReadLine() ?? "X";
                response = response.Trim().ToUpper();
                responseArray = response.ToCharArray();
            } 
            catch (Exception e)
            {
                Console.WriteLine("Sorry, I didn't quite get that." + e.ToString());
                goto MenuOpen;
            }

            if (response == "") {
                Console.WriteLine("Sorry, I didn't quite get that.");
                goto MenuOpen;
            }

            if (responseArray[0] == 'S') 
            {
                return 1;
            }
            else if (responseArray[0] == 'O') 
            {
                return 2;
            }
            else if (response[0] == 'X')
            {
                Console.WriteLine("Going back to login...");
                return 3;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't quite get that.");
                goto MenuOpen;
            }
        }

        public Item goShopping() 
        {
            ShopMenu:
            Console.WriteLine("===============================================================");
            Console.WriteLine("                         Items Menu                            ");
            Console.WriteLine("           ITEM TYPE:  Bananas   Apples  Oranges               ");
            Console.WriteLine("           ITEM #   :     1        2        3                  ");
            Console.WriteLine("           ITEM COST:   $1.10    $1.25    $5.50                ");            
            Console.WriteLine("===============================================================");
            Console.WriteLine("           Format to buy item: [Item#] [Quantity]              ");

            string response = "";
            string[] splitResponse = new string[2];
            int[] parsedResponse = new int[2];

            try 
            {
                response = Console.ReadLine() ?? "X";
                splitResponse = response.Split();
                for (int i = 0; i < splitResponse.Count(); i++) {
                    parsedResponse[i] = Int32.Parse(splitResponse[i]);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Sorry, I didn't quite get that." + e.ToString());
                goto ShopMenu;
            }

            if (parsedResponse[0] == 0) {
                return new Item(0, 0, 0);
            }

            if (parsedResponse[1] == 0) {
                Console.WriteLine("Please input a valid quantity.");
                goto ShopMenu;
            }

            if (parsedResponse[0] == 1) 
            {
                Console.WriteLine("You've purchased " + parsedResponse[1] + " APPLES");
                Console.WriteLine("Your total is: " + parsedResponse[1] * 1.1);
                return new Item(1.1, 1, parsedResponse[1]);
            }
            else if (parsedResponse[0] == 2)
            {
                Console.WriteLine("You've purchased " + parsedResponse[1] + " BANANAS");
                Console.WriteLine("Your total is: " + parsedResponse[1] * 1.25);
                return new Item(1.25, 2, parsedResponse[1]);
            }
            else if (parsedResponse[0] == 3)
            {
                Console.WriteLine("You've purchased " + parsedResponse[1] + " ORANGES");
                Console.WriteLine("Your total is: $" + parsedResponse[1] * 5.5);
                return new Item(5.5, 3, parsedResponse[1]);
            }
            else 
            {
                Console.WriteLine("Sorry, I didn't quite get that.");
                goto ShopMenu;
            }
        }

        public void orderHistory() {

        }

    }
}