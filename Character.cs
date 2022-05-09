using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lav en klasse Character med følgende properties:
// Level(int), Attributes(Attributes),
// CharacterType(CharacterType), Xp(int), Name(string).
// Lav en enum CharacterType med følgende :
// Fighter, Mage, Cleric, Bard, Rouge, Paladin, Barbarian

namespace OOPpartunoRPG
{
    enum CharacterType { Fighter = 1, Mage, Cleric, Bard, Rouge, Paladin, Barbarian };
    internal class Character
    {
        public int Level { get; set; }
        public Skills Skills { get; set; }
        public CharacterType CharacterType { get; set; }
        public int Xp { get; set; }
        public string Name { get; set; }

        public void ShowCharacter()
        {
            Console.WriteLine("Name:" + " " + Name);
            Console.WriteLine("Type:" + " " + CharacterType);

            Console.WriteLine("Strength: " + Skills.Strength);

            Console.WriteLine("Intelligence: " + Skills.Intelligence);

            Console.WriteLine("Wisdom: " + Skills.Wisdom);

            Console.WriteLine("Dexterity: " + Skills.Dexterity);

            Console.WriteLine("Constitution: " + Skills.Constitution);

            Console.WriteLine("Charisma: " + Skills.Charisma);
            Console.WriteLine();
        }
    }
}
