using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager_Sc1 : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SaveUsername()
    {
        string inputText = inputField.text;

        if(inputText == "")
        {
            Data_persistence.sharedInstance.username = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            Data_persistence.sharedInstance.username = inputText;
        }
    }
}
