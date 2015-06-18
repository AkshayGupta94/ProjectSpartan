using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {

    private Animator anim;
    // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerStart2D(Collider2D col) {
        print("haha");
        if (col.gameObject.tag == "enemy") {
            print("lol");
            anim.SetBool("die",true);
        }
    }

}
