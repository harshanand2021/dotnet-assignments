namespace Assignment4_1;

class Program
{
    static void Main(string[] args)
    {
        //Citizen with Aadhar
        AadharCard aadharCard = new AadharCard("3456-6789-0203", "Bavdhan, Pune MH");

        Citizen citizen1 = new Citizen(101, "Harsh Anand", aadharCard);

        citizen1.DisplayCitizen();

        //Citizen without Aadhar

        Citizen citizen2 = new Citizen(102, "Ramu Singh", null);

        citizen2.DisplayCitizen();
    }
}

