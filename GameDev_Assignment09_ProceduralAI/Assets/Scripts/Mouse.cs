using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour
{

	//PUBLIC VARIABLES
	public Transform catClone;

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
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{
		foreach (Transform catClone in GameManager.listOfCats) {

			targetDirection = catClone.position - transform.position;

			angle = Vector3.Angle (targetDirection, transform.forward); 

			Debug.DrawLine (transform.position, catClone.position, Color.yellow);

			if (angle < 145f) {
				Ray mouseRay = new Ray (transform.position, targetDirection);
				RaycastHit mouseRayHitInfo = new RaycastHit ();

				if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 100f)) {
					if (mouseRayHitInfo.collider.tag == "Cat") {
						RunAway ();
					} else
						timer = 1f;
				}
			}
		}

	}

	void RunAway ()
	{
		if (timer > 0) {
			transform.localEulerAngles += transform.up * 180f;
			thisRigidbody.AddForce (transform.forward * runSpeed);
			timer -= Time.deltaTime;
		}
	}
}
