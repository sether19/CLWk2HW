using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	Text scoreText;
	public static int currentscore;
	// Use this for initialization
	void Start () {
		
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		currentscore = MatchManagerScript.scoreMatch; 
		scoreText.text = "Score : " + currentscore;

	
	}
}
