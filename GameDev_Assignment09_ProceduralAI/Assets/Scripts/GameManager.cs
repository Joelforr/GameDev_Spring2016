using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//PUBLIC VARIABLES
	public Cat catPrefab;
	public Mouse mousePrefab;
	public static List<Transform> listOfCats = new List<Transform>();
	public static List<Transform> listofMice = new List<Transform>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RestartGame ();

		Ray spawnRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit spawnRayHitInfo = new RaycastHit ();

		if(Physics.Raycast(spawnRay, out spawnRayHitInfo, 1000f)){
			if(Input.GetMouseButtonDown(0)){
				Transform newCat = (Transform)Instantiate (catPrefab, spawnRayHitInfo.point, Quaternion.identity);
				listOfCats.Add (newCat);
			}
			if(Input.GetMouseButtonDown(1)){
				Transform newMouse = (Transform)Instantiate (mousePrefab, spawnRayHitInfo.point, Quaternion.identity);
				listofMice.Add (newMouse);
			}
		}
			
	
	}

	void RestartGame(){
		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene (0);
		}
	}
}
