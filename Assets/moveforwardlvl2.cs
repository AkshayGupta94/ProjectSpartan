using UnityEngine;
using System.Collections;

public class moveforwardlvl2 : MonoBehaviour
{

    public GameObject advancr;


    // Use this for initialization
    void Start()
    {
        if (advancr == null)
            Debug.LogError("Nothing to advance");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
            advancr.transform.Translate(30 * 3, 0, 0);
            GlobalInterchange.inc();
    }
}
