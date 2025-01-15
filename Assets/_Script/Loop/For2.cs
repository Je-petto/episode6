using UnityEngine;
using NaughtyAttributes;
using UnityEngine.UI;
using System.Globalization;

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
    
    // 30부터 1까지 역순 출력
    // 홀수만 출력
    // 홀수의 개수 파악(unclear)
    [Button("Odd30to1")]
    void Odd30to1()
    {
        
        
        for(int a=30; a>=1; a--)
        {
            if (a%2 == 1)
            {
                Debug.Log(a);
            }

        }


    }

}
