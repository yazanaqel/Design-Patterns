using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ArcBuilder
    {
        Arc arc = new Arc();

        //public ArcBuilder() { }
        public ArcBuilder StartCenterEnd(float start, float center, float end)
        {
            arc.start = start;
            arc.center = center;
            arc.end = end;
            return this;
        }
        public ArcBuilder StartCenterAngle(float start, float center, float angle)
        {
            arc.start = start;
            arc.center = center;
            arc.angle = angle;
            return this;
        }
        public ArcBuilder StartCenterRadius(float start, float center, float radius)
        {
            arc.start = start;
            arc.center = center;
            arc.radius = radius;
            return this;
        }
        public ArcBuilder P1_P2_P3(float p1, float p2, float p3)
        {
            arc.p1 = p1;
            arc.p2 = p2;
            arc.p3 = p3;
            return this;
        }


        public Arc Build()
        {
            return arc;
        }
    }
}
