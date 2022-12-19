using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeHawk : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] float pathSpeed = 5f; //Faster than the player to be more annoying
    AudioSource munch;
    AudioSource kill;
    GameObject player;
    BluePlayer playerScript; // I fukced up the name of the OG script

    private int Index = 0; //I am not bothered by i but for you...

    void Start()
    {
        transform.position = waypoints[Index].transform.position;
        munch = GetComponent<AudioSource>();
        kill = GameObject.Find("OtherPlayerDeath").GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            waypoints[Index].transform.position,
            pathSpeed * Time.deltaTime);

        if (transform.position == waypoints[Index].transform.position)
        {
            Index = Random.Range(0, waypoints.Length);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player 1" ||
            collision.gameObject.tag == "Player 2")
        {
            kill.Play();
            player = collision.gameObject;
            playerScript = player.GetComponent<BluePlayer>();
            collision.gameObject.transform.position = playerScript.Origin;
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0)); // Does not slow down much...
            Index = Random.Range(0, waypoints.Length); // He has a hard time knowing when to stop
        } // If Mike hits another player they reset position and momentum
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { // Needs a rigid body with knietic or dynamic, static does not work
        if (collision.gameObject.CompareTag("Fruit"))
        {
            munch.Play();
            Destroy(collision.gameObject);
        } // Mike Hawk does not care about winning...
    }
}
