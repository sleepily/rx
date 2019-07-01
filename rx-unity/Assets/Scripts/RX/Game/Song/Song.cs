using System.Collections;
using System.Collections.Generic;
using RX.Difficulty;
using Log = RX.LogManager;

namespace RX.Song
{
    [System.Serializable]
    public class Song
    {
        public SongInfo SongInfo;
        public List<DifficultyInfo> DifficultyInfos;

        bool initialized = false;

        public void Play(long time = 0)
        {
            if (!initialized)
                Initialize();
        }

        void Initialize()
        {
            if (DifficultyInfos.Count == 0)
            {
                Log.LogWarning(this, "No Difficulty Present.");
                return;
            }
        }
    }
}