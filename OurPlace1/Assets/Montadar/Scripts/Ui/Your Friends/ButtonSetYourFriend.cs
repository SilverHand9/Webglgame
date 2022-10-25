using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetYourFriend : MonoBehaviour
{
    public static ButtonSetYourFriend instance;
    private void Start()
    {
        instance = this;
        //NameYourFriend._friendName = this.name;
        

    }
    /*public void OnSetFriend(string friend)// ⁄‰œ œŒÊ· «·”Ì—›—
    {
        friend = NameYourFriend._friendName;
    }*/
    public static void TestOnSetFriend(string friend)
    {
        //TestOnSetFriend(NameYourFriend._friendName);
        friend = NameYourFriend._friendName;
        FriendName.NameFriend = friend;
    }
}
