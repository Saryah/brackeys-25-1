using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public static Options instance;
    [SerializeField] Slider masterSlider, bgmSlider, sfxSlider;
    [SerializeField] AudioMixer masterMixer;
    float masterVolume, musicVolume, sfxVolume;

    void Awake()
    {
        if(instance != null)
            Destroy(instance);
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        masterMixer.SetFloat("Master", masterVolume);
        masterMixer.SetFloat("BG", musicVolume);
        masterMixer.SetFloat("Sfx", sfxVolume);
    }

    public void IncreaseMasterVolume()
    {
        if (masterSlider.value >= 0)
            return;
        masterSlider.value += 10;
        masterMixer.SetFloat("Master", masterSlider.value);
    }
    public void DecreaseMasterVolume()
    {
        if (masterSlider.value <= -80)
            return;
        masterSlider.value -= 10;
        masterMixer.SetFloat("Master", masterSlider.value);
    }
    public void IncreaseBGMVolume()
    {
        if (bgmSlider.value >= 0)
            return;
        bgmSlider.value += 10;
        masterMixer.SetFloat("BG", bgmSlider.value);
    }
    public void DecreaseBGMVolume()
    {
        if (bgmSlider.value <= -80)
            return;
        bgmSlider.value -= 10;
        masterMixer.SetFloat("BG", bgmSlider.value);
    }
    public void IncreaseSFXVolume()
    {
        if (sfxSlider.value >= 0)
            return;
        sfxSlider.value += 10;
        masterMixer.SetFloat("SFX", sfxSlider.value);
    }
    public void DecreaseSFXVolume()
    {
        if (sfxSlider.value <= -80)
            return;
        sfxSlider.value -= 10;
        masterMixer.SetFloat("SFX", sfxSlider.value);
    }

    void UpdateUI()
    {
        
    }
}
