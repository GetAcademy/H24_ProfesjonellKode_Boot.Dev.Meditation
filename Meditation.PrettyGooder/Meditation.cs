namespace Meditation.PrettyGooder;


public class State
{
    public int CurrentMana { get; set; }
    public int MaxMana { get; set; }
    public int CurrentEnergy { get; set; }
    public int AvailablePotions { get; set; }

    public State(int currentMana, int maxMana, 
        int currentEnergy, int availablePotions)
    {
        CurrentMana = currentMana;
        MaxMana = maxMana;
        CurrentEnergy = currentEnergy;
        AvailablePotions = availablePotions;
    }
}


public class MeditationFunctions
{
    public static State Meditate(int currentMana, int maxMana, 
        int currentEnergy, int availablePotions)
    {
        var state = new State(currentMana, maxMana, 
            currentEnergy, availablePotions);

        while (state.CurrentMana < state.MaxMana)
        {
            int manaGain = Math.Min(state.CurrentEnergy * 3, 
                state.MaxMana - state.CurrentMana);
            int energyUsed = (int)Math.Ceiling((double)manaGain / 3);

            state.CurrentMana += manaGain;
            state.CurrentEnergy -= energyUsed;

            Console.WriteLine($"After meditation: Mana={state.CurrentMana}, " +
                              $"Energy={state.CurrentEnergy}, " +
                              $"Potions={state.AvailablePotions}");

            if (state.CurrentMana >= state.MaxMana)
            {
                state.CurrentMana = state.MaxMana;
                break;
            }

            if (state.CurrentEnergy <= 0 && state.AvailablePotions > 0)
            {
                state.CurrentEnergy += 50;
                state.AvailablePotions--;

                Console.WriteLine($"Using a potion. Energy={state.CurrentEnergy}, " +
                                  $"Potions left={state.AvailablePotions}");
            }
            else if (state.CurrentEnergy <= 0)
            {
                Console.WriteLine("No energy left and no potions available.");
                break;
            }
        }

        return state;
    }
}