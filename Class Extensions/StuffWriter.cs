using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using ClassLibrary;

using TWrite = ClassLibrary.ObjectsOnLevel;

namespace Class_Extensions
{
    [ContentTypeWriter]
    public class StuffWriter : ContentTypeWriter<TWrite>
    {
        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "ClassLibrary.StuffReader, StuffReader";
        }

        protected override void Write(ContentWriter output, TWrite value)
        {
            output.Write(value.massCount);
            foreach(Objects stuff in value.stuffOnLevel)
            {
                output.Write(stuff.name);
                output.Write(stuff.count);
                foreach(Vector2 vect in stuff.points)
                {
                    output.Write(vect.X);
                    output.Write(vect.Y);
                }
            }
                
        }
    }
}
