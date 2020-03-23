using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask ground;
    Rigidbody2D rb;
    Vector2 force;
    public Text fuel;
    public float myFuel = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fuel.text = myFuel.ToString("N1");
    }

    // Update is called once per frame
    void Update()
    {
        force = Vector2.zero;
        if (myFuel >= 0.0)
        {

            if (Input.GetKey(KeyCode.D))
            {
                force.x = -1;
                myFuel -= 1f * Time.deltaTime;
                fuel.text = myFuel.ToString("N1");

            }
            else if (Input.GetKey(KeyCode.A))
            {
                force.x = 1;
                myFuel -= 1f * Time.deltaTime;
                fuel.text = myFuel.ToString("N1");
            }
            else if (Input.GetKey(KeyCode.S))
            {

                force.y = 1;
                myFuel -= 1f * Time.deltaTime;
                fuel.text = myFuel.ToString("N1");
            }
        }
        

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Fail")
            
        {
            SceneManager.LoadScene("FailedScene");
        }
        if (collision.gameObject.tag == "Land")
        {
            SceneManager.LoadScene("WinScene");

        }
    }



    private void FixedUpdate()
    {
   

        rb.AddForce(force);
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -1, 1), Mathf.Clamp(rb.velocity.y, -1, 1));
    }


}
