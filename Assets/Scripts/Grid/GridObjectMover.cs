using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridObject))]
public class GridObjectMover : MonoBehaviour
{
    private GridObject gridObject;
    [SerializeField]
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        gridObject = GetComponent<GridObject>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = Vector2.MoveTowards(transform.position, gridObject.Cell.Position, speed);
        transform.position = v;
    }
}
