using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
 * Controls volume with slider component
 */
public class VolumeHandler : MonoBehaviour
{
    public Slider slider;
    [SerializeField] private TMP_Text text;

    /**
     * Change volume and save changes based on slider value
     */
    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        ChangeVolumeString();
        Save();
    }

    /**
     * Alter string that contains volume number
     */
    private void ChangeVolumeString()
    {
        text.text = Mathf.Clamp(Mathf.FloorToInt(slider.value * 100), 0, 100).ToString();
    }

    /**
     * Save and load the player-set volume
     */
    private void Load()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", slider.value);
    }

    /**
     * Create new saved entry for volume if previous
     * instance does not exist
     */
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else
        {
            Load();
        }
        ChangeVolumeString();
    }
}
