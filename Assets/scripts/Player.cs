using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int health = 3;
    public GameObject effect;
    private int h = 2;
    public GameObject Life;
    public GameObject Parent;
    public GameObject[] heal = new GameObject[3];

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;



    /*
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;
    */
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            heal[i] = Instantiate(Life, new Vector3((i * 40f) + 20f, 20f, transform.position.z), Quaternion.identity);
            heal[i].transform.parent = Parent.transform;
        }
    }
    private void Update()
    {
        
        if (health <= 0) {
            //spawner.SetActive(false);
            //restartDisplay.SetActive(true);
            //Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       /*
        healthDisplay.text = health.ToString();
        */
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(heal[h]);
        //Debug.Log(h);
        h--;
    }
}
