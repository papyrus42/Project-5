using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using ClassLibrary;

using TInput = System.String;
using TOutput = ClassLibrary.ObjectsOnLevel;

namespace Class_Extensions
{
    [ContentProcessor(DisplayName = "Stuff Processor")]
    public class StuffProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(string input, ContentProcessorContext context)
        {
            string[] lines = input.Split(new char[] { '\n' });
            int end = 0;
            List<Objects> stuff = new List<Objects>();
            while(end < input.Length)
            {
                string newObj = lines[end];
                end++;
                int howMany = Convert.ToInt32(lines[end]);
                end++;
                List<Vector2> vects = new List<Vector2>();
                for(int i = 0; i <=howMany; i++)
                {
                    string[] cords = lines[end].Split(new char[] { ' ' });
                    Vector2 c = new Vector2(Convert.ToInt32(cords[0]), Convert.ToInt32(cords[1]));
                    vects.Add(c);
                    end++;
                }
                Vector2[] actualVect = vects.ToArray();
                Objects newStuff = new Objects(newObj, actualVect);
                stuff.Add(newStuff);
            }

            Objects[] actualStuff = stuff.ToArray();
            ObjectsOnLevel level = new ObjectsOnLevel(actualStuff);
            return level;
        }
    }
}
