using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [Header("COMPONENTS")]
    private Animator animator;
    private Rigidbody2D rb;
    public Tilemap ground;
    private TileBase victim;
    public GameObject drill;
    public GameObject drillPoint;
    public GameObject prompt;
    public GameObject shopUI;

    [Header("ANIMATIONS")]
    private string currentState;
    const string IDLE = "PlayerAnimator";
    const string WALK = "Walk";
    // NOTE: Who ever made this part of the Unity is an asshole

    [Header("PUBLIC VARIABLES")]
    public float runSpeed = 5f;
    public float jumpForce = 3f;
    public int money, drillHardness; //Used in another script

    [Header("PRIVATE VARIABLES")]
    private bool Grounded;
    private int dirtCount, rockCount,
                stoneCount, bedrockCount,
                coalCount, ironCount,
                goldCount, rubyCount,
                saphireCount, diamondCount,
                emeraldCount;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // Movement is in Update because I had problems with FixedUpdate
        Movement();
        Jumping();

        DrillRotation();
        DrillDig();

        UpdateChecks();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.y > 10 ||
            rb.velocity.y < -10 ||
            rb.velocity.x > 10 ||
            rb.velocity.x < -10)
        { // Hard speed limit
            rb.drag = 20;
        }
        else rb.drag = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Home")
        {
            prompt.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Home")
        {
            prompt.SetActive(false);
            shopUI.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Home")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                prompt.SetActive(false);
                shopUI.SetActive(true);
            }
        }
    }

    private void ChangeAnimationState(string newState)
    {
        // Check to see if animation is already playing
        if (currentState == newState) return;

        // Play
        animator.Play(newState);

        // Tracks current state
        currentState = newState;
    }

    private void UpdateChecks()
    { // These are simple tasks to not clutter Update()
        if (rb.velocity.x == 0)
            ChangeAnimationState(IDLE);

        if (!Input.GetKey(KeyCode.Mouse0))
            drill.GetComponent<Animator>().speed = 0;
    }

    private void Jumping()
    { // Vertical Movement
        // When above Ground only jump once
        if (transform.position.y >= 5)
        {
            if (Grounded && Input.GetKeyDown(KeyCode.W) ||
                Grounded && Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (rb.velocity.y < 3)
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
        // When below Ground just GetKey
        else if (transform.position.y < 5)
        {
            if (Input.GetKey(KeyCode.W) ||
                Input.GetKey(KeyCode.UpArrow))
            {
                if (rb.velocity.y < 3)
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
    
    private void Movement()
    { // Horizontal Movement
        if (Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.RightArrow))
        {
            if (rb.velocity.x < 5)
                rb.AddForce(new Vector2((runSpeed), rb.velocity.y), ForceMode2D.Force);
            transform.eulerAngles = new Vector2(0, 0); //Face Right
            ChangeAnimationState(WALK);
        }
        else if (Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.LeftArrow))
        {
            if (rb.velocity.x > -5)
                rb.AddForce(new Vector2((-runSpeed), rb.velocity.y), ForceMode2D.Force);
            transform.eulerAngles = new Vector2(0, 180); // Face Left
            ChangeAnimationState(WALK);
        }
    }

    private void DrillRotation()
    { // Pivots the drill based on mouse
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        drill.transform.up = new Vector2(mousePosition.x - drill.transform.position.x,
                                        mousePosition.y - drill.transform.position.y);
    }

    private void DrillDig()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            drill.GetComponent<Animator>().speed = 1;

            Debug.Log(ground.GetTile(ground.WorldToCell(drillPoint.transform.position)));
            victim = ground.GetTile(ground.WorldToCell(drillPoint.transform.position));
            switch (victim.name)
            {
                case "Dirt":
                    dirtCount++;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "RockyDirt":
                    if (drillHardness >= 1)
                    {
                        rockCount++;
                        ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                        drill.GetComponent<AudioSource>().Play();
                    }
                    break;
                case "Stone":
                    if (drillHardness >= 2)
                    {
                        stoneCount++;
                        ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                        drill.GetComponent<AudioSource>().Play();
                    }
                    break;
                case "DarkCobble":
                    if (drillHardness >= 3)
                    {
                        bedrockCount++;
                        ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                        drill.GetComponent<AudioSource>().Play();
                    }
                    break;
                case "Coal":
                    coalCount++;
                    money += 50;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Iron":
                    ironCount++;
                    money += 100;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Gold":
                    goldCount++;
                    money += 300;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Ruby":
                    rubyCount++;
                    money += 500;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Saphire":
                    saphireCount++;
                    money += 600;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Diamond":
                    diamondCount++;
                    money += 1000;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                case "Emerald":
                    emeraldCount++;
                    money += 1500;
                    ground.SetTile(ground.WorldToCell(drillPoint.transform.position), null);
                    drill.GetComponent<AudioSource>().Play();
                    break;
                default:
                    Debug.Log("Block was Null or Name did not Match");
                    break;
            }
        }
    }
}
