using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game : MonoBehaviour
{
    public static Game Instance {get; private set;}

    [SerializeField]
    private GameGrid grid;
    public GameGrid Grid {get {return grid;}}

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            throw new ArgumentException("There can only be one game instance.");
    }
}
