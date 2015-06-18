using UnityEngine;
using System.Collections;

public class movingfor : MonoBehaviour {

    public GameObject gm;
    Vector3 start;
    public GameObject zombi05;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (start != gameObject.transform.position)
        {
            start = gameObject.transform.position;
            //spawn enemy !!
            Instantiate(zombi05, gameObject.transform.position, gameObject.transform.rotation);

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if(col.tag=="Player")
        {

            if (GlobalInterchange.scenes <= 8)
            {

                // gm.transform.position.x = gm.transform.position.x + 90;
                gm.transform.Translate(90, 0, 0);
                GlobalInterchange.inc();
            }
            
        }

    }
}
