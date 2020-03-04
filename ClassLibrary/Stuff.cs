using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ClassLibrary
{
    public class Stuff
    {
        public Vector2[] points { get; }

        public Stuff(Vector2[] p)
        {
            points = p;
        }
    }
}
