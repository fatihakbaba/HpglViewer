using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hpgl.Instructions
{
    public class Label : IInstruction
    {
        private Label()
        {

        }

        public static IEnumerable<IInstruction> Matches(string text)
        {
            if (text.StartsWith("LB") )
                yield return new Label();
        }
    }
}
