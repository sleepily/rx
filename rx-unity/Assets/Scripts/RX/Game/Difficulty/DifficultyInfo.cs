using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RX.Timing;

namespace RX.Difficulty
{
    [CreateAssetMenu(fileName = "New Difficulty", menuName = "RX/Song/Difficulty")]
    public class DifficultyInfo : ScriptableObject
    {
        public List<TimingPoint> timingPoints;
    }
}