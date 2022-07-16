using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridObject))]
public class Entity : MonoBehaviour
{
    public GridObject GridObject {get; private set;}
    // Start is called before the first frame update
    void Awake()
    {
        GridObject = GetComponent<GridObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
