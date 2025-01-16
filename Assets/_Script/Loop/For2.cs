using UnityEngine;
using NaughtyAttributes;

public class For2 : MonoBehaviour
{
    // 1부터 10까지 더하기를 매 루프마다 출력
    // 값이 누적이 된다
    //함수명은 Add1to10

    [Button("Add1to10")]
    void Add1to10()
    {
        int sum = 0;

        for(int a =1 ; a <= 10; a++)
        {
            sum = sum + a;
            Debug.Log($"a = {a}, sum = {sum}");
        }
    }
    
    
    // 3 % 2 = 몫1 나머지1
    // 4 % 2 = 몫2 나머지0
    // 5 % 2 = 몫2 나머지1
    // 6 % 2 = 몫3 나머지0
    // 홀수는 , % 2 로 나머지가 1 이면 홀수
    // 항상 함수의 조건을 먼저 생각하여 확인하고 진행

    // 30부터 1까지 역순출력
    // 홀수만 출력 
    // Odd30to1()

    // 최종 홀수의 갯수 출력
    [Button("Odd30to1")]
    void Odd30to1()
    {
        
        
        for(int a=30; a>=1; a--)
        {
            if (a%2 == 1)
            {
                Debug.Log(a);
            }
            //if 함수에서 else가 if와 대비되는 조건이 1개밖에 없고 표시하고 싶지 않을 때 생략 가능

        }


    }

}
