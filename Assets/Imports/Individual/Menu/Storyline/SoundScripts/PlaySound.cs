using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour
{
    public AudioSource voiceNoteOne;
    public AudioSource voiceNoteTwo;

    public AudioSource voiceNoteThree;

    public AudioSource voiceNoteFour;

    public void playVoiceNoteOne()
    {
        voiceNoteOne.Play();
    }

    public void playVoiceNoteTwo()
    {
        voiceNoteTwo.Play();
    }

    public void playVoiceNoteThree()
    {
        voiceNoteThree.Play();
    }

    public void playVoiceNoteFour()
    {
        voiceNoteFour.Play();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
