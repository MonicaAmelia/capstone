using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public GameObject TeleportMarker;
    public Transform player;
    public float RayLength = 5f;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        if (Physics.Raycast(ray, out hit, RayLength))
        {
            if(hit.collider.tag == "Ground")
            {
                if (!TeleportMarker.activeSelf)
                {
                    TeleportMarker.SetActive(true);
                }
                TeleportMarker.transform.position = hit.point;
            }
            else
            {
                TeleportMarker.SetActive(false);
            }
        }
	}

    void TouchPadHandler(object sender, System.EventArgs e)
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (TeleportMarker.activeSelf)
            {
                Vector3 markerPos = TeleportMarker.transform.position;
                player.position = new Vector3 ( markerPos.x, 2, markerPos.z );

            }
        }
    }
}
