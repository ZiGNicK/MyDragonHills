using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {

    public AudioMixer m_AudioMixer;
    public GameObject m_MusicOff;
    public GameObject m_SoundOff;
    public GameObject m_FPSOff;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("ShowFPS") == 1)
        {
            m_FPSOff.SetActive(false);
        }
        else
        {
            m_FPSOff.SetActive(true);
        }
    }

    public void SetMusicVolume()
    {
        float volume;
        m_AudioMixer.GetFloat("MusicVolume", out volume);

        if (volume > -70)
        {
            m_AudioMixer.SetFloat("MusicVolume", volume - 20);
            if (volume - 20 < -70)
            {
                m_MusicOff.SetActive(true);
            }
        }
        else
        {
            m_AudioMixer.SetFloat("MusicVolume", 0);
            m_MusicOff.SetActive(false);
        }
        
    }

    public void SetSoundVolume()
    {
        float volume;
        m_AudioMixer.GetFloat("SoundVolume", out volume);

        if (volume > -70)
        {
            m_AudioMixer.SetFloat("SoundVolume", volume - 20);
            if (volume - 20 < -70)
            {
                m_SoundOff.SetActive(true);
            }
        }
        else
        {
            m_AudioMixer.SetFloat("SoundVolume", 0);
            m_SoundOff.SetActive(false);
        }

    }

    public void SetFPS()
    {
        if (PlayerPrefs.GetInt("ShowFPS") == 0)
        {
            PlayerPrefs.SetInt("ShowFPS", 1);
            m_FPSOff.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("ShowFPS", 0);
            m_FPSOff.SetActive(true);
        }
    }

}
