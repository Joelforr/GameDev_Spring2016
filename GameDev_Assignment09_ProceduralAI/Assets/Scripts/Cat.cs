using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour
{

	//PUBLIC VARIABLES
	//public Transform mouseClone;
	public GameObject mouse;
	public AudioSource soundEffects;

	public float runSpeed = 1000f;
	public float killDistance = 3f;

	//DETECTION VARIABLES
	public Vector3 targetDirection;
	//public Vector3 forward;
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
		foreach (Transform mouseClone in GameManager.listofMice) {

			if (mouseClone) {
				targetDirection = (mouseClone.position - transform.position);

				angle = Vector3.Angle (targetDirection, transform.forward);

				if (angle < 90f) {
					Ray catRay = new Ray (transform.position, targetDirection);
					RaycastHit catRayHitInfo = new RaycastHit ();

					if (Physics.Raycast (catRay, out catRayHitInfo, 100f)) {
						if (catRayHitInfo.collider.tag == "Mouse") {
							if (catRayHitInfo.distance < killDistance) {
								soundEffects.PlayOneShot (soundEffects.clip);
								Destroy (mouse);
							} else {
								thisRigidbody.AddForce (targetDirection.normalized * runSpeed);
							}
						}
					}

				}
			}

				
		}

	}


}
