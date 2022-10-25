using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendName : MonoBehaviour
{
    public static string NameFriend;
    private void FixedUpdate()
    {
        GetComponent<Text>().text = NameFriend;
    }
}
