using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    protected static SoundManager instance;
    public static SoundManager Instance => instance;
    [SerializeField] public AudioSource themeSource;
    [SerializeField] public AudioSource vfxSource;
    public List<Music> themSources;
    public List<Music> vfxSources;

    protected void Start()
    {
        if (SoundManager.Instance != null)
        {
            Destroy(gameObject); 
            return;
        }

        SoundManager.instance = this;
        DontDestroyOnLoad(transform);
        PlayThemeMusic("Theme1");
    }
    public virtual void PlayThemeMusic(string name)
    {
        foreach(Music music in themSources)
        {
            if(music.name == name)
            {
                themeSource.clip =music.clip;
                themeSource.Play();
            }

        }
    }
    public virtual void PlayVFXMusic(string name)
    {
        foreach (Music music in vfxSources)
        {
            if (music.name == name)
            {
                vfxSource.clip = music.clip;
                vfxSource.Play();
            }

        }
    }








}


