using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int coins;
	

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		coins = 0;
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// 
		if (collided.gameObject.tag == "Coin") {

			coins++;
			// Siin me näitame kui palju on meil coins
			HUD.UpdateCoinCount(coins);
			// Aga siin näitame teksti, kui korjame coinsi
			HUD.Message("You collected coin!");
			Destroy(collided.gameObject);
		}

        if (collided.gameObject.tag == "Powerup1")
        {
			Abilities.doubleJumpEnabled = true;
			Destroy(collided.gameObject);
			HUD.Message("You jump higher!");
		}

        if (collided.gameObject.name == "Powerup2")
        {
			Abilities.spinAttackEnabled = true;
			Destroy(collided.gameObject);
			HUD.Message("You have spinattack magic!");

        }
	}
}