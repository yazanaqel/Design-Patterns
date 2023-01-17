using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Arc
    {
        public float start { get; set; }
        public float end { get; set; }
        public float center { get; set; }
        public float angle { get; set; }
        public float radius { get; set; }
        public float p1 { get; set; }
        public float p2 { get; set; }
        public float p3 { get; set; }

        public void Draw()
        {
            Console.WriteLine("Example: " + this.start);
        }



    }
}
