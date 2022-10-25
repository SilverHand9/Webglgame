using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMassage : MonoBehaviour
{
    [SerializeField]
    Text GetTitele , Discription ,YourName,Friend;

    private void LateUpdate()
    {
        GetTitele.text = SetMessage.setTitle;
        Discription.text = SetMessage.setDiscription;

        //YourName = id.player.name;// On Awack
        //Friend = id.frind; // On GameManager // list<Button> ...


    }
}
