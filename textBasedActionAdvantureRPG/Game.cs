using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;

namespace textBasedActionAdvantureRPG
{
    internal class Game
    {
        //Variables
        private bool end;
        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }


        private Stack<State> states;
        private ArrayList characterList;

        //Private functions
        private void InitVariables()
        {
            this.end = false;

        }

        private void InitCharacterList()
        {
            this.characterList = new ArrayList();
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            this.states.Push(new StateMainMenu(this.states, this.characterList));
        }


        //Constructors and Destructors
        public Game()
        {
            this.InitVariables();
            this.InitCharacterList();
            this.InitStates();
        }

        public void Run()
        {
            while (this.states.Count > 0)
            {
                if (this.states.Count > 0)
                {
                    this.states.Peek().Update();

                    if (this.states.Peek().RequestEnd())
                        this.states.Pop();
                }
            }

            Console.WriteLine("Ending Game.....");
        }
    }
}
