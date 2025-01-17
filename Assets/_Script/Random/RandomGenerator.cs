using UnityEngine;
using NaughtyAttributes;

public class RandomGenerator : MonoBehaviour
{
    
    [SerializeField] int numerator; //분자
    [SerializeField] int denominator; //분모
    [ReadOnly][SerializeField] float percent; // 분자/분모 * 100f

    [Button]
    void GenerateByRange()
    {
        float probability = (float)numerator / denominator; //numerator와 denominator는 int이기 때문에 float로 바뀔 수 있게끔 해줘야 한다
        percent = probability * 100f;

        Debug.Log($"확률 = {percent}%");

        // 랜덤 발생 후, 성공 실패 판단

        //float result = Random.value * 100f;
        float result = Random.Range(0.0f,100.0f);
        if (result < percent)
        {
            Debug.Log($"{percent}확률로 성공");
        }
        else
        {
            Debug.Log($"실패");
        }
    }
}
