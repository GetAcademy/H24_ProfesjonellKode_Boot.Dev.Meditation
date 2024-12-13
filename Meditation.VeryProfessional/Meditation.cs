namespace Meditation.VeryProfessional;

public class Meditation
{
    private const int ManaGainPerEnergy = 3;
    private const int EnergyGainPerPotion = 50;
    public CharacterResources Meditate(int mana, int maxMana, int energy, int energyPotions)
    {
        var characterResources = new CharacterResources
        {
            Energy = energy,
            EnergyPotions = energyPotions,
            Mana = mana,
            MaxMana = maxMana
        };
        
        while (characterResources.Mana < characterResources.MaxMana)
        {
            if (IsOutOfEnergyAndPotions(characterResources))
            {
                break;
            }

            if (characterResources.Energy == 0)
            {
                UsePotion(characterResources);
            }

            UseEnergyForMana(characterResources);
        }

        return characterResources;
    }

    private bool IsOutOfEnergyAndPotions(CharacterResources characterResources)
    {
        return characterResources is { Energy: 0, EnergyPotions: 0 };
    }

    private void UseEnergyForMana(CharacterResources characterResources)
    {
        characterResources.Mana += ManaGainPerEnergy;
        
        if (characterResources.Mana >= characterResources.MaxMana)
        {
            characterResources.Mana = characterResources.MaxMana;
        }
        
        characterResources.Energy--;
    }

    private void UsePotion(CharacterResources characterResources)
    {
        characterResources.Energy += EnergyGainPerPotion;
        characterResources.EnergyPotions--;
    }
}