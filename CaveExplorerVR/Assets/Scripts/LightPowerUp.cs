using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPowerUp : MonoBehaviour
{
    public Transform handTransform;
    public GameObject lamp;
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: make lamp smaller???
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && PowerUps.yellowPower)
        {
            spawnLamp();
        }
    }



    void spawnLamp()
    {
        Instantiate(lamp, handTransform.position, handTransform.rotation);
        
    }

    IEnumerator delay(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
