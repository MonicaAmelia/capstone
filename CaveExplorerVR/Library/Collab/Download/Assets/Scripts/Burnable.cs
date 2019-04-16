using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burnable : MonoBehaviour {
    public Material burned;
    public Collider fireBolt;
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if (collision.gameObject.name.Equals("FireboltCollider"))
        {
            print("Hit");
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }

    }

    /*private void OnTriggerEnter(Collider other)
    {
        print("hit");
        if (other.Equals(fireBolt))
        {
            print("on fire!");
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }
        
    }*/
}
