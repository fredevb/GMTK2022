using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell
{
    public GameGrid Grid {get; private set;}
    public int GX {get; private set;}
    public int GY {get; private set;}

    public Vector2 Position {get; set;}

    public GridCell(GameGrid grid, int gx, int gy, Vector2 position)
    {
        Grid = grid;
        GX = gx;
        GY = gy;
        Position = position;
    }
}
