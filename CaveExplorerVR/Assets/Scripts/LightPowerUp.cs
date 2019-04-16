using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPowerUp : MonoBehaviour
{
    public Transform handTransform;
    public GameObject lamp;
    public AudioSource pop;
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
            pop.Play();
        }
    }



    void spawnLamp()
    {
        //Instantiate(lamp, handTransform.position, handTransform.rotation);
        GameObject obj = Instantiate(lamp, handTransform.position, handTransform.rotation);
        Destroy(obj,30f);
    }

    IEnumerator delay(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
