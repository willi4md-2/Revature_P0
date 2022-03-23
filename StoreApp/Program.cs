using StoreApp;

// This variable will be used to keep track of where at in the options menu the user wants to be.
//If curoption = 0, show options menu
//If 1, show shop
//If 2, show order history
//If 3, exit and go back to login.
int currentOption = 0;
Item[] itemsBought = new Item[10];
int shoppingTripCounter = 0;

Authentication authenticator = new Authentication();
Authentication authenticated = new Authentication();

Login:
bool hasAccount = authenticator.GetStarted();

if (hasAccount) {
    authenticator.Login();
    authenticated.setUsername(authenticator.getUsername());
    authenticated.setPassword(authenticator.getPassword());
} else {
    authenticator.SignUp();
    authenticated.setUsername(authenticator.getUsername());
    authenticated.setPassword(authenticator.getPassword());
}

Console.WriteLine("\n Your user: " + authenticated.getUsername() + " Your pass: " + authenticated.getPassword());

// Open the options menu and store the result of item chosen.
OptionMenu:
OptionsMenu options = new OptionsMenu();
currentOption = options.openMenu();

// Shop Menu Item Chosen
if (currentOption == 1) 
{
    itemsBought[shoppingTripCounter] = options.goShopping();
    Console.WriteLine("You bought: " + itemsBought[shoppingTripCounter].getItemNumber() + " " + itemsBought[shoppingTripCounter].getQuantity() * itemsBought[shoppingTripCounter].getCost());
    shoppingTripCounter++;
    goto OptionMenu;
} 
// Order History
else if (currentOption == 2)
{
    goto Loop;
} 
// Go back to login
else 
{
    itemsBought = new Item[10];
    shoppingTripCounter = 0;
    goto Login;
}

Loop:
    string curItem = "";
    Console.WriteLine("Your Receipt: ");
    for (int i = 0; i < shoppingTripCounter; i++) {

        if (itemsBought[i].getItemNumber() == 1) 
        {
            curItem = "BANANAS";
        } 
        else if (itemsBought[i].getItemNumber() == 2)
        {
            curItem = "APPLES";
        }
        else 
        {
            curItem = "ORANGES";
        }
        Console.WriteLine(itemsBought[i].getQuantity() + " " + curItem + ": $" + itemsBought[i].getQuantity() * itemsBought[i].getCost());
    }
    goto OptionMenu;