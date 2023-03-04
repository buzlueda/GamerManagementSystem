using Core;
using Core.Concrete;

public class Program
{
    public static void Main(string[] args)
    {   
        GamerManager gamerManager = new GamerManager(new GamerValidationManager());
        Gamer gamer1 = new Gamer() {identityNum = 12345, birthYear = 1999, fullName = "Eda Buzlu", userName = "buzlueda" , password = "123"};
        gamerManager.Register(gamer1);


        Games game1 = new Games() {gameName = "The Sims 4" , gamePrice = 20};


        CampaignManager campaignManager = new CampaignManager();
        Campaign campaign1 = new Campaign() {CampaignName = "Summer Gaming Fest" , DiscountRate = 50};


        SalesManager salesManager = new SalesManager ();
        salesManager.Sale(gamer1 , game1 , campaign1);


        campaignManager.AddDiscount(campaign1);
        var newPrice = campaignManager.ApplyDiscount(game1 , campaign1);
        System.Console.WriteLine("Discount Applied! New Price : $" + newPrice);

  
    }
}