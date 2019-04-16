using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGem : MonoBehaviour {
    public GameObject black;
    public GameObject red;
    public GameObject green;
    public GameObject yellow;
    // Use this for initialization
    void Start() {
        black.GetComponent<Renderer>().enabled = false;
        black.GetComponent<Collider>().enabled = false;
        black.GetComponent<AudioSource>().enabled = false;
        red.GetComponent<Renderer>().enabled = false;
        red.GetComponent<Collider>().enabled = false;
        red.GetComponent<AudioSource>().enabled = false;
        green.GetComponent<Renderer>().enabled = false;
        green.GetComponent<Collider>().enabled = false;
        green.GetComponent<AudioSource>().enabled = false;
        yellow.GetComponent<Renderer>().enabled = false;
        yellow.GetComponent<Collider>().enabled = false;
        yellow.GetComponent<AudioSource>().enabled = false;

        int pick = Random.Range(1, 5);
        gemGen(pick);
    }

    void gemGen(int g)
    {
        if (g == 1)
        {
            black.GetComponent<Renderer>().enabled = true;
            black.GetComponent<Collider>().enabled = true;
            black.GetComponent<AudioSource>().enabled = true;
        }
        if (g == 2)
        {
            red.GetComponent<Renderer>().enabled = true;
            red.GetComponent<Collider>().enabled = true;
            red.GetComponent<AudioSource>().enabled = true;
        }
        if (g == 3)
        {
            green.GetComponent<Renderer>().enabled = true;
            green.GetComponent<Collider>().enabled = true;
            green.GetComponent<AudioSource>().enabled = true;
        }
        if (g == 4)
        {
            yellow.GetComponent<Renderer>().enabled = true;
            yellow.GetComponent<Collider>().enabled = true;
            yellow.GetComponent<AudioSource>().enabled = true;
        }
    }

}
