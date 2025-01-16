using System.Collections;
using NaughtyAttributes;
using UnityEngine;

public class while1 : MonoBehaviour
{

    // async Task Start()
    // {
    //     _ = Foo();
    // }


    // for ( 초기값; 종료조건; 증감; )

    // if (조건)

    // 조건이 참이면 무한루프
    // while ( 종료조건 )
    // {
    //    참이면 실행
    //    한번이라도 거짓이면 탈출
    // }
    

    //버튼 만들고
    //WhileLoop5 함수 만들고
    //5번 실행 출력

    [Button]
    void WhileLoop5()
    {
        int a = 0; // 초기값 설정
        
        // while의 목적 ( 탈출조건 )
        while ( a++ < 5 ) 
        {
            // 조건이 참이면 실행 ( 5 보다 작으면 )
            Debug.Log($"실행 {a}");
            // 5보다 크면 탈출

//            a++;         
        }
    }

    public bool isLoop;

    [Button]
    void WhileProfit()
    {
        // while ( isLoop )
        // {
        //     Debug.Log($" while 루프 중 ... ");
        // }
    }



    // 함수 Function , Method , Subroutine
    // Coroutine

    [Button("코루틴 루프")]
    IEnumerator WhileLoopCoroutine()
    {
        while ( isLoop )
        {
            Debug.Log($" while 루프 중 ... Coroutine 방식");            
            yield return new WaitForSeconds(1f);
        }
    }


    [Button("Awaitable 루프")]
    async Awaitable WhileLoopAwaitable()
    {
        while ( isLoop )
        {
            Debug.Log($" while 루프 중 ... Awaitable 방식");
            await Awaitable.WaitForSecondsAsync(0.75f);
        }
        
    }       

    
}