using UnityEngine;
using System.Collections;

public class WallMaker : MonoBehaviour
{

	private int counter = 0;
	public Transform wallPrefab;
	public Transform wallMakerPrefab;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray sphereRay = new Ray();
		RaycastHit sphereRayHitInfo = new RaycastHit ();

		if(Physics.SphereCast(sphereRay, 5f, out sphereRayHitInfo)){
			if(sphereRayHitInfo.collider.tag == "Wall"){
				Destroy(this.gameObject);
				this.gameObject.SetActive(false);
			}
		}

		if (counter < 15) {
			float randomNumber = Random.Range (0f, 1f);

			if(randomNumber < 0.15f){
				transform.Rotate (0f, 90f, 0f);
				transform.position += (transform.forward * 1.5f);
			}else
				if(randomNumber >= 0.15f && randomNumber < .30f){
					transform.Rotate(0f,90f,0f);
					transform.position += (transform.forward * 1.5f);
				}else
					if(randomNumber >= 0.95f && randomNumber < 1.0f){
						Instantiate(wallMakerPrefab,transform.position,transform.rotation);
					}

			Ray ray = new Ray (transform.position, Vector3.left);
			RaycastHit rayHitInfo = new RaycastHit ();

			if(Physics.Raycast(ray, out rayHitInfo,1f)){
				Instantiate(wallPrefab,transform.position,transform.rotation);
				transform.position += transform.right; 
				counter++;
			}else{
				//transform.position += (transform.forward*2);
				Instantiate(wallPrefab,transform.position,transform.rotation);
				transform.position += transform.right; 
				counter++;
				Instantiate(wallPrefab,transform.position,transform.rotation);
				transform.position += transform.right; 
				counter++;
			}

		}
			
	
	}
}
