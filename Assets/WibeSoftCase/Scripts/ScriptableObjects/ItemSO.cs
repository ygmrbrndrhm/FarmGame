using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;       
    public Sprite itemIcon;       
    public ItemType itemType;    
    public int count;         
    public int price;
}
