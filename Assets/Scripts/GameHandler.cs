using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Handles core gameploop logic 
 */
public class GameHandler : MonoBehaviour
{
    private void Awake()
    {
        SoundManager.Initialize();
    }
}
