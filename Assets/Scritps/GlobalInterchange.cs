using UnityEngine;
using System.Collections;

public class GlobalInterchange : MonoBehaviour {

    public  GameObject level00;
    public  GameObject level01;
    public  GameObject level02;
    public  GameObject level03;
    public static int scenes;

	// Use this for initialization
	void Start () {
        if (level01 == null) {
            Debug.LogError("No level 01 found");
            Debug.Break();
        }
        level01.transform.Translate((30 * 15f), 0, 0);
	}

    public static void inc() {
        scenes++;
    }

    public static void nxtLevel(int i) {
        if (i == 1) { 
            
        }
    }

	// Update is called once per frame
	void Update () {
	
	} 
    
   /* public static GameObject getCurrentLevel(){
        if (scenes < 10) {
            return level00;
        }
        else if (scenes < 20)
        {
            return level01;
        }
        else if (scenes < 30)
        {
           // return level02;
            return level00;
        }
        else if (scenes < 40)
        {
            return level03;
        }
        else {
            scenes -= 40;
            return level00;
        }
    }
     */
}
