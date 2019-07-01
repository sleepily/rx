using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : RXManager
{
    [HideInInspector]
    public static GameManager Instance;

    [HideInInspector]
    public Conductor Conductor;

    [HideInInspector]
    public PlaytestManager PlaytestManager;

    private void Awake()
    {
        MakeGlobal();
    }

    void MakeGlobal()
    {
        Instance = Instance ?? this;
    }

    protected override void StartFunctions()
    {
        base.StartFunctions();

        PlaytestManager.StartPlaytest();
    }

    protected override void GetComponents()
    {
        Conductor = Conductor ?? GetComponentInChildren<Conductor>();
        PlaytestManager = PlaytestManager ?? GetComponentInChildren<PlaytestManager>();
    }
}
