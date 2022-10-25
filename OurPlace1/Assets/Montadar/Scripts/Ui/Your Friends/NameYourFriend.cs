using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameYourFriend : MonoBehaviour
{
    public static string _friendName;
   
    private void Awake()
    {
        
    }
    private void LateUpdate()
    {
        _friendName = GetComponent<Text>().text;// Test
    }

}
