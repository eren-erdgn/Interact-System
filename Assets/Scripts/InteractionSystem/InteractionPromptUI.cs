using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionPromptUI : MonoBehaviour
{
    [SerializeField] private GameObject _uiPanel;
    [SerializeField] private TextMeshProUGUI _promptText;
    public bool IsDisplayed = false;
    private void Start()
    {
        _uiPanel.SetActive(false);
    }
    
    public void SetUp(string prompt)
    {
        _promptText.text = prompt;
        _uiPanel.SetActive(true);
        IsDisplayed = true;
    }
    public void Close()
    {
        _uiPanel.SetActive(false);
        IsDisplayed = false;
    }
}
