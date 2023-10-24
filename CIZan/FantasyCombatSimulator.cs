using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class FantasyCombatSimulator
    {

    // Added a comment just for show
    static int strForPlayerOne = 30;
    static int strForPlayerTwo = 45;
    static string nameForPlayerOne = "Cizan";
    static string nameForPlayerTwo = "Zanci";

    static float damage; 

        static void Main(string[] args)
        {
        Console.WriteLine("Hello world!");
        SharePlayerDamageValue(strForPlayerOne, nameForPlayerOne);
        damage = BuffByMultiplyingByTwo(strForPlayerOne);
        Console.WriteLine("Your buffed damage is " +  damage);

        if (damage < 50)
        {
            Console.WriteLine("You lose!");
        }
        else
        {
            Console.WriteLine("You win!");
        }
    }

    public static void SharePlayerDamageValue(int value, string playerName)
    {
        Console.WriteLine("Hi " + playerName);
        Console.WriteLine("Your current strength is " + value);

        damage = value * 1.5f; 

        Console.WriteLine("Your damage is " +  damage);
    }

    public static float BuffByMultiplyingByTwo(float value)
    {
        float multipliedValue;
        multipliedValue = value * 2;

        return multipliedValue;
    }




}
