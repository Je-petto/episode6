using UnityEngine;
using TMPro;

public class IfInputControllerR : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TextMeshProUGUI output;

    
    void Update()
    {
        output.text = input.text;
    }
}
