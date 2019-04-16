using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrayPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Collider>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.Three) && PowerUps.blackPower)
        {
            ShowXray();
        }
        else
            hideXray();
    }

    void ShowXray()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }
    void hideXray()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
