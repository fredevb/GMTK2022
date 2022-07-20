using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{

    public static GameGrid Main {get; private set;}
    [SerializeField]
    private int gridSizeX = 10, gridSizeY = 10;

    [SerializeField]
    private float spacing = 1;

    public int GridSizeX {get {return gridSizeX;}}
    public int GridSizeY {get {return gridSizeY;}}

    private GridCell[,] cells;

    [SerializeField]
    private GameObject TileTemplate;

    public void Awake()
    {
        if (Main == null)
            Main = this;
        else
            Debug.LogError("There can only be one game grid.");
        cells = Generate(GridSizeX, GridSizeY);
        PopulateCells(cells);
    }

    public GridCell[,] Generate(int n, int m)
    {
        GridCell[,] ret = new GridCell[n,m];
        for (int x = 0; x < n; x++){
            for (int y = 0; y < m; y++)
            {
                var pos = (new Vector2(x + 0.5f, y + 0.5f)) * spacing + (Vector2)transform.position - (new Vector2(n,m)*spacing/2f);
                ret[x,y] = new GridCell(this, x, y, pos);
            }
        }
        return ret;
    }

    public void OnDrawGizmos()
    {
        cells = Generate(GridSizeX, GridSizeY);
        foreach (var c in cells)
        {
            Gizmos.DrawCube(c.Position, Vector3.one/2f * spacing);
        }
    }

    public bool InGrid(int x, int y)
    {
        return 0 <= x && x < GridSizeX && 0 <= y && y < GridSizeY;
    }

    public GridCell GetCell(int x, int y)
    {
        return cells[x,y];
    }

    private void PopulateCells(GridCell[,] grid)
    {
        foreach (var c in grid)
        {
            c.Tile = Instantiate(TileTemplate, (Vector3)c.Position, Quaternion.identity, transform);
        }
    }
}
