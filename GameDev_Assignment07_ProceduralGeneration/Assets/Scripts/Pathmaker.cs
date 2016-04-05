using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	//LOCAL VARIABLES
	private int counter = 0;
	public float spaceBetween = 1f;
	private Vector3 spawnPosition;
	public Transform floorPrefab1;
	public Transform floorPrefab2;
	public Transform pathmakerPrefab;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		spawnPosition = new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z);

		if (counter < 50) {
			float randomNumber = Random.Range (0.0f, 1.0f);
			if (randomNumber < .25f) {
				//transform.rotation += Quaternion.Euler (0f, 90f, 0f);
				transform.Rotate (0f, 90f, 0f);
			} else if (randomNumber >= .25f && randomNumber <= .5f) {
				//transform.rotation += Quaternion.Euler (0f, -90f, 0f);
				transform.Rotate (0f, -90f, 0f);
			} else if (randomNumber >= .99 && randomNumber <= 1.0f) {
				Instantiate (pathmakerPrefab,spawnPosition,this.transform.rotation);
			}
			if(Physics.Raycast(transform.position,Vector3.down,1f)){
				//Debug.Log ("HIT");
				transform.position += transform.forward*spaceBetween;
			}else{
				if(randomNumber <.5f){
					Instantiate (floorPrefab1,spawnPosition,this.transform.rotation);
				}else
					if(randomNumber >= .5f){
						Instantiate (floorPrefab2,spawnPosition,this.transform.rotation);
					}
				transform.position += transform.forward*spaceBetween;
			}
			counter++;
		} else
			Destroy (this.gameObject);
	}
}
