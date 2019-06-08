using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
    Player p = new Player();
    private float timer = 0;
    private int score = 0;
    public Text scoreDisplay;
    
    private int h = 2;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1f)
        {

            score += 1;

            //We only need to update the text if the score changed.
            scoreDisplay.text = score.ToString();

            //Reset the timer to 0.
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            //score++;
            //Debug.Log(score);
            Destroy(other.gameObject);
            //Debug.Log(h);
            //h--;
            //Destroy(health[h]);
        }
    }
}
