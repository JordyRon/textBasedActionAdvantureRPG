using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedActionAdvantureRPG.Chapters
{
    class PrintLine : StoryLine
    {

        public String Line;
        
        public override void HandleLine(Chapter parent)
        {
            Console.WriteLine(Line);
            //Sleep
            parent.NextState();
        }

    }
}
