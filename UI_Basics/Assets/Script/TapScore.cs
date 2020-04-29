using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TapScore : MonoBehaviour {

    public Text tapScoreText;
    public Text tenTapText;
    public int tapScore;
    public GameObject tenTaps;
     int score;
     int oldScore;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        tapScoreText.text = "Score: " + tapScore;
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tapScore++;
            
            // Debug.Log("10 taps");
        }

         if (tapScore == oldScore + 10)
 {

    

     Instantiate(tenTaps);
     oldScore = tapScore;
     tenTaps.SetActive(true);
     
 }
 
	}
}