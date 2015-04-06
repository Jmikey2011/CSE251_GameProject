using UnityEngine;
using System.Collections;

// Traffic Light, and Cross Walk animation

// Defing the class Light
public class Light{

     private bool state;
     private double startTime;

     public double lightTimer;

}// end Light

public class Traffic : MonoBehaviour{

     public Light[] trafficLight;
     public Light[] crossWalk;


     void Start{

          // Initial state
          trafficLight_01 = new Light();
          trafficLight_02 = new Light();

     crossWalk_01 = new Light();
     crossWalk_02 = new Light();

     // Sets a random state for the traffic lights
     if(Random.Range(0,10) > 5)
          trafficLight_01.state = true;
     else 
          trafficLight_01.state = false;

     trafficLight_02.state = !trafficLight_01.state;
     crossWalk_01.state = !trafficLight_01.state;
     crossWalk_02.state = trafficLight_01.state;

}// end Start

void Update{
}// end Update

void setMat(Light,Light,Light,Light)
