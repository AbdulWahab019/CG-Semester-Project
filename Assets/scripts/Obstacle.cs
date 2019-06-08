using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed;
    public GameObject effect;
    Score sc = new Score();
    private void Start()
    {
        
    }
    void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().health--;
            //Destroy(heal[other.GetComponent<Player>().health]);
            //sc.delObject(other.GetComponent<Player>().health);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }   
    }
}
