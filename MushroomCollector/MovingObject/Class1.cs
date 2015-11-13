using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovingObject
{
    public class Igrach
    {
        public string ime { set; get; }
        public int poeni { set; get; }
        public int freeze { set; get; }
        public Boolean normal { set; get; }




        public override string ToString()
        {
            if (normal)
            {
                return string.Format("{0} - поени: {1} застанувања: {2} (N)", ime, poeni, freeze);
            }
           
                return string.Format("{0} - поени: {1} застанувања: {2} (A)", ime, poeni, freeze);
            
        }
    }
}
