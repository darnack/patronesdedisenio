using Problema_1_Heroes;

List<string> warriorAbilities = new() { "Slash", "Block", "Berserk" };
Warrior originalWarrior = new("Conan", "WarriorAppearance.png", 1000, 10, 5, warriorAbilities);

// Clonar el guerrero original
Warrior clonedWarrior = (Warrior) originalWarrior.Clone();
clonedWarrior.Name = "Thor";
clonedWarrior.VisualAppearance = "ThorAppearance.png";

Console.WriteLine($"Original Warrior: {originalWarrior.Name}, {originalWarrior.VisualAppearance}");
Console.WriteLine($"Cloned Warrior: {clonedWarrior.Name}, {clonedWarrior.VisualAppearance}");