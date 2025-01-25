namespace TheMission3Assignment;

public class FoodItem
{
    //Add a Name, Category, Quanity,Experiation Date 
    public string Name { get; private set; }
    public string Category { get; private set; }
    public int Quantity { get; private set; }
    public DateTime ExpirationDate { get; private set; }
    
    public FoodItem(string name, string category, int quantity, DateTime dateTime)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = dateTime;
    }
    // I can't return a string from here ^ This is a constructor 


    public override string ToString()
    {
        //Writes it out to string to be Displayed later 
        string foodObject = $"{Name} : Category : {Category} : Quantity : {Quantity} : Expiration Date : {ExpirationDate.Day}/{ExpirationDate.Month}/{ExpirationDate.Year}";
        
        return foodObject;
    }
   
}