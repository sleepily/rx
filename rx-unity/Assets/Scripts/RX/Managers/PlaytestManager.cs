using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RX.Song;
using Log = RX.LogManager;

public class PlaytestManager : RXManager
{
    public Song PlaytestSong;

    public void StartPlaytest()
    {
        Log.Log(this, "Starting Playtest.");

        if (!PlaytestSong.SongInfo)
        {
            Log.LogError(this, $"Song {PlaytestSong.ToString()} doesn't provide SongInfo!");
            return;
        }

        GameManager.Instance.Conductor.CurrentSong = PlaytestSong;
        GameManager.Instance.Conductor.CurrentSong.Play(0);
    }
}
