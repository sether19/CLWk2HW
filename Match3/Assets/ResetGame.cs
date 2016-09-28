using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ResetGame : MonoBehaviour {

	public AudioSource serenity;
	// Use this for initialization
	void Start () {
		//serenity = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResetScene(){
//		AudioSource audio = GetComponents <AudioSource> ()[0];
//		audio.Play();
	//	serenity.Play();
		SceneManager.LoadScene(0);
	}
}
