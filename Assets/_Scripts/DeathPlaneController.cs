using UnityEngine;
using System.Collections;

public class DeathPlaneController : MonoBehaviour {


	public Transform spawnPoint;
	public GameController gamecontroller;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Transform playerTransform = other.gameObject.GetComponent<Transform>();
			playerTransform.position= this.spawnPoint.position;
			gamecontroller.LivesValue -= 1;
		}
		else
		{
			Destroy(other.gameObject);
		}
	}
}
