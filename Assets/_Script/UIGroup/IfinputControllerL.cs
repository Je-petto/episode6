using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;
using System.Runtime.InteropServices.WindowsRuntime;

public class IfInputControllerL : MonoBehaviour
{
    
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TextMeshProUGUI output;
    
    void Update()
    {
        output.text = Numfilter(input.text);
    }

    string Numfilter(string s)
    {
        if (int.TryParse(s, out int o))

        return o.ToString();

        else

        return "";
    
    }
}
