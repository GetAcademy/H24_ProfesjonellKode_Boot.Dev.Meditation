namespace Meditation.PrettyGooder;

public static class Mediation
{
    public static State Meditate(int currentMana, int maxMana, 
        int currentEnergy, int availablePotions)
    {
        var state = new State(currentMana, maxMana, 
            currentEnergy, availablePotions);

        while (state.CanMeditate)
        {
            var manaGain = Math.Min(state.CurrentEnergy * 3, 
                state.MaxMana - state.CurrentMana);
            var energyUsed = (int)Math.Ceiling((double)manaGain / 3);
            state.CurrentMana += manaGain;
            state.CurrentEnergy -= energyUsed;
            if (state.CurrentMana >= state.MaxMana)
            {
                state.CurrentMana = state.MaxMana;
                break;
            }
            if (state.CurrentEnergy <= 0 && state.AvailablePotions > 0)
            {
                state.CurrentEnergy += 50;
                state.AvailablePotions--;
            }
            else if (state.CurrentEnergy <= 0)
            {
                break;
            }
        }
        
        return state;
    }
}