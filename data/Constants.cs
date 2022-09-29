using Microsoft.VisualBasic.CompilerServices;

namespace SeleniumFrameworkCSharp.data;

public static class Constants
{
    public static Random rand = new Random();
    public static decimal randomNum = new decimal(rand.Next(1, 99));

    public static string FName = "Nada";
    public static string LName = "Sayed";
    public static string Email = "test" + randomNum.ToString() + "@example.com";
    public static string Password = "p@ssword";
    public static String producrName = "Apple MacBook Pro 13-inch";
    public static String NewPassword = "p@$$word";

}