var meditation = new Meditation.VeryProfessional.Meditation();

var resourcesAfterMeditation = meditation.Meditate(10, 12, 0, 2);

Console.WriteLine("Resources after meditation");
Console.WriteLine($"Mana: {resourcesAfterMeditation.Mana}");
Console.WriteLine($"Energy: {resourcesAfterMeditation.Energy}");
Console.WriteLine($"Potions: {resourcesAfterMeditation.EnergyPotions}");