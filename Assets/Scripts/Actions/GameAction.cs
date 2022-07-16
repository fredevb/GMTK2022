using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameAction : MonoBehaviour
{
    [SerializeField]
    private Sprite icon;
    public Sprite Icon {get{return icon;}}
    public abstract void Go(Entity e);
}
