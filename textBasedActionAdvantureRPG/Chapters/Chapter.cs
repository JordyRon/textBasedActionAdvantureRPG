using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedActionAdvantureRPG.Chapters
{
    class Chapter
    {
        public List<StoryLine> storyLines = new List<StoryLine>();
        public int state = 0;

        public void Test()
        {
            storyLines.Add(new PrintLine() { Line = "Hallo"});
            storyLines.Add(new PrintLine() { Line = "Hallo" });
            storyLines.Add(new PrintLine() { Line = "Hallo" });
            storyLines.Add(new PrintLine() { Line = "Hallo" });
            storyLines.Add(new PrintLine() { Line = "Hallo" });
            storyLines.Add(new PrintLine() { Line = "Hallo" });
            storyLines.Add(new RequestLine() { Line = "Hoe heet je" });
        }

        public void NextState()
        {
            state++;
            PrintState();
        }

        public void PrintState()
        {
            storyLines[state].HandleLine(this);
        }
    }
}
