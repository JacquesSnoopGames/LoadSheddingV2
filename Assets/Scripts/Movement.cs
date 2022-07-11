using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject petrolCan;

    public Animator playerAnim;

    public Slider scareBar;

    public float speed = 10;

    void FixedUpdate()
    {
        Move();
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
        if(Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("WPressed", false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            playerAnim.SetBool("SPressed", true);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("SPressed", false);
        }
        
    }
    void MovementStop()
    {
        
        
    }

    void OnColliderEnter2D(Collider2D col)
    {
        
    }
}