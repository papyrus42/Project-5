using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using TRead = ClassLibrary.ObjectsOnLevel;

namespace ClassLibrary
{
    public class StuffReader : ContentTypeReader<TRead>
    {
        protected override TRead Read(ContentReader input, TRead existingInstance)
        {
            int count = input.ReadInt32();
            List<Objects> stuff = new List<Objects>();
            for (int i = 0; i < count; i++)
            {
                string n = input.ReadString();
                int c = input.ReadInt32();
                int readCount = 0;
                List<Vector2> vects = new List<Vector2>();
                while (readCount <= c)
                {
                    int x = input.ReadInt32();
                    int y = input.ReadInt32();
                    Vector2 v = new Vector2(x, y);
                    vects.Add(v);
                    readCount += 2;
                }
                Vector2[] actualVect = vects.ToArray();
                Objects newStuff = new Objects(n, actualVect);
                stuff.Add(newStuff);
            }
            Objects[] actualStuff = stuff.ToArray();
            ObjectsOnLevel level = new ObjectsOnLevel(actualStuff);
            return level;
        }
    }
}
