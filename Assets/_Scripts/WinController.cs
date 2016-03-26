using UnityEngine;
using System.Collections;

public class WinController : MonoBehaviour {

	public GameController gamecontroller;

	[SerializeField]
	private AudioSource _hurtSound;

	[SerializeField]
	private AudioSource _coinSound;



	/*private AudioSource[] _audioSources;
	private AudioSource _hurtSound;
	private AudioSource _coinSound;*/

	// Use this for initialization
	void Start () {

	/*	this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._hurtSound = this._audioSources [0];
		this._coinSound = this._audioSources [1]; */
	
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
			this._hurtSound.Play ();

		} 
		if (other.gameObject.CompareTag ("medical")) {
			//Transform playerTransform = other.gameObject.GetComponent<Transform>();
			//	playerTransform.position= this.spawnPoint.position;
			gamecontroller.ScoreValue += 50;
			Destroy (other.gameObject);
		    this._coinSound.Play ();
		}
		else if (other.gameObject.CompareTag ("Finish"))
		{
			gamecontroller.WinValue += 10;
		
		}
	}
	
}
