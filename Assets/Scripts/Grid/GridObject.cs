using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{
    public GameGrid Grid {get {return Cell.Grid;}}
    public GridCell Cell {get; private set;}
    public int GX {get {return Cell.GX;}}
    public int GY {get {return Cell.GY;}}

    public void Start()
    {
        Cell = GameGrid.Main.GetCell(0,0);
    }

    public void Move(int dx, int dy)
    {
        MoveTo(GX + dx, GY + dy);
    }

    public void MoveTo(int x, int y)
    {
        if (Grid.InGrid(x, y))
        {
            Cell = Grid.GetCell(x, y);
        }
    }
}
