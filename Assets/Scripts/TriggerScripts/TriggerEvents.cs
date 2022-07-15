using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    public bool tredmillAllowTurnOff = false;
    public bool tvAllowTurnOff = false;
    public bool radioAllowTurnOff = false;
    public bool blenderAllowTurnOff = false;
    public bool laptopAllowTurnOff = false;
    public bool ovenAllowTurnOff = false;
    public bool microwaveAllowTurnOff = false; 
    public bool kettleAllowTurnOff = false; 

    public static bool tredmillTurnOff = false;
    public static bool tvTurnOff = false;
    public static bool radioTurnOff = false;
    public static bool blenderTurnOff = false;
    public static bool laptopTurnOff = false;
    public static bool ovenTurnOff = false;
    public static bool microwaveTurnOff = false; 
    public static bool kettleTurnOff = false; 

    public Animator kettleAnim;
    public Animator tvAnim;
    public Animator microwaveAnim;
    public Animator ovenAnim;
    public Animator blenderAnim;
    public Animator laptopAnim;
    public Animator tredmillAnim;
    public Animator radioAnim;

    void Start()
    {
        
    }

    void Update()
    {
        TurnOffDevice();
    }
    void TurnOffDevice()
    {
        if(tredmillAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            tredmillAnim.SetBool("IsOn", true);
            tredmillTurnOff = true;
            tredmillAllowTurnOff = false;
        }
        if(laptopAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            laptopAnim.SetBool("IsOn", true);
            laptopTurnOff = true;
            laptopAllowTurnOff = false;
        }
        if(ovenAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            ovenAnim.SetBool("IsOn", true);
            ovenTurnOff = true;
            ovenAllowTurnOff = false;
        }
        if(tvAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            tvAnim.SetBool("IsOn", true);
           tvTurnOff = true;
           tvAllowTurnOff = false;
        }
        if(microwaveAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            microwaveAnim.SetBool("IsOn", true);
            microwaveTurnOff = true;
            microwaveAllowTurnOff = false;
        }
        if(blenderAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
            blenderAnim.SetBool("IsOn", true);
            blenderTurnOff = true;
            blenderAllowTurnOff = false;
        }
        if(kettleAllowTurnOff == true && Input.GetKey(KeyCode.F))
        {
           kettleAnim.SetBool("IsOn", true);
           kettleTurnOff = true;
           kettleAllowTurnOff = false;
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Tredmill"))
        {
            tredmillAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("Laptop"))
        {
            laptopAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("Oven"))
        {
            ovenAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("TV"))
        {
            tvAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("Microwave"))
        {
            microwaveAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("Blender"))
        {
            blenderAllowTurnOff = true;
        }
        if(col.gameObject.CompareTag("Kettle"))
        {
            kettleAllowTurnOff = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Tredmill"))
        {
            tredmillAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("Laptop"))
        {
            laptopAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("Oven"))
        {
            ovenAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("TV"))
        {
            tvAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("Microwave"))
        {
            microwaveAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("Blender"))
        {
            blenderAllowTurnOff = false;
        }
        if(col.gameObject.CompareTag("Kettle"))
        {
            kettleAllowTurnOff = false;
        }
    }
}
