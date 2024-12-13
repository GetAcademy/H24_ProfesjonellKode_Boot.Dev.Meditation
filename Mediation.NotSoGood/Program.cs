namespace Mediation.NotSoGood;

internal static class Program
{
    public static void Main(string[] args)
    {
        Meditate(10, 12, 0, 2);
    }

    private static void Meditate(int mana, int maxMana, int energy, int energyPotions)
    {
        while (mana < maxMana && (energy > 0 || energyPotions > 0))
        {
            if (energy > 0)
            {
                int manaGain = Math.Min(3, maxMana - mana);
                mana += manaGain;
                energy--;
            }
            else
            {
                energyPotions--;
                energy = 50;
            }
        }

        Console.WriteLine($"Final Mana: {mana}");
        Console.WriteLine($"Remaining Energy Potions: {energyPotions}");
    }
}