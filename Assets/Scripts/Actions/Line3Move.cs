using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Line3Move : MoveSequence
{
    public override IEnumerable<Tuple<int, int>> GetPattern()
    {
        Tuple<int,int>[] ret = {
            new Tuple<int, int>(0,1),
            new Tuple<int, int>(0,2),
            new Tuple<int, int>(0,3)
            };
        return ret;
    }
}
