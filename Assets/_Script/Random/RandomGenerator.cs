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
        float result = Random.Range(0.0f, 100.0f);
        if (result < percent)
        {
            Debug.Log($"{percent}확률로 성공");
        }
        else
        {
            Debug.Log($"실패");
        }
    }

    [Space(10)]

    [ReadOnly] public int accumulatedCnt;
    [ReadOnly] public long accumulatedAttemptCnt;
    [ReadOnly] public float accumulatedAverage;
    [ReadOnly] public float accumulatedPercent;



    void CalcAccumulatedPercent(int attemptcnt)
    {
        accumulatedCnt += 1;
        accumulatedAttemptCnt += attemptcnt;

        accumulatedAverage = (float)accumulatedAttemptCnt / accumulatedCnt;
        accumulatedPercent = (float)accumulatedCnt / accumulatedAttemptCnt * 100;
    }
    [Button]
    void ClearAccumulated()
    {
        accumulatedCnt = 0;
        accumulatedAttemptCnt = 0;
        accumulatedAverage = 0.0f;
        accumulatedPercent = 0.0f;
    }

    [Button]
    void ProbabilityByRange()
    {
        float probability = (float)numerator / denominator;
        percent = probability * 100;

        int attemptCnt = 0;
        string log = "";

        while (true)
        {
            attemptCnt++;

            float rnd = Random.Range(0f, 100f);

            if (rnd <= percent)
            {
                string result = $"<color=green>시도횟수: {attemptCnt}, 성공: {rnd:F4} </color> {log}";
                Debug.Log(result);
                break;
            }
            else
            {
                log += $", {rnd:F1}";
            }
        }

        CalcAccumulatedPercent(attemptCnt);
    }

    [HorizontalLine(height: 2, color: EColor.Blue)] public int loopRange;
    [Button]
    void ProbabilityLoopRange()
    {
        for (int a = 0; a < loopRange; a++)
            ProbabilityByRange();
    }
}
