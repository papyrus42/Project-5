using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace ClassLibrary
{
    public class ObjectsOnLevel
    {
        public int massCount { get; set; }

        public Objects[] stuffOnLevel
        {
            get
            {
                return stuffOnLevel;
            }
            set
            {
                stuffOnLevel = value;
            }
        }

    }
}
