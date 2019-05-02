﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItemActivator : ScreenPhase
{
    public Button button;
    public string correctItemName;
    public ItemPanelDetailBehavior itemPanelDetailBehaviour;
    public GameObject inventoryPanel;

    public ScreenPhase wrongItemPhase;

    public override void InitPhase()
    {
        AddClickListener();
    }

    private void AddClickListener()
    {
        button.onClick.AddListener(() => UseItem());
    }

    private void UseItem()
    {
        if (correctItemName == itemPanelDetailBehaviour.ActiveItemName)
            NotifyPhaseFinished();
        else
        {
            itemPanelDetailBehaviour.OnCloseButtonClick();
            inventoryPanel.SetActive(false);
            wrongItemPhase.InitPhase();
        }

    }

}
