using UnityEngine;
using NaughtyAttributes;

//반복문
//for
//foreach
//while
//do while

//반복을 위한 조건
// 대량생산 , 

public class For1 : MonoBehaviour
{
    // for ( 시작; 종료조건; 증감(얼마나 증가시키고 감소시키고 싶은지 - 1=++/특정 숫자=a = a+특정숫자) )
    // {
    //  반복 작업
    // }
    // 시작점과 끝점의 루프가 필요할 때 사용

    
    [Header("반복문(count만큼 반복)")]
    [HorizontalLine(height:1.0f, color:EColor.Orange)]
    [Space(5)] //Attribute
    public int count;

    void Start()
    {
        int a;        
        // for 는 if문을 지정한 수만큼 반복 작업한다
        //참이면 조건달성할 때까지 반복 - if는 한 번만
        for( a = 1; a < 4; a++ )
        {
            //참일때만 실행
            //거짓이 되면 탈출
            //처음부터 거짓이였으면 실행 x
            Debug.Log("실행");
        }
    }
      
    //버튼 만든다
    //멤버 변수에 Count를 넣어서, 지정한 수만큼 for 출력
    [Button("For1to10")]
    void For()
    {
        for(int a = 0; a < count; a++)
        {
            Debug.Log($"{a}");
        }
    }

    [Button("For10to1")]
    void For10to1()
    {
        //10부터 1까지 역순으로 출력
        for(int a = 10; a >0; a--)        
            Debug.Log($"{a}");
    
    }
}
