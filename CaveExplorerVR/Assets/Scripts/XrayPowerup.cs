using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrayPowerup : MonoBehaviour {

    // Use this for initialization
    public Material xRayStuff;
    public Material reg;
    public AudioSource zap;
	void Start () {
        gameObject.GetComponent<Collider>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //TODO change button
        if (OVRInput.Get(OVRInput.Button.Two) && PowerUps.blackPower)
        {
            ShowXray();
        }
        else
            hideXray();
    }

    void ShowXray()
    {
        gameObject.GetComponent<Renderer>().material = xRayStuff;
        gameObject.GetComponent<Collider>().enabled = false;
    }
    void hideXray()
    {
        zap.Play();
        gameObject.GetComponent<Renderer>().material = reg;
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
