using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Main {get; set;}
    [SerializeField]
    private PlayerDiceRoller[] diceRollers;

    public PlayerDiceRoller SelectedDiceRoller{get; set;}
    // Start is called before the first frame update

    public GameAction[] ActionSequence {get; private set;}

    void Awake()
    {
        if (Main == null)
            Main = this;
        else
            Debug.LogError("There can only be one game controller");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            RollAll();
        
    }

    public void RollAll()
    {
        foreach (var dr in diceRollers)
        {
            dr.Roll();
        }
    }
}
