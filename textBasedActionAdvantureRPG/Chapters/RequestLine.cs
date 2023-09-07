using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedActionAdvantureRPG.Chapters
{
    class RequestLine : StoryLine
    {

        public String Line;
        
        public override void HandleLine(Chapter parent)
        {
            String input = "";
            while (input == null || input == "")
            {
                Console.WriteLine(Line);
                input = Console.ReadLine();
            }
            //Doe iets met input
            parent.NextState();
        }

    }
}
