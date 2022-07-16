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
        if (Grid.InGrid(GX + dx, GY + dy))
        {
            Cell = Grid.GetCell(GX + dx, GY + dy);
        }
    }
}
