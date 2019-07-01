using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RX.Song;

public class Conductor : MonoBehaviour
{
    public Song CurrentSong;

    double startTime;

    public void StartConducting()
    {
        startTime = AudioSettings.dspTime;
    }
}
