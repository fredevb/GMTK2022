using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        GameScene,
        MainMenu,
        TestScene,
    }

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
