using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu (fileName = "New Dice", menuName = "Dice")]
public class DiceVariant : ScriptableObject
{
    public new string name;
    public string description;
    public int value;

    public Sprite iconSprite;

    public Sprite[] faceSprites;
    public ScriptableObject[] actions;

    public Type diceType;
    public enum Type
    {
        FIRE,
        WATER,
        ICE,
        EARTH,
        LIGHTNING,
        NATURE,
    }
}
