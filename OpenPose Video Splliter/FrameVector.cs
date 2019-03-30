using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPose_Video_Splliter {
    class FrameVector {
        public int start { get; set; }
        public int end { get; set; }


        public FrameVector(int start , int end) {
            this.start = start;
            this.end = end;
            
        }

        public override string ToString() {
          




            string output = String.Format("{0,-6}| {1,-6}" ,
                start.ToString() , end.ToString());

            return output;

        }

    }
}
