using UnityEngine;
using System.Collections;

public class GlobalInterchange : MonoBehaviour {

    public GameObject stage01;
    public GameObject stage02;
    public GameObject stage03;
    public GameObject stage04;
    public GameObject protagist;

    public GameObject startPoint;

    public GameObject mainCamera;

    public static int scenes;

	// Use this for initialization
    void Start()
    {
        if (mainCamera == null)
        {
            Debug.LogError("No Camera found");
        }
        if (protagist == null)
        {
            Debug.LogError("No Hero found");
        }

        Instantiate(Resources.Load("Stage01"), Vector3.zero, Quaternion.identity);
        if (startPoint == null)
        {
            Debug.LogError("No Startpoint found");
        }
        else
        {
            if ((protagist == null) || (mainCamera == null))
                return;
            Debug.Log("Creating hero");
            GameObject hero = Instantiate(protagist,startPoint.transform.localPosition,startPoint.transform.localRotation) as GameObject;
            hero.GetComponentInChildren<Movement>().setCam(mainCamera);
            Debug.Log("Hero created");
            //Vector3 cameraPostion = mainCamera.transform.position;
            mainCamera.transform.Translate(startPoint.transform.position.x, 0, 0);
        }
	}

    public static void inc() {
        scenes++;
    }

    public static string nxtLevel() {
        if (scenes >= 40)
            scenes -= 40;

        if (scenes<10) {
            return "Stage01";
        }
        else if (scenes < 20) {
            return "Stage02";
        }
        else if (scenes < 30) {
            return "Stage03";
        }
        else if (scenes < 40) {
            return "Stage04";
        }

        return null;
    }

	// Update is called once per frame
	void Update () {
	
	} 
    
}
