using System.Runtime.CompilerServices;
using NaughtyAttributes;
using UnityEngine;

public class while1 : MonoBehaviour
{
    //for (초기값; 종료조건; 증감 )
    //조건만 참이면 무한루프
    //while (종료조건)
    //{
    //  참이면 실행
    //  한번이라도 거짓이면 탈출
    //}
    // 무한루프를 목적으로 하며 어떠한 기점에서 탈출을 요구할 때 좋음

    //버튼 만들고
    //whileloop5 함수 만들고
    //5번 실행출력

    [Button("WhileLoop5")]
    void WhileLoop5()
    {
        //변수 구조에 다 맞춰야 함 - float면 모든 값을 float로
        float a = 0.0f; 
        //while은 안에 있는 영역에만 관심을 보유하고 있음
        while( a < 5.0f)
        {
            Debug.Log($"{a}");
            a = a + 0.5f;
        }
    }
    [SerializeField] private bool isLoop;

    void WhileProfit()
    {
        
        while(isLoop)
        {
            Debug.Log($" while 루프 중...");
        }
    }
}
