using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TapScore : MonoBehaviour {

    public Text tapScoreText;
    public int tapScore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        tapScoreText.text = "Score: " + tapScore;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tapScore++;
        }
	}
}