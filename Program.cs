// Display Menu with options 


using TheMission3Assignment;

String menuVariable ="";

List<FoodItem> foodInventory = new List<FoodItem>();


while (menuVariable != "Exit")
{
    
    Console.WriteLine("1: Add Food Items \n2: Delete Food Items \n3: Print List of Current Food Items \n4: Exit the Program");
    Console.WriteLine("Type Number to choose Menu Choice: ");
    menuVariable = Console.ReadLine();

    if (menuVariable == "4")
    {
        //Exits Menu and terminates program. 
        Console.Clear();
        Console.WriteLine("Terminating the program. . . .\n \nGoodbye now. . . .");
        break;
    }
    else if (menuVariable == "1")
    {
        // Add Food Item 
        addFood(); 
        

    }
    else if (menuVariable == "2")
    {
        //Deleted Food 
        deleteFood();
    }
    else if (menuVariable == "3")
    {
        //Prints Food Options
        printFood();
    }else 
    {
        //Handles Basic Error Handling for Menu Options
        Console.WriteLine("\nInvalid input : Select 1-4 \n \nHit Enter to Return to Main Menu");
        Console.ReadLine();
    }






}

//Add Food 
void addFood(){
    Console.Clear(); // Clears page to help with readability 
    
    //Asks all the necessary questions to add a Food Item.  
    
         Console.WriteLine("What is the name of the food?");
         string name = Console.ReadLine();
         Console.WriteLine("What is the category of the food?");
         string category = Console.ReadLine();
         Console.WriteLine("What is the quanity of the food?");
         int quantity;
         while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
         {
             //Handles Basic Error Handling for inputs
             Console.Write("Please enter a valid, non-negative quantity: ");
         }
         
         DateTime expirationDate;
         Console.WriteLine("What is the expiration date of the food?");
         while (!DateTime.TryParse(Console.ReadLine(), out expirationDate) || expirationDate < DateTime.Now)
         {
             //Handles Basic Error Handling for inputs
             Console.Write("Please enter a valid future Date ");
         }
         
         //Adds food Item to list 
         
         FoodItem foodItem = new FoodItem(name, category, quantity, expirationDate);
         foodInventory.Add(foodItem);
         Console.WriteLine("\nItem added to Inventory\n");
         Console.WriteLine("Hit Enter to Return to Main Menu. . .");
         Console.ReadLine();
         Console.Clear();
         // Clears Console for Readability
}


// Delete option

void deleteFood()
{
    int itemLoc;
    Console.Clear();
    //Displays food options
    if (foodInventory.Count > 0)
    {
        for (int i = 0; i < foodInventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {foodInventory[i]}");

        }
        //Validates for Correct Food Option

        Console.WriteLine("\nSelect an item to delete from Inventory : (Enter Number)");
        while (!int.TryParse(Console.ReadLine(), out itemLoc))
        {
            Console.Write("\nPlease enter a valid number. . .");
        }

        foodInventory.RemoveAt(itemLoc - 1);
        Console.WriteLine("\nItem deleted from Inventory");
    }
    else
    {
        Console.WriteLine("\nThere's nothing to delete from Inventory");
    }

    Console.WriteLine("\nHit Enter to Return to Main Menu. . .");
    Console.ReadLine();
    Console.Clear();
    // Clears for Readability
    
}

//Print Food Inventory 

void printFood()
{
    Console.Clear();
    if (foodInventory.Count > 0)
    {
        for (int i = 0; i < foodInventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {foodInventory[i]}");
        
        
        }
    }
    else
    {
        Console.WriteLine("\nThere are no items in this Inventory");
    }
    
    Console.WriteLine("\nHit Enter to Return to Main Menu. . .");
    Console.ReadLine();

}

