using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void ChangeLevel(string name){
		Debug.Log("Level load requested for " + name);
		//StartCoroutine(FadeLevel());
		Application.LoadLevel(name);
	}
	
	public void QuitLevel(){
		Debug.Log("Quit requested.");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	/*IEnumerator FadeLevel(){
		float fadeTime = GameObject.Find("Canvas").GetComponent<ScreenFade_new>().connectScripts();
		yield return new WaitForSeconds(fadeTime);
	}*/
}
