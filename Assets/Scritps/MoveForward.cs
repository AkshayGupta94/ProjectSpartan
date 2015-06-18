using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    public GameObject advancer;
    Vector3 start;
    public GameObject zombi05;

	// Use this for initialization
	void Start () {
        if (advancer == null)
            Debug.LogError("Nothing to advance");
        start = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (start != gameObject.transform.position) {
            start = gameObject.transform.position;
            //spawn enemy !!
            Instantiate(zombi05,gameObject.transform.position,gameObject.transform.rotation);
            
        }
	}

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player")
        {
            if (GlobalInterchange.scenes <= 8)
            {
                advancer.transform.Translate(30 * 3, 0, 0);
                GlobalInterchange.inc();
            }
            else
            {
                if (GlobalInterchange.scenes == 11)
                {

                }
                else
                {
                    // GlobalInterchange.nxtLevel(1);
                }
            }
        }
    }
}
