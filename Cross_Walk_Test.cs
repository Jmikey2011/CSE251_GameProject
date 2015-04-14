using UnityEngine;
using System.Collections;

public class Cross_Walk_Test : MonoBehaviour {

	static public float blinkRate = 10f;
	static public int blinkDuration = 10;
	static public float timeLimitGreen = 5f;
	static public float timeLimitRed = 15f;
	
	float currentTime;
	
	public int lightCounter = 0;
	
	public GameObject greenLight;
	public GameObject blinkLight;
	public GameObject redLight;
	
	private float startTime;
	
	// Use this for initialization
	void Start (){
		
		startTime = Time.time;
		SetLight ();
		
	}// end Start
	
	// Update is called once per frame
	// Sets the currentTime and calls SetLight function
	void Update ()
	{
		
		currentTime = Time.time;
		switch (lightCounter) {
		case 0:	
			
			if (currentTime - startTime > timeLimitGreen) {
				startTime = currentTime;
				Debug.Log ("Time: " + startTime);
				SetLight ();
			}// end if 
			return;	
			
		case 1:
			
			if (currentTime - startTime > blinkRate) {
				startTime = currentTime;
				Debug.Log ("Time: " + startTime);
				SetLight ();
			}// end if 
			return;
			
		case 2:
			
			if (currentTime - startTime > timeLimitRed) {
				startTime = currentTime;
				Debug.Log ("Time:  " + startTime);
				SetLight ();
			}// end if
			return;
			
		}// end switch
	}// end Update
	
	// Turns on the specified light for the current frame
	void SetLight () {	
		
		greenLight.SetActive (false);
		blinkLight.SetActive (false);
		redLight.SetActive (false);
		
		switch (lightCounter) {
			
		case 0:
			lightCounter++;
			Debug.Log ("Trying light: 0");
			greenLight.SetActive (true);
			return;
			
		case 1:
			lightCounter++;
			Debug.Log ("Trying light: 1");
			redLight.SetActive (true);
			return;
			
		case 2: 
			for(float i = startTime; i < (blinkDuration); i = currentTime - startTime){
				if(i % 2 != 0){
					redLight.SetActive(true);
				}// end if
				else{
					redLight.SetActive(false);
				}// end else
			}// end for
			Debug.Log ("Trying light: 2");
			lightCounter = 0;
			return;
			
		}// end switch
		
	}// end  SetLight

}// end Cross_Walk_Test
