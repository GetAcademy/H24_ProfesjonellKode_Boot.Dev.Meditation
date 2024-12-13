using Meditation.PrettyGooder;

var state = Mediation.Meditate(10, 12, 0, 2);
Console.WriteLine($"After meditation: Mana={state.CurrentMana}, " +
                  $"Energy={state.CurrentEnergy}, " +
                  $"Potions={state.AvailablePotions}");