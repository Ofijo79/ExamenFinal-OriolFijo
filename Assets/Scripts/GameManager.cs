using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;
    int coins;
    public List<GameObject> enemiesInScreen;

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
    void KillAllEnemies()
    {
        foreach (GameObject item in enemiesInScreen)
        {
            Destroy(item);
        }
        /*while
        {
            bromita
        }*/
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllEnemies();
        }
    }
}
