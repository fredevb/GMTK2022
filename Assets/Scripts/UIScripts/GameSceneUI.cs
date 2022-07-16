using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneUI : MonoBehaviour
{
    public void ChangeScene()
    {
        Loader.Load(Loader.Scene.GameScene);
    }
}
