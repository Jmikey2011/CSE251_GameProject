using UnityEngine;
using System.Collections;

public class Light_Test : MonoBehaviour {



	static public float timeLimitYellow = 5f;
	static public float timeLimitGreen = 10f;
	static public float timeLimitRed = 15f;
	
	float currentTime;
	
	public int lightCounter = 0;
	
	public GameObject greenLight;
	public GameObject yellowLight;
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
			
			if (currentTime - startTime > timeLimitRed) {
				startTime = currentTime;
				//Debug.Log ("Time: " + startTime);
				SetLight ();
			}// end if 
			return;	
			
		case 1:
			
			if (currentTime - startTime > timeLimitGreen) {
				startTime = currentTime;
				//Debug.Log ("Time: " + startTime);
				SetLight ();
			}// end if 
			return;
			
		case 2:
			
			if (currentTime - startTime > timeLimitYellow) {
				startTime = currentTime;
				//Debug.Log ("Time:  " + startTime);
				SetLight ();
			}// end if
			return;
			
		}// end switch
	}// end Update
	
	// Turns on the specified light for the current frame
	void SetLight ()
	{	
		
		greenLight.SetActive (false);
		yellowLight.SetActive (false);
		redLight.SetActive (false);
		
		switch (lightCounter) {
			
		case 0:
			lightCounter++;
			//Debug.Log ("Trying light 0");
			greenLight.SetActive (true);
			return;
			
		case 1:
			lightCounter++;
			//Debug.Log ("Trying light 1");
			yellowLight.SetActive (true);
			return;
			
		case 2: 
			lightCounter = 0;
			//Debug.Log ("Trying light 2");
			redLight.SetActive (true);
			return;
			
		}// end switch

	}// end  SetLight

}// end Light_Test
