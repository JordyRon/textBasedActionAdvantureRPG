using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace textBasedActionAdvantureRPG
{
    class StateCharacterCreator 
        :State
    {
        ArrayList characterList;

        private void CreateCharacter()
        {
            String name = "";

            Gui.GetInput("Input your character name ");
            name = Console.ReadLine();

            this.characterList.Add(new Character(name));
            Gui.Announcement("Character created");
        }

        public StateCharacterCreator(Stack<State> states, ArrayList character_List)
          : base(states)
        {
            this.characterList = character_List;
        }

        public void ProssesInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.CreateCharacter();
                    break;
                default:
                    break;
            }
        }

        override public void Update()
        {
            Gui.MenuTitle("Character Creator");
            Gui.MenuOption(1, "New Character");
            Gui.MenuOption(2, "Edit Character");
            Gui.MenuOption(3, "Delete Character");
            Gui.MenuOption(-1, "Exit");

            
            int input = Gui.GetInputInt("Input");

            this.ProssesInput(input);
        }
    }
}
