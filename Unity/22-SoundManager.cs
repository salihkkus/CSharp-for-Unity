using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip backgroundMusic;
    public AudioClip buttonClickSound;
    public AudioClip jumpSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlayButtonClick()
    {
        PlaySFX(buttonClickSound);
    }

    public void PlayJump()
    {
        PlaySFX(jumpSound);
    }

    public void MuteAll(bool mute)
    {
        musicSource.mute = mute;
        sfxSource.mute = mute;
    }
}
