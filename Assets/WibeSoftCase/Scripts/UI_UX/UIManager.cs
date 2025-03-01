using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI powerText;
    public GameObject bottomPanel;
    bool isBottomPanelOpen = false;

    [SerializeField] PlayerData playerData;
    private void Start()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {      
            levelText.text = playerData.level.ToString();
            coinText.text =  playerData.coin.ToString();
            powerText.text = playerData.power.ToString();       
    }
    public void BottomPanelButtonClicked()
    {
        if (!isBottomPanelOpen)
        {
            isBottomPanelOpen = true;
            bottomPanel.transform.DOLocalMoveY(-125, 1f);
        }
        else
        {
            isBottomPanelOpen = false;
            bottomPanel.transform.DOLocalMoveY(-220, 1f);
        }
    }
}
