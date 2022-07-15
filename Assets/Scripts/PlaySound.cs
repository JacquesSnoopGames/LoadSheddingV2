using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{
    public AudioSource voiceNoteOne;
    public AudioSource voiceNoteTwo;
    public AudioSource voiceNoteThree;
    public AudioSource voiceNoteFour;

    public Slider voicenoteDur01;
    public Slider voicenoteDur02;
    public Slider voicenoteDur03;
    public Slider voicenoteDur04;

    public bool voicenote01;
    public bool voicenote02;
    public bool voicenote03;
    public bool voicenote04;

    public int targetFrameRate = 60;

    void Update()
    {
        if(voicenote01 == true)
        {
            voicenoteDur01.value ++;
            if(voicenoteDur01.value == 1100)
            {
                voicenote01 = false;
                voicenoteDur01.value = 0;
            }
        }
        if(voicenote02 == true)
        {
            voicenoteDur02.value ++;
            if(voicenoteDur02.value == 800)
            {
                voicenote02 = false;
                voicenoteDur02.value = 0;
            }
        }
        if(voicenote03 == true)
        {
            voicenoteDur03.value ++;
            if(voicenoteDur03.value == 2100)
            {
                voicenote03 = false;
                voicenoteDur03.value = 0;
            }
        }
        if(voicenote04 == true)
        {
            voicenoteDur04.value ++;
            if(voicenoteDur04.value == 1000)
            {
                voicenote04 = false;
                voicenoteDur04.value = 0;
            }
        }
    }
    void Start()
    {
        
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;

        voicenote01 = false;
        voicenote02 = false;
        voicenote03 = false;
        voicenote04 = false;

        voicenoteDur01.value = 0f;
        voicenoteDur02.value = 0f;
        voicenoteDur03.value = 0f;
        voicenoteDur04.value = 0f;
        
    }
    public void playVoiceNoteOne()
    {
        voiceNoteOne.Play();
        voicenote01 = true;
    }

    public void playVoiceNoteTwo()
    {
        voiceNoteTwo.Play();
        voicenote02 = true;
    }

    public void playVoiceNoteThree()
    {
        voiceNoteThree.Play();
        voicenote03 = true;
    }

    public void playVoiceNoteFour()
    {
        voiceNoteFour.Play();
        voicenote04 = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
