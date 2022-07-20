using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class MoveSequence : GameAction
{
    [SerializeField]
    private int[][] moves;
    public override void Go(Entity e)
    {
        foreach (var t in GetMoves(e))
        {
            var dx = t.Item1;
            var dy = t.Item2;
            var g = e.GridObject;
            g.Move(dx, dy);
        }
        
    }
    
    private IEnumerable<Tuple<int, int>> GetMoves(Entity e)
    {
        var ret = new List<Tuple<int, int>>();
        foreach (var t in GetPattern()){
            var dx = t.Item1;
            var dy = t.Item2;
            var g = e.GridObject;
            if (g.Grid.InGrid(g.GX + dx, g.GY + dy))
                ret.Add(t);
            else
                break;
        }
        return ret;
    }

    public abstract IEnumerable<Tuple<int, int>> GetPattern();

}
