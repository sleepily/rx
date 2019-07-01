using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RX.Song
{
    [CreateAssetMenu(fileName = "New Song", menuName = "RX/Song/Song")]
    public class SongInfo : ScriptableObject
    {
        public string Title, TitleRomanized;
        public string Artist, ArtistRomanized;

        public string Creator;

        public string AudioFileName = "audio.mp3";
        public AudioClip AudioFile;
    }
}
