using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BluePlayer : MonoBehaviour
{
    Rigidbody2D bod;
    AudioSource munch;
    GameObject fruit;
    FruitMaster fruitMaster;
    public TMPro.TextMeshProUGUI Scoretxt;
    
    private float speedBuffTime = 0f;
    private float Score = 0f;

    public float thrust = 3f;
    public float speedBuff = 2f;
    public Vector3 Origin;

    void Awake()
    {
        Origin = this.gameObject.transform.position; //Starting point
    }
    void Start()
    {
        bod = GetComponent<Rigidbody2D>();
        munch = GetComponent<AudioSource>(); // SFX for collecting fruit

        switch (this.gameObject.tag) // NOTHING WRONG WITH THE SWITCH
        {                           // Unity is just confused...
            case "Player 1":
                Scoretxt.text = "Blue Score: 0";
                break;
            case "Player 2":
                Scoretxt.text = "Red Score: 0";
                break;
            default:
                Scoretxt.text = "NULL";
                Debug.Log("Player needs a tag of [Player 1] or [Player 2]");
                break;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Restart Button
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        if (Input.GetKeyDown(KeyCode.Escape)) // Exit to main menu
        {
            SceneManager.LoadScene(0); // Main menu
        }

        speedBuffTime -= Time.deltaTime; // Counts down the timer, negative values shouldn't matter
    }

    private void FixedUpdate()
    {
        // Basic Movement - style TBD
        // Horizontal
        if ((this.gameObject.tag == "Player 1" && Input.GetKey(KeyCode.D)) ||
            (this.gameObject.tag == "Player 2" && Input.GetKey(KeyCode.RightArrow)))
        {
            if (speedBuffTime > 0)
            {
                bod.AddForce(new Vector2(thrust * speedBuff, 0));
            }
            else
                bod.AddForce(new Vector2(thrust, 0));
        }
        else if ((this.gameObject.tag == "Player 1" && Input.GetKey(KeyCode.A)) ||
            (this.gameObject.tag == "Player 2" && Input.GetKey(KeyCode.LeftArrow)))
        {
            if (speedBuffTime > 0)
            {
                bod.AddForce(new Vector2(-thrust * speedBuff, 0));
            }
            else
                bod.AddForce(new Vector2(-thrust, 0));
        }
        // Vertical
        if ((this.gameObject.tag == "Player 1" && Input.GetKey(KeyCode.W)) ||
            (this.gameObject.tag == "Player 2" && Input.GetKey(KeyCode.UpArrow)))
        {
            if (speedBuffTime > 0)
            {
                bod.AddForce(new Vector2(0, thrust * speedBuff));
            }
            else
                bod.AddForce(new Vector2(0, thrust));
        }
        else if ((this.gameObject.tag == "Player 1" && Input.GetKey(KeyCode.S)) ||
            (this.gameObject.tag == "Player 2" && Input.GetKey(KeyCode.DownArrow)))
        {
            if (speedBuffTime > 0)
            {
                bod.AddForce(new Vector2(0, -thrust * speedBuff));
            }
            else
                bod.AddForce(new Vector2(0, -thrust));
        } // END of Movment
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (speedBuffTime < 5f) 
        {
            speedBuffTime = 5f;
        } // sets timer to 5 seconds on collision 
    } // END of Collision

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            munch.Play();
            Destroy(collision.gameObject);
            fruit = collision.gameObject;
            fruitMaster = fruit.GetComponent<FruitMaster>();
            Score += 1 * fruitMaster.life; // NOTE: Float displayed is rounded, real number unchanged
            switch (this.gameObject.tag)
            {
                case "Player 1":
                    Scoretxt.text = "Blue Score: " + Mathf.Round(Score);
                    break;
                case "Player 2":
                    Scoretxt.text = "Red Score: " + Mathf.Round(Score);
                    break;
                default:
                    Debug.Log("Player needs a tag of [Player 1] or [Player 2] -- Score undocumented");
                    break;
            }
        } // END of OnTrigger
    }
}
