using UnityEngine;
using System.Collections;

public class Regenerate : MonoBehaviour {

    public GameObject startPoint;

	// Use this for initialization
	void Start () {
        if (startPoint == null)
        {
            Debug.LogError("No startpoint for other map set");
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            string stage = GlobalInterchange.nxtLevel();
            if (stage == null)
                Debug.LogError("nxtLevel just returned 0 !!");
            Instantiate(Resources.Load(stage), startPoint.transform.position, startPoint.transform.localRotation);
            GlobalInterchange.inc();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        print(other.gameObject.tag + " exited");
        if (other.gameObject.tag == "enemy") {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            GameObject go = gameObject;
            while (go.tag != "Environment")
                go = go.transform.parent.gameObject;
            Destroy(go);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
