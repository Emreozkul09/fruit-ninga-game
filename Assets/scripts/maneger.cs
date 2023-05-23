using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maneger : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameScore();
    }

    private void gameScore() {
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
