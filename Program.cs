// See https://aka.ms/new-console-template for more information

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
        break;
    }
    else if (menuVariable == "1")
    {
        // Add Food Item 
        addFood(); 
        

    }
    else if (menuVariable == "2")
    {
        deleteFood();
    }
    else if (menuVariable == "3")
    {
        printFood();
    }else 
    {
        Console.WriteLine("\nInvalid input : Select 1-4 \n \nHit Enter to Return to Main Menu");
        Console.ReadLine();
    }






}

//Add Food 
void addFood(){
        Console.Clear();
         Console.WriteLine("What is the name of the food?");
         string name = Console.ReadLine();
         
         Console.WriteLine("What is the category of the food?");
         string category = Console.ReadLine();
         Console.WriteLine("What is the quanity of the food?");
         int quantity;
         while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
         {
             Console.Write("Please enter a valid, non-negative quantity: ");
         }
         
         DateTime expirationDate;
         Console.WriteLine("What is the expiration date of the food?");
         while (!DateTime.TryParse(Console.ReadLine(), out expirationDate) || expirationDate < DateTime.Now)
         {
             Console.Write("Please enter a valid future Date ");
         }
         //Adds food Item to list 
         
         FoodItem foodItem = new FoodItem(name, category, quantity, expirationDate);
         foodInventory.Add(foodItem);
         Console.WriteLine("\nFood added");
         Console.WriteLine("\nHit Enter to Return to Main Menu. . .");
         Console.ReadLine();
         Console.Clear();
}


// Delete option

void deleteFood()
{
    int itemLoc;
    Console.Clear();
    //Displays food options 
    for (int i = 0; i < foodInventory.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {foodInventory[i]}");
        
        
    }
    //Validates for Correct Food Option: 
    Console.WriteLine("\nSelect an item to delete");
    while (!int.TryParse(Console.ReadLine(), out itemLoc) )
                 {
                     Console.Write("\nPlease enter one valid option at a time: ");
                 }
                 
                 foodInventory.RemoveAt(itemLoc -1);Console.WriteLine("\nFood deleted");
    Console.WriteLine("\nHit Enter to Return to Main Menu. . .");
    Console.ReadLine();
    
}

//Print Food Inventory 

void printFood()
{
    Console.Clear();
    for (int i = 0; i < foodInventory.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {foodInventory[i]}");
        
        
    }
    Console.WriteLine("\nHit Enter to Return to Main Menu. . .");
    Console.ReadLine();

}

