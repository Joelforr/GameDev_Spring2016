using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour
{

	//PUBLIC VARIABLES
	public Transform targetCat;

	public float runSpeed = 100f;

	public float timer = 1f;

	//DETECTION VARIABLES
	public Vector3 targetDirection;
	public float angle;

	//PRIVATE VARIABLES
	private Rigidbody thisRigidbody;

	// Use this for initialization
	void Start ()
	{
		thisRigidbody = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate ()
	{
		targetDirection = targetCat.position - transform.position;

		angle = Vector3.Angle (targetDirection, transform.forward); 

		Debug.DrawLine (transform.position, targetCat.position, Color.yellow);

		if (angle < 145f) {
			Ray mouseRay = new Ray (transform.position, targetDirection);
			RaycastHit mouseRayHitInfo = new RaycastHit ();


			if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 100f)) {
				if (mouseRayHitInfo.collider.tag == "Cat") {

					RunAway ();
					//thisRigidbody.AddForce(-targetDirection.normalized * runSpeed);
					//transform.Rotate (0f, 180f, 0f);
					//transform.localEulerAngles += transform.up *180f;
					//transform.forward = -targetDirection.normalized;
			
				} else
					timer = 1f;
			}
		}
	
	}

	void RunAway(){
		if(timer > 0){
			transform.localEulerAngles += transform.up *180f;
			thisRigidbody.AddForce (transform.forward * runSpeed);
			timer -= Time.deltaTime;
		}
	}
}
