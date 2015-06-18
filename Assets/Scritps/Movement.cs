using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public bool jump = false;	
	public float jumpForce = 10.5f;	
    float speed;
    public GameObject camera;
    public float readyGo;
    private bool grounded = false;
    float preX; 
    int count = 0;

    private Animator anim;
    //  public GameObject floor;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        speed = 0.15f;
        preX = 0;
        //inAir = true;
    }

    public void setSpeed(float speed) {
        this.speed = speed;
    }

    public void setCam(GameObject cam) {
        Debug.Log("setting camera variable");   
        camera = cam;
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="enemy")
        {
            anim.SetTrigger("die");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (camera == null)
        {
            Debug.LogError("No camera to track me");
            Debug.Break();
        }
        gameObject.transform.Translate(speed, 0f, 0f);
        camera.transform.Translate(speed, 0f, 0f);
        
        //float x = gameObject.transform.position.x;
        //float y = gameObject.transform.position.y;
        //float z = gameObject.transform.position.z;
        //if (y < -2) { inAir = false; }
        //else inAir = true;
        //if (Input.GetButton("Fire1"))
        //{ transform.Translate(0, 15 * Time.deltaTime, 0); }
        if (Input.GetButton("Fire2")) {
            anim.SetTrigger("Firing");
        }
        if (Input.GetButton("Fire1"))
        {
            Jump();
        }
        //  print(y.ToString() + "  " + inAir.ToString());
        //    floor.transform.Translate(speed, 0f, 0f);

    }
    public void Jump()
	{
        
			// If the jump button is pressed and the player is grounded and the character is running forward then the player should jump.
			if(grounded == true)
            {
				jump = true;
				grounded = false;
				//We trigger the Jump animation state
				anim.SetTrigger("jumping");
			}
		


	}
    void FixedUpdate()
    {
        if (jump == true)
        {
            // Add a vertical force to the player.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
           
            // We set the variable to false again to avoid adding force constantly
            jump = false;
        }

    //void jumpup(int i)
    //{
    //    count++;
    //    readyGo = Time.time;
    //    float angle;
    //    float degree;
    //    axis = gameObject;
    //    // print("Value of air " + inAir);
    //    //if (inAir)
    //    //    return;
    //    if (i == 1)
    //    {
    //        transform.Translate(0, 15 * Time.deltaTime, 0);
    //        // inAir = true;
    //        /*
    //        degree = 180;
    //        angle = Mathf.LerpAngle(axis.transform.rotation.z, degree, Time.deltaTime);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, degree), Time.deltaTime);

    //        lasty = gameObject.transform.position.y;
    //    }
    //    else if ((i == 2)&&inAir)
    //    {
    //        transform.Translate(0, 20 * Time.deltaTime, 0);

    //        degree = -179;
    //        angle = Mathf.LerpAngle(axis.transform.rotation.z, degree, Time.deltaTime);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, degree), Time.deltaTime);

    //        lasty = gameObject.transform.position.y;
    //         */

    //    }
    }
}
