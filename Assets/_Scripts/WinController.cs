using UnityEngine;
using System.Collections;

public class WinController : MonoBehaviour {

	public GameController gamecontroller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("crystal")) {
			//Transform playerTransform = other.gameObject.GetComponent<Transform>();
			//	playerTransform.position= this.spawnPoint.position;
			gamecontroller.LivesValue -= 1;
			Destroy (other.gameObject);
		} 
		else if (other.gameObject.CompareTag ("Finish"))
		{
			gamecontroller.WinValue += 10;
		
		}
	}
	
}
