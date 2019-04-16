using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpin : MonoBehaviour {
    public int spinY = 1;
    public int spinX = 0;

    // Update is called once per frame
    void Update () {
        gameObject.transform.Rotate(spinX, spinY, 0);
	}
}
