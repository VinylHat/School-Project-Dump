using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [Header("COMPONENTS")]
    private PlayerController playerController;
    public GameObject player;
    public TMP_Text money;
    public TMP_Text upgradeCost;
    public TMP_Text storeText;
    public GameObject winner;

    [Header("PRIVATE VARIABLES")]
    private int price = 10000;

    void Start()
    {
        playerController = player.GetComponent <PlayerController>();
    }

    void Update()
    {
        //display players money
        money.text = "Money: $" + playerController.money;
        //display cost to upgrade
        upgradeCost.text = "Price: $" + price;
        //win condition text change
        if (playerController.drillHardness >= 3)
            storeText.text = "You can't go any deeper... I guess that means you win?";
    }

    public void BuyUpgrade()
    {
        if (playerController.money > price)
        {
            playerController.drillHardness++;
            playerController.money -= price;
            price += price * 2;
            if (playerController.drillHardness > 3)
            {
                winner.SetActive(true);
            }
        }
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game ... ");
        Application.Quit();
    }
}
