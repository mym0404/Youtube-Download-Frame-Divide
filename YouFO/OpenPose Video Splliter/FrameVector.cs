using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPose_Video_Splliter {
    class FrameVector {
        public int start { get; set; }
        public int end { get; set; }
        public bool isFront { get; set; }
        public bool isLeft { get; set; }

        public FrameVector(int start , int end,bool isFront,bool isLeft) {
            this.start = start;
            this.end = end;
            this.isFront = isFront;

            if (isFront == false)
                this.isLeft = isLeft;
            else
                this.isLeft = false;
        }

        public override string ToString() {
            string front, side="";

            if (this.isFront)
                front = "F";
            else {
                front = "S";

                if (this.isLeft)
                    side = "L";
                else
                    side = "R";
            }


            string output = String.Format("{0,-6}| {1,-6} |{2,-2} |{3,-2}" ,
                start.ToString() , end.ToString() , front , side);

            return output;

        }

    }
}
