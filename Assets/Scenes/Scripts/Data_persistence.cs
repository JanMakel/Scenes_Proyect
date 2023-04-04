using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_persistence : MonoBehaviour
{
    public static Data_persistence sharedInstance;

    public string username;

    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
