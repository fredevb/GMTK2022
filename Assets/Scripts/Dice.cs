using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField]
    private List<IMove> moves = new List<IMove>();
    public List<IMove> Moves {get {return moves;}}

    public IMove Roll()
    {
        return Moves[Random.Range(0, Moves.Count)];
    }
}
