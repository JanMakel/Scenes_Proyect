using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager_Sc2 : MonoBehaviour
{
    public TextMeshProUGUI helloText;

    private void Start()
    {
        helloText.text = $"Hello {Data_persistence.sharedInstance.username}";
    }
}
