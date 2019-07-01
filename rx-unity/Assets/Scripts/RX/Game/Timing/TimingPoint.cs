using System.Collections;
using System.Collections.Generic;

namespace RX.Timing
{
    [System.Serializable]
    public class TimingPoint
    {
        public long Time;
        public float BPM;
        public int Numerator;
        public int Denominator;
    }
}