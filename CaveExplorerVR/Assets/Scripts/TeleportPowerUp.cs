using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPowerUp : MonoBehaviour {

    public GameObject l;
	// Update is called once per frame
	private void Update () {
        
        if (PowerUps.greenPower)
        {
            l.SetActive(true);
        }
        else
            l.SetActive(false);
    }
}
