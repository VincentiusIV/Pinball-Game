using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public Text announcementText;

    private int score;
    private int lives;

	// Use this for initialization
	void Awake ()
    {

        lives = 1;
        livesText.text = "Balls in field: "+ lives;

        score = 0;
        scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void AddScore(int _score)
    {
        score += _score;
        scoreText.text = "Score: " + score;
        scoreText.GetComponent<TextAnimations>().Shake();
    }

    public void Announce()
    {
        announcementText.text = "NEW BALL!";
        announcementText.transform.Translate(new Vector3((-announcementText.transform.position.x), 0.0f, 0.0f));
        announcementText.GetComponent<TextAnimations>().Whoosh();
    }
}
