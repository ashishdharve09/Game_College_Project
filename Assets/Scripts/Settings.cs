using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle fullscreenToggle;
    private float currentVolume;

    void Start()
    {
        currentVolume = PlayerPrefs.GetFloat("Volume", 1.0f);
        AudioListener.volume = currentVolume;
        volumeSlider.value = currentVolume;

        bool isFullscreen = PlayerPrefs.GetInt("Fullscreen", 1) == 1 ? true : false;
        Screen.fullScreen = isFullscreen;
        fullscreenToggle.isOn = isFullscreen;
    }

    public void SetVolume(float volume)
    {
        currentVolume = volume;
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("Fullscreen", isFullscreen ? 1 : 0);
    }

    public void ResetSettings()
    {

        SetVolume(1.0f);
        SetFullscreen(true);

        volumeSlider.value = 1.0f;
        fullscreenToggle.isOn = true;
    }
}