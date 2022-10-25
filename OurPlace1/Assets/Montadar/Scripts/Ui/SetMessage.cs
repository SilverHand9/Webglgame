using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetMessage : MonoBehaviour
{
    [SerializeField]
    private GameObject InputTitele , InputDiscription;
    
    public static string setTitle , setDiscription;
    private void Update()
    {
        setTitle = InputTitele.GetComponent<InputField>().text;
        setDiscription = InputDiscription.GetComponent<TMP_InputField>().text;
    }
}
