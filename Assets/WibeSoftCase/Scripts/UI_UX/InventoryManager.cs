using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryArea;
    public GameObject inventoryButton;

    bool isInventoryOpen = false;


    public GameObject[] tabs;
    public GameObject[] pages;
    private int currentTabIndex = -1;

    public void OnTabClicked(int tabIndex)
    {
        if (tabIndex < 0 || tabIndex >= pages.Length)
        {
            Debug.LogError("Invalid tab index");
            return;
        }

        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabs[i].GetComponent<Button>().enabled = true;
        }

        pages[tabIndex].SetActive(true);
        tabs[tabIndex].GetComponent<Button>().enabled = false;
        currentTabIndex = tabIndex;
    }
    public void InventoryButtonClicked()
    {
        if (!isInventoryOpen)
        {
            isInventoryOpen = true;
            inventoryArea.transform.DOLocalMoveX(150,1f);
            inventoryButton.transform.DOLocalMoveX(-200,1f);
        }
        else
        {
            isInventoryOpen = false;
            inventoryArea.transform.DOLocalMoveX(-45, 1f);
            inventoryButton.transform.DOLocalMoveX(-295, 1f);
        }
    }
   
}
