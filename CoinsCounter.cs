using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    public int coins = 0;
    public void CollectCoins()
    {
        coins++;
        Debug.Log("Собранные монетки: " + coins);
    }
}
