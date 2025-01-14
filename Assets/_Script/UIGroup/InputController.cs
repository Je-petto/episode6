using UnityEngine;
using TMPro;

public class InputController : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI output_field;
    [SerializeField] private TMP_InputField input_field;

   
    void Update()
    {
        output_field.text = input_field.text;
    }
}
