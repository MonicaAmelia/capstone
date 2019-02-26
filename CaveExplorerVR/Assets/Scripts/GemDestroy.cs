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
            colorCheck();
            gemNoise.Play();
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            
            
        }
    }

    public void colorCheck()
    {
        switch (gemColor)
        {
            case "Yellow": PowerUps.yellowPower = true; break;
            case "Red": PowerUps.redPower = true; break;
            case "Green": PowerUps.greenPower = true; break;
            case "Black": PowerUps.blackPower = true; break;

        }
    }
}
