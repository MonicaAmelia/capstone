using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

    public static bool yellowPower, redPower, greenPower, blackPower = false;
    public static int money = 0;

    private void Start()
    {
        money = 0;
        yellowPower = false;
        redPower = false;
        greenPower = false;
        blackPower = false;
    }

    /*private void Update()
    {
        print("Yellow Power: " + yellowPower.ToString());
        print("Red Power: " + redPower.ToString());
        print("Green Power: " + greenPower.ToString());
        print("Black Power: " + blackPower.ToString());
    }*/
}
