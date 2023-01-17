//مثال لطريقة رسم قوس باكثر من وسيلة
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ArcBuilder arcbuilder = new ArcBuilder();

            var obj = arcbuilder.StartCenterEnd(2F, 4F, 8F).Build();

            obj.Draw();
           
            
        }
    }
}
