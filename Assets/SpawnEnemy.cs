using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    public GameObject[] SpawnPoints;


	// Use this for initialization
	void Start () {
        float number;
	    foreach(GameObject sp in SpawnPoints){
            number = Random.Range(0, 10);
            if (number > 7) {
                Instantiate(Resources.Load("zombie05"), sp.transform.position, sp.transform.localRotation);
            }
        }  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
