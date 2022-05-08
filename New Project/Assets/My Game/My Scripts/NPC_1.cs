using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Welcome traveler to our planet","1");
		Speech.AddDialogue("1","Please help us!", "2");
		Speech.AddDialogue("2", "Evil is everywhere here. Find Powerup, collect coins and go to next island", "3");
		Speech.AddDialogue("3", "Good luck");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}