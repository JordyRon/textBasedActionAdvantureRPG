using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedActionAdvantureRPG
{
    class StateMainMenu 
        : State
    {
        protected ArrayList characterList;
        protected Character activeCharacter;

        public StateMainMenu(Stack<State> states, ArrayList character_List) 
            : base(states)
        {
            this.characterList = character_List;
            this.activeCharacter = null;
        }

        public void ProssesInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.StartNewGame();
                    break;
                case 2:
                    this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                    break;
                case 3:
                    this.SelectCharacter();
                    break;
                default:
                    break;
            }
        }

        override public void Update()
        {
            Gui.MenuTitle("Main Menu");
            if (this.activeCharacter != null)
                Console.WriteLine("Active Character: " + this.activeCharacter.Name() + "\n");
            Gui.MenuOption(1, "New Game");
            Gui.MenuOption(2, "Character Creator");
            Gui.MenuOption(3, "Select Characters");
            Gui.MenuOption(-1, "Exit");

            
            int input = Gui.GetInputInt("Input");

            this.ProssesInput(input);
        }

        public void StartNewGame()
        {
            if (this.activeCharacter == null)
            {
                Gui.Announcement("There is no Active Character selected!! Select a Character before starting the game");
            }
            else
            {
                this.states.Push(new StateGame(this.states, this.activeCharacter));
            }
        }

        public void SelectCharacter()
        {
            for (int i =0; i < this.characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + characterList[i].ToString());
            }

            int choice = Gui.GetInputInt("Character Selection");

            try
            {
                this.activeCharacter = (Character)this.characterList[choice];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if (this.activeCharacter != null)
                Gui.Announcement($"The Character {this.activeCharacter.Name()} is selected");
        }
    }
}
