using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpartunoRPG
{
    internal class Game

    {
        Skills skills = new Skills();
        Character character = new Character();
        List<Character> characters = new List<Character>();

        public Game()
        {
            while (true)
            {
                Menu();

            }
        }

        private void Menu()
        {
            skills = new Skills();
            Console.WriteLine("Press any key to roll the dice and get skills!");
            Console.ReadKey();

            do
            {
                Console.Clear();

                Console.WriteLine("\nWhat you see is what you get!\n");

                ShowSkills();
                Console.WriteLine("\nNot content? Press any key to roll again.");
                Console.WriteLine("\nPress Q to quit rolling.\n");

            }

            while (Console.ReadKey(true).Key != ConsoleKey.Q);
            character = new Character();
            
            character.Skills = skills;

            SelectCharacterType();

            SelectName();

            ShowCharacter();
        }

        public int RollSkills()
        {
            Random random = new Random();

            int roll = 0;

            for (int i = 0; i < 3; i++)
            {
                int dice = random.Next(1, 7);
                Console.Write(dice + " ");
                roll += dice;
            }
            return roll;
        }
        // Tilføj Character til listen
        // Skills skills = new Skills(Skills[0], Skills[1], Skills[2], Skills[3]...)
        // Add to list
        public void ShowSkills()
        {

            skills.Strength = RollSkills();

            Console.WriteLine("Strength " + skills.Strength);

            skills.Intelligence = RollSkills();

            Console.WriteLine("Intelligence " + skills.Intelligence);

            skills.Wisdom = RollSkills();

            Console.WriteLine("Wisdom " + skills.Wisdom);

            skills.Dexterity = RollSkills();

            Console.WriteLine("Dexterity " + skills.Dexterity);

            skills.Constitution = RollSkills();

            Console.WriteLine("Constitution " + skills.Constitution);

            skills.Charisma = RollSkills();

            Console.WriteLine("Charisma " + skills.Charisma);
        }
        public void SelectCharacterType()
        {
            Console.WriteLine("Choose your character type: \n");

            foreach (var characterType in Enum.GetValues(typeof(CharacterType)))
            {
                Console.WriteLine((int)characterType + " " + characterType.ToString());

            }
            character.CharacterType = (CharacterType)(int)Console.ReadKey(true).Key - 48;
            Console.WriteLine("\nYou have chosen a " + character.CharacterType);
        }

        public void SelectName()
        {
            Console.WriteLine("\nEnter a name for your character: ");
            character.Name = Console.ReadLine();
        }
        private void ShowCharacter()
        {
            Console.WriteLine("Name:" + " " + character.Name);
            Console.WriteLine("Type:" + " " + character.CharacterType);

            Console.WriteLine("Strength: " + character.Skills.Strength);

            Console.WriteLine("Intelligence: " + character.Skills.Intelligence);

            Console.WriteLine("Wisdom: " + character.Skills.Wisdom);

            Console.WriteLine("Dexterity: " + character.Skills.Dexterity);

            Console.WriteLine("Constitution: " + character.Skills.Constitution);

            Console.WriteLine("Charisma: " + character.Skills.Charisma);


            Console.WriteLine($"\nDo you want to add {character.Name} to the party? (Y/N)");


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                    Console.WriteLine($"{character.Name} has been added to the party.");
                    characters.Add(character);
                    ShowParty();
                    break;
                case ConsoleKey.N:
                    Console.WriteLine($"{character.Name} has not been added to the party.");
                    break;
                default:
                    break;
            }
        }
        private void ShowParty()
        {
            Console.WriteLine("\nThe party so far...\n");
            foreach (Character character in characters)
            {
                character.ShowCharacter();
            }
        }
    }
}