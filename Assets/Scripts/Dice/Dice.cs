using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Dice : MonoBehaviour
{
    [SerializeField]
    private GameAction[] actions;
    public GameAction[] Actions {get{return actions;}}
    public GameAction RolledAction {get {return actions[RollID];}}

    public int RollID {get; private set;}

    private Health health;
    public Health Health {get{return health;}}

    public delegate void OnRollDelegate();
    public OnRollDelegate OnRoll;

    public void Start(){
        health = GetComponent<Health>();
    }
    public void Roll()
    {        
        RollID = Random.Range(0, actions.Length);
        OnRoll?.Invoke();
    }

}
