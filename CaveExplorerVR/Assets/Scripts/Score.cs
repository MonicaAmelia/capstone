using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text score;
	// Use this for initialization
	void Start () {
        score.text += PowerUps.money.ToString();
	}
}
