using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum states {welcome, cell_01, cell_02, bed_01, bed_02, door_01, door_02, closet_01, closet_02, closet_03};
	private states myState;
	
	void Start () {
	myState = states.welcome;
	}
	
	void Update () {
		if(myState == states.welcome)			{Welcome();}
		else if(myState == states.cell_01)		{Cell_01();}
		else if(myState == states.cell_02)		{Cell_02();}
		else if(myState == states.bed_01)		{Bed_01();}
		else if (myState == states.bed_02)		{Bed_02();}
		else if(myState == states.door_01)		{Door_01();}
		else if(myState == states.door_02)		{Door_02();}
		else if(myState == states.closet_01)	{Closet_01();}
		else if(myState == states.closet_02)	{Closet_02();}
		else if(myState == states.closet_03)	{Closet_03();}
	}
	
	
	void Welcome(){
		text.text = "Welcome to my very first storyline game! I'm not feeling really creative, but anyway. Enjoy!\n\n" +
					"[Press Enter to begin.]";
		if(Input.GetKeyDown (KeyCode.Return)) { myState = states.cell_01;} 
	}
	void Cell_01(){
		text.text = "You are locked in a prison cell. There's a closet, a bed and a door in the room.\nWhat will you do?\n\n" +
					"[Press C to view Closet, B to look at Bed, D to go to Door.]";
		if(Input.GetKeyDown (KeyCode.C))	{ myState = states.closet_01;}
		if(Input.GetKeyDown (KeyCode.B))	{ myState = states.bed_01;}	
		if(Input.GetKeyDown(KeyCode.D))		{ myState = states.door_01;}
	}
	void Cell_02(){
		text.text = "The key you found looks pretty small and rusty. What could it unlock?\n\n" +
			"[Press C to view Closet, B to look at Bed, D to go to Door.]";
		if(Input.GetKeyDown (KeyCode.C))	{ myState = states.closet_02;}
		if(Input.GetKeyDown (KeyCode.B))	{ myState = states.bed_02;}	
		if(Input.GetKeyDown(KeyCode.D))		{ myState = states.door_02;}
	}
	
	void Door_01(){
		text.text = "You try the handle, but the door is locked.\n\n" +
					"[Press R to Return.]";
		if(Input.GetKeyDown (KeyCode.R))	{ myState = states.cell_01;}
	}
	void Door_02(){
		text.text = "The key you found is too small for the door. Try something else.\n\n" +
			"[Press R to Return.]";
		if(Input.GetKeyDown(KeyCode.R))		{myState = states.cell_02;}
	}
	
	void Closet_01(){
		text.text = "You try the handle, but the closet is locked. What could be inside?\n\n" +
					"[Press R to Return.]";
		if(Input.GetKeyDown (KeyCode.R))	{ myState = states.cell_01;}
	}
	void Closet_02(){
		text.text = "The closet has a lock on it. Try the key?\n\n" +
			"[Press T to Try, R to Return.]";
		if(Input.GetKeyDown (KeyCode.T))	{ myState = states.closet_03;}
		if(Input.GetKeyDown (KeyCode.R))	{ myState = states.cell_02;}
	}
	void Closet_03(){
		text.text = "You open the lock and find a portal to Narnia.\nYou go in and live on happily ever after as a talking unicorn. Hell yeah.\n" +
				"(I got bored writing the story at this point. Hope you liked the game, though.)\n\n" +
				"[Press P to play again.]";
		if(Input.GetKeyDown(KeyCode.P))		{ myState = states.welcome;}
	}
	
	void Bed_01(){
		text.text = "You look under the pillow and find a key!\n\n" +
					"[Press T to take key and Return, or R to Return.]";
		if(Input.GetKeyDown (KeyCode.T))	{ myState = states.cell_02;}
		if(Input.GetKeyDown (KeyCode.R))	{ myState = states.cell_01;}
	}
	void Bed_02(){
		text.text = "Pretty sure you can't unlock a bed with a key, genius. Nothing else to look at.\n\n" +
					"[Press R to Return.]";
		if(Input.GetKeyDown (KeyCode.R))	{ myState = states.cell_02;}
	}
	
}

	
	

