using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource happysound;
    public AudioSource notgoodsound;

    public MoodData moodData;

    private bool isFadingOut = false;
    private float fadeOutDuration = 1.0f; // You can adjust the fade out duration

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moodData.CurrentMoodPoints == 5)
        {
            FadeOut(notgoodsound);
            FadeIn(happysound);
        }
        else if (moodData.CurrentMoodPoints <= 4)
        {
            FadeOut(happysound);
            FadeIn(notgoodsound);
        }
    }

    void FadeOut(AudioSource audioSource)
    {
        if (audioSource.enabled && !isFadingOut)
        {
            StartCoroutine(FadeOutCoroutine(audioSource));
        }
    }

    void FadeIn(AudioSource audioSource)
    {
        if (!audioSource.enabled)
        {
            audioSource.enabled = true;
            audioSource.volume = 0.05f; // Reset volume to 1 before fading in
        }
    }

    IEnumerator FadeOutCoroutine(AudioSource audioSource)
    {
        isFadingOut = true;

        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeOutDuration;
            yield return null;
        }

        audioSource.enabled = false; // Disable the AudioSource when the volume reaches 0
        isFadingOut = false;
    }
}
