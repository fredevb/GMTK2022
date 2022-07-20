using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(GridObject))]
public class Entity : MonoBehaviour
{
    public GridObject GridObject {get; private set;}

    [SerializeField]
    private List<Dice> die;
    public List<Dice> Die {get{return die;} private set{die = value;}}
    void Awake()
    {
        GridObject = GetComponent<GridObject>();
    }

    void RollDie()
    {
        foreach (var d in Die)
            d.Roll();
    }

    public void UseDice(Dice dice)
    {
        if (!Die.Contains(dice))
            throw new ArgumentException("Dice not owned by entity.");
        dice.RolledAction.Go(this);
    }

    void AddDice(Dice dice)
    {
        Die.Add(dice);
        dice.Health.OnDeath += () => RemoveDice(dice);
    }
    void RemoveDice(Dice dice)
    {
        Die.Remove(dice);
        dice.Health.OnDeath -= () => RemoveDice(dice);
    }
}
