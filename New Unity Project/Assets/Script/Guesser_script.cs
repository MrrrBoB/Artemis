using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guesser_script : MonoBehaviour {

	public int max = 1001;
	public int min = 1;
	private int guess=650;

	// Use this for initialization
	private void Start () {
		

		print ("welcome to number guesser");
		print ("pick a number "+min+"-"+max);

		// Ask if guess is within specified parameters
		NextGuess ();
		//Instructions - if guess is higher than value, press up, if lower than value, press down.
		print("Is your number higher? (up), lower (down) or same (enter)?");
		max += 1;
	}
	private void NextGuess()
	{
		guess = (min + max) / 2;
		print ("Is the number " + guess + "?");
	}

	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			min = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) 
		{
			print ("That is correct!");
			min = 0;
			max = 1001;
			print ("Pick another number");
			guess = Random.Range (1, 1001);
			print ("Is " + guess + " your number?");
		}
	}
}
