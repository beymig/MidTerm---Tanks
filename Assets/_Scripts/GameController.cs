using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;
    private int _scoreValue;
    private int _livesValue;
    public EnemyController enemy;
    // PUBLIC ACCESS METHODS

    public Text LivesLabel;
    public Text ScoreLabel;
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }



    // Use this for initialization
    void Start () {
		this._GenerateTanks ();
        this.ScoreValue = 0;
        this.LivesValue = 5;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}
    private void _endGame()
    {
        //this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        //this.GameOverLabel.enabled = true;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        //this.plane.gameObject.SetActive(false);
        //this.island.gameObject.SetActive(false);
        //this.HighScoreLabel.enabled = true;
        //this._gameOverSound.Play();
        //this.RestartButton.enabled = true;


    }

}
