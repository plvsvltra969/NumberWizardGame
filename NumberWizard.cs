using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	

	// Use this for initialization
	void Start () {
		StartGame ();
	}	
	
	int max = 1001;
	int min = 1;
	int guess = 5000;
	
	void StartGame () {
		 
		
		print ("I am the Number Wizard");
		print ("Choose a number in your head, don't tell me! I'm going to try to guess your number using my advanced cybernetic mind"); 
		
		
		
		print ("Let's decide on a number range then shall we? Your puny human mind can probably only count to 1000"); 
		print ("And we wont burden you with trying to understand negative numbers, so you'll have to pick a number between " + min + " and 10,000");
		
		print ("Let's begin so I can amaze you already.. Is your number higher or lower than " + guess + "?");
		print ("Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
	}
	void NextGuess () {
		guess = (max + min) /2;
		print ("I'm getting closer! Is your number higher or lower than " + guess + "?");
		print ("In case you were too dumb to remember: Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
		
	
	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			print ("Lower than " + guess + " is it then?");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.UpArrow)){
			print ("Ah higher than " + guess + " is it then?");
			min = guess;
			NextGuess (); 
		} else if (Input.GetKeyDown(KeyCode.Return)){using UnityEngine;using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	

	// Use this for initialization
	void Start () {
		StartGame ();
	}	
	
	int max = 1001;
	int min = 1;
	int guess = 500;
	
	void StartGame () {
	
		int max = 1001;
		int min = 1;
		int guess = 500;	 
		 	 	 
		print ("=======================================================================");
		print ("I am the Number Wizard");
		print ("Choose a number in your head, don't tell me! I'm going to try to guess your number using my advanced cybernetic mind"); 
		
		
		
		print ("Let's decide on a number range then shall we? Your puny human mind can probably only count to 10,000"); 
		print ("And we wont burden you with trying to understand negative numbers, so you'll have to pick a number between " + min + " and 1000");
		
		print ("Let's begin so I can amaze you already.. Is your number higher or lower than " + guess + "?");
		print ("Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
	}
	void NextGuess () {
		guess = (max + min) /2;
		print ("I'm getting closer! Is your number higher or lower than " + guess + "?");
		print ("In case you were too dumb to remember: Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
		
	
	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			print ("Lower than " + guess + " is it then?");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.UpArrow)){
			print ("Ah higher than " + guess + " is it then?");
			min = guess;
			NextGuess (); 
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print("Shadilay! Bwahaha I knew I could guess your number easily, silly human");
			guess = 500;
			max = 1000; 
			min = 1;
			StartGame (); 
		}
	}
	}
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	

	// Use this for initialization
	void Start () {
		StartGame ();
	}	
	
	int max = 1001;
	int min = 1;
	int guess = 500;
	
	void StartGame () {
	
		int max = 1001;
		int min = 1;
		int guess = 500;	 
		 	 	 
		print ("=======================================================================");
		print ("I am the Number Wizard");
		print ("Choose a number in your head, don't tell me! I'm going to try to guess your number using my advanced cybernetic mind"); 
		
		
		
		print ("Let's decide on a number range then shall we? Your puny human mind can probably only count to 10,000"); 
		print ("And we wont burden you with trying to understand negative numbers, so you'll have to pick a number between " + min + " and 1000");
		
		print ("Let's begin so I can amaze you already.. Is your number higher or lower than " + guess + "?");
		print ("Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
	}
	void NextGuess () {
		guess = (max + min) /2;
		print ("I'm getting closer! Is your number higher or lower than " + guess + "?");
		print ("In case you were too dumb to remember: Press the up arrow if it's more than my guess, and press the down arrow if it's lower than my guess. You'll need to press [Enter] once I've guessed correctly");  
		
	
	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			print ("Lower than " + guess + " is it then?");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.UpArrow)){
			print ("Ah higher than " + guess + " is it then?");
			min = guess;
			NextGuess (); 
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print("Shadilay! Bwahaha I knew I could guess your number easily, silly human");
			guess = 500;
			max = 1000; 
			min = 1;
			StartGame (); 
		}
	}
	}
			print("Shadilay! Bwahaha I knew I could guess your number easily, silly human");
			StartGame (); 
		}
	}
}
