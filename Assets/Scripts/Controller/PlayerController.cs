using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Entity player;

    public Entity Player {get {return player;}}
    // Start is called before the first frame update

    void Start()
    {
        RollAll();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //    RollAll();
        
        KeyCode[] diceKeys = {KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5};
        var m = false;
        for (int i = 0; i < Math.Min(Player.Die.Count, diceKeys.Length); i++)
        {
            if (Input.GetKeyDown(diceKeys[i])){
                Player.UseDice(Player.Die[i]);
                m = true;
            }
        }
        if (m)
            RollAll();

    }

    public void RollAll()
    {
        foreach (var d in Player.Die)
        {
            d.Roll();
        }
    }
}
