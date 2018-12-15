using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPose_Video_Splliter {
    class OpenPoseSetting {
        public bool NoBlending { get; set; }
        public bool NoWindow { get; set; }
        public int KeyPointScaleMode { get; set; }
        public int NumberPeopleMax { get; set; }
        //생성자
        public OpenPoseSetting() {
            KeyPointScaleMode = 0; //이미지 스케일을 원본 이미지의[W,H]로 
            NumberPeopleMax = 1; //한명만 감지 
        }
    }
}
