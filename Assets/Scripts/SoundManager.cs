using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Singleton class used to reference assets
 * (eg: sound, sprites)
 */
public static class SoundManager
{
    public enum Sound
    {
        ButtonHover,
        ButtonClick,
        SliderShift,
        OpenMenu,
        CloseMenu,

        Fire,
        PlayerMove,

        ExtinguisherFire,
        PickupExtinguisher,
        DropExtinguisher,
        ExtinguisherCollision,
        PinRemove,
        SpoutRemove,
        SpoutPlace,
    }

    private static Dictionary<Sound, float> soundTimerDictionary;

    /**
     * Initialize sound timers and timer collection
     */
    public static void Initialize()
    {
        soundTimerDictionary = new Dictionary<Sound, float>();
        soundTimerDictionary[Sound.PlayerMove] = 0f;
        soundTimerDictionary[Sound.SliderShift] = 0f;
    }

    /**
     * Plays a given sound 
     * (Mono-audio)
     */
    public static void PlaySound(Sound sound)
    {
        if (CanPlaySound(sound))
        {
            GameObject soundGameObject = new GameObject("Sound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(GetAudioClip(sound));
        }
    }

    /**
     * Plays a given sound from position 
     * (3D-audio, stereo)
     */
    public static void PlaySound(Sound sound, Vector3 position)
    {
        if (CanPlaySound(sound))
        {
            GameObject soundGameObject = new GameObject("Sound");
            soundGameObject.transform.position = position;
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.clip = GetAudioClip(sound);
            audioSource.Play();
        }
    }

    /**
     * Checks if given sound has a cooldown between plays
     */
    private static bool CanPlaySound(Sound sound)
    {
        switch (sound)
        {
            default:
                return true;
            case Sound.PlayerMove:
                return CheckSoundTimer(.75f, Sound.PlayerMove);
            case Sound.SliderShift:
                return CheckSoundTimer(0.1f, Sound.SliderShift);
        }
    }

    /**
     * Checks if the time since last sound play exceeds the limit
     */
    private static bool CheckSoundTimer(float limit, Sound sound)
    {
        if (soundTimerDictionary.ContainsKey(sound))
        {
            float lastTimePlayed = soundTimerDictionary[sound];

            if (lastTimePlayed + limit < Time.unscaledTime)
            {
                soundTimerDictionary[sound] = Time.unscaledTime;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
    }

    /**
     * Get audioclip from GameAssets singleton using enum
     */
    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.soundAudioClipArray)
        {
            if (soundAudioClip.sound == sound)
                return soundAudioClip.audioClip;
        }
        Debug.LogError("Sound" + sound + " not found");
        return null;
    }
}
