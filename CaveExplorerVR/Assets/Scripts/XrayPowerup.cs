using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrayPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.One) && PowerUps.blackPower)
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
    }
}
