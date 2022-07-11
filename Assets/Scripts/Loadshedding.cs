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

    //lights
    public GameObject lights;
    public GameObject genLights;

    //timer references
    protected float applianceTimer;
    protected float usageTimer;
    protected float globalTimer;
    protected float nightTimer;



    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if(usageTimer >= 500)
        {
            stage01.SetActive(true);
        }
        if(usageTimer >= 1500)
        {
            stage01.SetActive(false);
            stage02.SetActive(true);
        }
        if(usageTimer >= 2000)
        {
            stage02.SetActive(false);
            stage03.SetActive(true);
        }
        if(usageTimer >= 2500)
        {
            stage03.SetActive(false);
            stage04.SetActive(true);
        }
    }
    void TimerReset()
    {
        stage01.SetActive(false);
        stage02.SetActive(false);
        stage03.SetActive(false);
        stage04.SetActive(false);

    }

    void NightSet()
    {
        lights.SetActive(false);
        Invoke("GeneratorStart" , 1f);

        /*if(stage01.SetActive(true))
        {
            nightTimer = 1000;
        }
        if(stage02.SetActive(true))
        {
            nightTimer = 2000;
        }
        if(stage03.SetActive(true))
        {
            nightTimer = 3000;
        }
        if(stage04.SetActive(true))
        {
            nightTimer = 4000;
        }*/
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