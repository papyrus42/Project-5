using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;

using TInput = System.String;
using TOutput = ClassLibrary.ObjectsOnLevel;

namespace Class_Extensions
{
    [ContentProcessor(DisplayName = "Stuff Processor")]
    public class StuffProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(string input, ContentProcessorContext context)
        {
            
        }
    }
}
