namespace Meditation.PrettyGooder;

public class State
{
    public int CurrentMana { get; set; }
    public int MaxMana { get; set; }
    public int CurrentEnergy { get; set; }
    public int AvailablePotions { get; set; }

    public bool CanMeditate => CurrentMana < MaxMana;

    public State(int currentMana, int maxMana, 
        int currentEnergy, int availablePotions)
    {
        CurrentMana = currentMana;
        MaxMana = maxMana;
        CurrentEnergy = currentEnergy;
        AvailablePotions = availablePotions;
    }
}