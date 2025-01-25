namespace TheMission3Assignment;

public class FoodItem
{
    //Add a Name, Category, Quantity,Expiration Date 
    public string Name { get; private set; }
    public string Category { get; private set; }
    public int Quantity { get; private set; }
    public DateTime ExpirationDate { get; private set; }
    
    //Constructor For Object
    public FoodItem(string name, string category, int quantity, DateTime dateTime)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = dateTime;
    }
    


    public override string ToString()
    {
        //Writes it out to string to be Displayed later 
        string foodObject = $"Name: {Name}     Category : {Category}     Quantity : {Quantity}     Expiration Date : {ExpirationDate.Day}/{ExpirationDate.Month}/{ExpirationDate.Year}";
        
        return foodObject; 
        // This foodObject will later be stored in a Modifiable List
    }
   
}