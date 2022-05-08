using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public EnemySpawner enemySpawner;
	public int enemiesToSpawn;
	public int waveCount;
	public int waveToWin;
	public AudioSource music;
	public AudioClip battleMusic;
	// Use this for initialization
	protected void Start () {

		EnemySpawner.activated = false;
		music.Play();

	}

	// Update is called once per frame
	protected void Update () {
		
			if (enemySpawner.transform.childCount==0 && EnemySpawner.activated && !IsInvoking())

        {


			music.clip = battleMusic;
			music.Play();
			waveCount++;

			HUD.Message("now is ware nr" + waveCount);
			    enemiesToSpawn = Random.Range(waveCount*1, waveCount*2);
			Invoke("Spawnwave", 3);
			if (waveCount > waveToWin)
            {
				enemySpawner.gameObject.SetActive(false);
			}

		}

		
	}
		public void Spawnwave()
    {
		for (int i = 0; i < enemiesToSpawn; i++)
		{
			//enemySpawner.Spawn();
			enemySpawner.Invoke("Spawn", i);

		}
	}
}