using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField]
    private GameAction[] actions;
    public GameAction[] Actions {get{return actions;}}
    public GameAction CurrentRoll {get {return actions[RollID];}}

    public int RollID {get; private set;}
    public void Roll()
    {        
        RollID = Random.Range(0, actions.Length);
    }

}
