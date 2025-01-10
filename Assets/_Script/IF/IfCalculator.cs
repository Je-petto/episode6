using UnityEngine;
using TMPro;
public class IfCalculator : MonoBehaviour
{
   
    [SerializeField] private TextMeshProUGUI tmIfResult;
    
    void Update()
    {
        tmIfResult.text = "결과";
    }
}
