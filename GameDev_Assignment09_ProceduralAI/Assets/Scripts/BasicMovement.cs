using UnityEngine;
using System.Collections;

public class BasicMovement : MonoBehaviour {

	//PHYSICS VARIABLES
	public Vector3 playerMovement;
	public float moveSpeed;

	//DETECTION VARIABLES
	public float radius =1f;
	public float maxDistance =3f;

	//OTHER VARIABLES
	private int randomNumber;

	//PRIVATE VARIABLES
	private Rigidbody thisRigidbody;


	// Use this for initialization
	void Start () {
		thisRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		playerMovement = transform.forward * moveSpeed;
		thisRigidbody.velocity = playerMovement;

		Ray moveRay = new Ray (transform.position, transform.forward);
		randomNumber = Random.Range (0, 2);

		if(Physics.SphereCast(moveRay,radius,maxDistance)){
			if(randomNumber == 0){
				transform.Rotate(0f, 90f, 0f);
			}else{
				transform.Rotate (0f, -90f, 0f);
			}
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		Gizmos.DrawRay (transform.position, transform.forward * maxDistance);
		Gizmos.DrawSphere (transform.position + transform.forward * maxDistance, radius);
	}
}
