using UnityEngine;
using System.Collections;

public class Light_Test : MonoBehaviour {

	static public float timeLimit = 10f;
	float currentTime;
	public int light = 0;
	
	public GameObject greenLight;
	public GameObject yellowLight;
	public GameObject redLight;

	private float startTime;

	// Use this for initialization
	void Start () {
		
		startTime = Time.time;
		
	}// end Start

	// Update is called once per frame
	// Sets the currentTime and calls SetLight function
	void Update () {
		
		currentTime = Time.time;
		
		if (currentTime - startTime > timeLimit) {
			startTime = currentTime;
			Debug.Log ("Time: " + startTime);
			SetLight ();
			light++;
		}// end if
		
	}// end Update

	// Turns on the specified light for the current frame
	void SetLight () {	
		
		greenLight.SetActive (false);
		yellowLight.SetActive (false);
		redLight.SetActive (false);
		
		if (light => 3 || light == 0) {
			light = 0;
			Debug.Log ("Trying light 0");
			greenLight.SetActive (true);
		}// end if
		
		if (light == 1) {
			Debug.Log ("Trying light 1");
			yellowLight.SetActive (true);
		}// end if
		
		if (light == 2) {
			Debug.Log ("Trying light 2");
			redLight.SetActive(true);
		}// end if
		
	}// end  SetLight

}// end Light_Test


