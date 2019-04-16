using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDestroy : MonoBehaviour {
    public SphereCollider rightHandHitBox;
    public SphereCollider leftHandHitBox;
    public string gemColor;
    public SphereCollider gemHitBox;
    public AudioSource gemNoise;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0.5 && leftHandHitBox.bounds.Intersects(gemHitBox.bounds))
            || (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0.5 && rightHandHitBox.bounds.Intersects(gemHitBox.bounds)))
        {
            ColorCheck();
            gemNoise.Play();
            Destroy(gameObject);
            //gameObject.GetComponent<Renderer>().enabled = false;
            //gameObject.GetComponent<Collider>().enabled = false;
            
            
        }
    }

    public void ColorCheck()
    {
        switch (gemColor)
        {
            case "Yellow": PowerUps.yellowPower = true; PowerUps.money += 10; break;
            case "Red": PowerUps.redPower = true; PowerUps.money += 25; break;
            case "Green": PowerUps.greenPower = true; PowerUps.money += 50; break;
            case "Black": PowerUps.blackPower = true; PowerUps.money += 75; break;
            case "Blue": PowerUps.money += 100; break;
        }
    }
}
