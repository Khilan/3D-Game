﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private int _scoreValue;
	private int _livesValue;
	private int _win;

	private Vector3 _playerspawnpoint;

	[SerializeField]
	private AudioSource _gameOverSound;

	[SerializeField]
	private AudioSource _gameSound;

	// PUBLIC ACCESS METHODS
	public int WinValue{

		get{ 
			return this._win;
		}
		set {
			this._win = value;
		}
	}

	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}
		
	// PUBLIC INSTANCE VARIABLES
	//public int cloudNumber = 3;
	/*public CloudController cloud;
	public PlaneController plane;
	public IslandController island; */
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;
	public GameObject player;
	public Text WinLabel;

	// Use this for initialization
	void Start () {
	this._initialize ();

		//Instantiate (this.player, this._playerspawnpoint, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		if (this._win == 10) {
			this.WinLabel.gameObject.SetActive (true);
			this.GameOverLabel.gameObject.SetActive (false);
			this.HighScoreLabel.gameObject.SetActive (false);
			this.LivesLabel.gameObject.SetActive (false);
			this.ScoreLabel.gameObject.SetActive (false);
			this.RestartButton.gameObject.SetActive (true);
			this._gameOverSound.Play ();
		}
	}

	//PRIVATE METHODS ++++++++++++++++++

	//Initial Method
	private void _initialize() {
	//	this._playerspawnpoint = new Vector3 (0f,2f,-8f);

		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.gameObject.SetActive (false);
		this.HighScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive(false);
		this.WinLabel.gameObject.SetActive (false);

		/*
		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			Instantiate (cloud.gameObject);
		} */
	}

	private void _endGame() {
		this.HighScoreLabel.text = "High Score: " + this._scoreValue;
		this.GameOverLabel.gameObject.SetActive (true);
		this.HighScoreLabel.gameObject.SetActive (true);
		this.LivesLabel.gameObject.SetActive (false);
		this.ScoreLabel.gameObject.SetActive (false);
		this.WinLabel.gameObject.SetActive (false);
		/*this.plane.gameObject.SetActive (false);
		this.island.gameObject.SetActive (false); */
		//this._gameOverSound.Play ();
		this.RestartButton.gameObject.SetActive (true);
		this._gameSound.Play ();
	}

	// PUBLIC METHODS

	public void RestartButtonClick() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
