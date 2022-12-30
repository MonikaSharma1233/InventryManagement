// See https://aka.ms/new-console-template for more information
using InventryManagement;

public class Program
{
    public static void Main(String[] args)
    {
        String path = "D:\\BridgeLabz\\CSharp\\InventryManagement\\Inventory.json";
        FatchInventryDetails fatchInventryDetails=new FatchInventryDetails();
        Details details = fatchInventryDetails.Read(path);//method calling 
        Console.WriteLine("TYPE OF RICE ARE:");
        for (int i = 0; i < details.typeOfRice.Count; i++)
        {
            Console.WriteLine(details.typeOfRice[i].name);
            Console.WriteLine(details.typeOfRice[i].weight);
            Console.WriteLine(details.typeOfRice[i].price);
        }
        Console.WriteLine("TYPE OF WHEAT ARE:");
        for (int i = 0; i < details.typeOfWheat.Count; i++)
        {
            Console.WriteLine(details.typeOfWheat[i].name);
            Console.WriteLine(details.typeOfWheat[i].weight);
            Console.WriteLine(details.typeOfWheat[i].price);
        }
        Console.WriteLine("TYPE OF PULSE ARE:");
        for (int i = 0; i < details.typeOfPulse.Count; i++)
        {
            Console.WriteLine(details.typeOfPulse[i].name);
            Console.WriteLine(details.typeOfPulse[i].weight);
            Console.WriteLine(details.typeOfPulse[i].price);
        }

    }
}