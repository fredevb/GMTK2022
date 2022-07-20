using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Action", menuName = "Action")]
public class MoveVariant : ScriptableObject
{
    public new string name;

    public Vector2[] moves;

    // if the AOE effect is different from the movement
    public bool AlternateAOE;
    public Vector2[] AOE;
}
