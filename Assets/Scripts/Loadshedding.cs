using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Loadshedding : MonoBehaviour
{
    //stage icons
    public GameObject stage01;
    public GameObject stage02;
    public GameObject stage03;
    public GameObject stage04;
    public GameObject stage05;
    public GameObject stage07;
    public GameObject stage10;

    //lights
    public GameObject lights;
    public GameObject genLights;

    //timer references
    protected float applianceTimer;
    protected float usageTimer;
    protected float globalTimer;
    protected float nightTimer;

    public bool stage01Active;
    public bool stage02Active;
    public bool stage03Active;
    public bool stage04Active;
    public bool stage05Active;
    public bool stage07Active;
    public bool stage10Active;

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if(usageTimer >= 500)
        {
            stage01.SetActive(true);
            stage01Active = true;
        }
        if(usageTimer >= 1500)
        {
            stage01Active = false;
            stage01.SetActive(false);
            stage02.SetActive(true);
            stage02Active = true;
        }
        if(usageTimer >= 2000)
        {
            stage02.SetActive(false);
            stage03.SetActive(true);
            stage02Active = false;
            stage03Active = true;
        }
        if(usageTimer >= 2500)
        {
            stage03.SetActive(false);
            stage04.SetActive(true);
            stage03Active = false;
            stage04Active = true;
        }
        if(usageTimer >= 3000)
        {
            stage04.SetActive(false);
            stage05.SetActive(true);
            stage04Active = false;
            stage05Active = true;
        }
        if(usageTimer >= 3500)
        {
            stage05.SetActive(false);
            stage07.SetActive(true);
            stage05Active = false;
            stage07Active = true;
        }
        if(usageTimer >= 4000)
        {
            stage07.SetActive(false);
            stage10.SetActive(true);
            stage07Active = false;
            stage10Active = true;
        }

    }
    void TimerReset()
    {
        stage01.SetActive(false);
        stage02.SetActive(false);
        stage03.SetActive(false);
        stage04.SetActive(false);
        stage05.SetActive(false);
        stage07.SetActive(false);
        stage10.SetActive(false);
    }

    void NightSet()
    {
        lights.SetActive(false);
        Invoke("GeneratorStart" , 1f);

        if(stage01Active == true)
        {
            nightTimer = 1000;
        }
        if(stage02Active == true)
        {
            nightTimer = 2000;
        }
        if(stage03Active == true)
        {
            nightTimer = 3000;
        }
        if(stage04Active == true)
        {
            nightTimer = 4000;
        }
        if(stage05Active == true)
        {
            nightTimer = 5000;
        }
        if(stage07Active == true)
        {
            nightTimer = 6000;
        }
        if(stage10Active == true)
        {
            nightTimer = 7000;
        }
    }
    
    void GeneratorStart()
    { 
        genLights.SetActive(true);
        nightTimer--;
    }

    void GeneratorOff()
    {
        if(nightTimer == 0)
        {
            genLights.SetActive(false);
            lights.SetActive(true);
        }
        
    }
    
    


}