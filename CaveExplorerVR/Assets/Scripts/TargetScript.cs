using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    public Animator a;
    public GameObject door;
    public int doorNum;
    public AudioSource grind;
    private bool isdooropen = false;
	// Use this for initialization
	void Start () {
        a = door.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject);
        if (collision.gameObject.name.Equals("Particle Lamp(Clone)") && !isdooropen)
        {
            //print("Hit");
            isdooropen = true;
            a.SetTrigger("Open"+doorNum);
            //a.enabled = false;
            if (isdooropen)
            {
                grind.Play();
            }
        }
        

    }
}
