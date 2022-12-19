using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldGen : MonoBehaviour
{
    [Header("COMPONENTS")]
    // I am using an array to avoid clutter
    public GameObject ground;
    public Tile[] Ore; // 0=Coal 1=Iron 2=Gold 3=Ruby 4=Saphire 5=Diamond 6=Emerald

    [Header("CONSTANT VARIABLES")]
    // IMPORTANT: Cell size is .5 so these must be half the gride length
    private const float DirtY1 = 2, DirtY2 = -9.5f,
                        RockY1 = -11, RockY2 = -24,
                        StoneY1 = -26, StoneY2 = -48,
                        BedrockY1 = -51, BedrockY2 = -74;
    private const float LeftX = -24f, RightX = 24f; // +- 1 for fault tolerance

    [Header("PRIVATE VARIABLES")]
    private int Luck; // Used for ore randomizing
    private float X, Y; // Used in methods

    [Header("PUBLIC VARIABLES")]
    public float DirtObjectCount = 150,
                 RockObjectCount = 150,
                 StoneObjectCount = 200,
                 BedrockObjectCount = 200;

    void Start()
    {
        GenerateDirtOre(DirtObjectCount);
        GenerateRockOre(RockObjectCount);
        GenerateStoneOre(StoneObjectCount);
        GenerateBedrockOre(BedrockObjectCount);
    }

    private void GenerateDirtOre(float ObjCount)
    { // USE: Coal - common, Iron - rare -- 200 objects
        for (int i = 0; i < ObjCount; i++)
        {
            Luck = Random.Range(0, 100);
            if (Luck <= 33) // 1/3
            {
                Generate(DirtY1, DirtY2, Ore[0]);
            }
            else if (Luck > 33) // 2/3
            {
                Generate(DirtY1, DirtY2, Ore[1]);
            }
            else Debug.Log("Nothing was generated...");
        }
    }

    private void GenerateRockOre(float ObjCount)
    { // USE: Coal/Iron - common, Gold - rare -- 200 objects
        for (int i = 0; i < ObjCount; i++)
        {
            Luck = Random.Range(0, 100);
            if (Luck <= 40) // 2/5 
            {
                Generate(RockY1, RockY2, Ore[0]);
            }
            else if (Luck <= 80 && Luck > 40) // 2/5 
            {
                Generate(RockY1, RockY2, Ore[1]);
            }
            else if (Luck > 80) // 1/5
            {
                Generate(RockY1, RockY2, Ore[2]);
            }
            else Debug.Log("Nothing was generated...");
        }
    }

    private void GenerateStoneOre(float ObjCount)
    { // USE: Coal/Iron/Gold - common, Ruby/Diamond - rare -- 400 objects
        for (int i = 0; i < ObjCount; i++)
        {
            Luck = Random.Range(0, 100);
            if (Luck <= 25) // 1/4
            {
                Generate(StoneY1, StoneY2, Ore[0]);
            }
            else if (Luck <= 50 && Luck > 25) // 1/4
            {
                Generate(StoneY1, StoneY2, Ore[1]);
            }
            else if (Luck <= 75 && Luck > 50) // 1/4
            {
                Generate(StoneY1, StoneY2, Ore[2]);
            }
            else if (Luck <= 90 && Luck > 75) // 3/20
            {
                Generate(StoneY1, StoneY2, Ore[3]);
            }
            else if (Luck > 90) // 1/10
            {
                Generate(StoneY1, StoneY2, Ore[5]);
            }
            else Debug.Log("Nothing was generated...");
        }
    }

    private void GenerateBedrockOre(float ObjCount)
    { // USE: Gold/Ruby/Saphire - common, Emerald/Diamond - rare -- 400 objects
        for (int i = 0; i < ObjCount; i++)
        {
            Luck = Random.Range(0, 100);
            if (Luck <= 25) // 1/4
            {
                Generate(BedrockY1, BedrockY2, Ore[2]);
            }
            else if (Luck <= 50 && Luck > 25) // 1/4
            {
                Generate(BedrockY1, BedrockY2, Ore[3]);
            }
            else if (Luck <= 75 && Luck > 50) // 1/4
            {
                Generate(BedrockY1, BedrockY2, Ore[4]);
            }
            else if (Luck <= 90 && Luck > 75) // 3/20
            {
                Generate(BedrockY1, BedrockY2, Ore[5]);
            }
            else if (Luck > 90) // 1/10
            {
                Generate(BedrockY1, BedrockY2, Ore[6]);
            }
            else Debug.Log("Nothing was generated...");
        }
    }
    
    private void Generate(float Y1, float Y2, Tile Ore)
    {
        X = Mathf.Round(Random.Range(LeftX, RightX));
        Y = Mathf.Round(Random.Range(Y1, Y2));

        Luck = Random.Range(1, 6);
        switch (Luck)
        {
            case 1:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                break;
            case 2:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y)), Ore);
                break;
            case 3:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y - .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y)), Ore);
                break;
            case 4:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y - .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y - .5f)), Ore);
                break;
            case 5:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y + .5f)), Ore);
                break;
            case 6:
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X + .5f, Y + .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X - .5f, Y - .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X, Y - .5f)), Ore);
                ground.GetComponent<Tilemap>().SetTile(ground.GetComponent<Tilemap>().WorldToCell(new Vector2(X = .5f, Y - .5f)), Ore);
                break;
            default:
                Debug.Log("If you are reading this it is unity's fault");
                break;
        }

        // DEPRECATED
        //X = Mathf.Round(Random.Range(LeftX, RightX));
        //Y = Mathf.Round(Random.Range(Y1, Y2));
        //Instantiate(array[Random.Range(0, array.Length)],
        //            new Vector2(X, Y),
        //            Quaternion.identity,
        //            GameObject.Find("Ground").transform);
    }
}
