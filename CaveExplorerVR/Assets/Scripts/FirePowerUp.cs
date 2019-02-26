using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePowerUp : MonoBehaviour
{
    public GameObject fireBolt;
    public Transform handTransform;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) && PowerUps.redPower)
        {
            shootFireBolt();
        }
    }

    void shootFireBolt()
    {
        Instantiate(fireBolt, handTransform.position, handTransform.rotation);
    }
}
