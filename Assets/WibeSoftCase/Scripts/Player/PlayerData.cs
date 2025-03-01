using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName="test";
    public int level=45;
    public int coin = 1000;
    public int power = 100;
    public List<string> inventory;

    public void Initialize(string name, int lvl, int coin,int power, List<string> items)
    {
        playerName = name;
        level = lvl;
        coin = coin;
        power=power;
        inventory = items;
    }
}
