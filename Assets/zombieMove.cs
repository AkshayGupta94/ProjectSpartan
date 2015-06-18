using UnityEngine;
using System.Collections;

public class zombieMove : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
}
