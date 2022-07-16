using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTester : MonoBehaviour
{
    private GridObject gridObject;
    // Start is called before the first frame update
    void Start()
    {
        gridObject = GetComponent<GridObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            gridObject.Move(0,1);

        if (Input.GetKeyDown(KeyCode.A))
            gridObject.Move(-1,0);

        if (Input.GetKeyDown(KeyCode.S))
            gridObject.Move(0,-1);

        if (Input.GetKeyDown(KeyCode.D))
            gridObject.Move(1,0);

    }
}
