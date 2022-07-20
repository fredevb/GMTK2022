using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicMove : MoveSequence
{

    [SerializeField]
    private int count = 1;
    [SerializeField]
    private int xStep, yStep;

    public override IEnumerable<Tuple<int, int>> GetPattern()
    {
        var ret = new Tuple<int,int>[count];
        for (int i = 0; i < count; i++)
            ret[i] = new Tuple<int,int>(xStep*(i+1),yStep*(i+1));
        
        return ret;
    }
}
