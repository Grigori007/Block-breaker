using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private LevelManager levelManager;
	public int maxHits;
	private int timesHit;
	public Sprite[] hitSprites;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D col){
	
		timesHit++;
		
		if(timesHit >= maxHits){
			Destroy(gameObject);
			//SimulateWin();
		} else {
			int HitIndicator = timesHit - 1;
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[HitIndicator];
		}	
	}
	
	// TODO Remove this when win mechanics is ready.
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
			
		
	}
	

