using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject petrolCan;
    public GameObject eskomApp;

    public Animator playerAnim;

    public Slider scareBar;

    public static float speed = 3;

    public bool appActive;

    void Start()
    {
        appActive = false;
    }
    void FixedUpdate()
    {
        Move();
        
        
    }
    void Update()
    {
        Info();
        MovementStop();
    }

    void Move()
    {
         if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            playerAnim.SetBool("WPressed", true);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            playerAnim.SetBool("SPressed", true);
        }
        
        
    }
    void MovementStop()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("WPressed", false);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("SPressed", false);
        }
        
    }

    void OnColliderEnter2D(Collider2D col)
    {
        
    }

    void Info()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(appActive == false)
            {
                eskomApp.SetActive(true);
                appActive = true;
                //time.TimeScale = 0f;
            }
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            if(appActive == true)
            {
                eskomApp.SetActive(false);
                appActive = false;
            } 
        } 
    }

}