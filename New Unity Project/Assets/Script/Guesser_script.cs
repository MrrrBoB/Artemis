using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guesser_script : MonoBehaviour {

	public int max = 1000;
	public int min = 1;
	public int guess=650;

	// Use this for initialization
	private void Start () {
		

		print ("welcome to number guesser");
		print ("pick a number "+min+"-"+max);

		// Ask if guess is within specified parameters
		print("I guess "+guess);

		//Instructions - if guess is higher than value, press up, if lower than value, press down.
		print("Is your number higher? (up), lower (down) or same (enter)?");
	}


	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (min + max) / 2;
			print ("Is the number " + guess + "?");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {

		}
	}
}
