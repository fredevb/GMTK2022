using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Singleton class used to reference assets
 * (eg: sound, sprites)
 */
public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    /**
     * Create singleton GameAssets object if does not exist
     */
    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }

    // Sound Clips
    public SoundAudioClip[] soundAudioClipArray;

    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }

    // Sprites
    // (to be added)

    // Prefabs/Particle effects
    // (to be added)
}
