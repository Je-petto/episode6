using System;
using NaughtyAttributes;
using UnityEngine;

public class IFAttribute : MonoBehaviour
{
    [Header("타이틀")]
    //Inpector에 선으로 구역을 나누어줌
    [HorizontalLine(height:3, color:EColor.Red)]
    [Space(5)]
    [HideInInspector] public bool _l0;

    
    //묶음으로 엮어 엮인 요소들을 하나의 폴더로 묶어 가릴 수 있게 함
    //폴더에 넣으려고 하는 모든 요소들을 다 묶어야 함
    //[Foldout("속성창")]

    //하나의 그룹으로 묶어줌
    //폴더처럼 숨기게 하는 건 불가능
    [BoxGroup("")]
    [SerializeField] private int A;
    [BoxGroup("")]
    [SerializeField] private int B;
    [BoxGroup("")]
    [SerializeField] private int C;
    [BoxGroup("")]
    [SerializeField] private bool D;
    [BoxGroup("")]
    [SerializeField] private bool E;

    [Button("버튼")]
    void OperatorEx()
    {
        //A = B; A에 B의 값을 대입
        //A == B; 같으면 true or false
        //A != B; 다르면 true or false
        //A += B; A = A + B;

        //A++; 풀어쓰면 A = A + 1; 후행 연산(가장 마지막에)
        //A--; A = A - 1;

        // ++B; 풀어 쓰면 B = 1 + B; 선행 연산(가장 처음으로)
        //C = 0;
        //A = 3;
        //B = 4;
        //C = A + B++ ;// A + B 더하고, C에 더한 값을 넣어주고 , B+1
        
        //string a = "영희 ";
        //string b = "Lv 100";
        //string c = a += b;
        //Debug.Log에 'a += b'를 바로 넣으면 a += b로 연산된 값인 영희 lv100에 B값인 lv100이 추가로 다시 연산되어 나온다.
        //따라서 이미 연산과정이 이루어진 값을 대입시키고자 한다면, 다른 이름에 그 값만 온전히 대입되도록 해주어야 한다. 
        
    }

    [Button("요일")]
    void DayOfWeek()
    {
        if(A == 1)
        {
            Debug.Log("월요일");
        }
        else if(A == 2)
        {
            Debug.Log("수요일");
        }
        else if(A == 3)
        {
            Debug.Log("금요일");
        }
        else
        {
            Debug.Log("일요일");
        }
    }

    [Button("삼향연산 (왼쪽, 오른쪽)")]
    void TernaryOperation()
    {
        // 조건이 하나일 때
        // 결과 = 조건 ? 참 : 거짓;

        // 조건이 여러개 있을 때
        //        if(조건1)
        //        {
        //            참
        //        }
        //        else if(조건2)
        //        {
        //            참
        //        }        
        //        else
        //        {
        //            거짓
        //        }

        // D 가 참이면 왼쪽, 거짓 오른쪽
        //if 함수 사용
        if(D == true)
        {
            Debug.Log("왼쪽");
        }
        else
        {
            Debug.Log("오른쪽");
        }
        // 연산값으로 bool의 참 거짓을 표현하게 하는 공식 *외워야함 
        string result = D ? "왼쪽" : "오른쪽";      
    
    }

    // A가 3 이상이고 9미만, 또는 B가 5초과 이고 10이하
    //참이면 참, 거짓이면 거짓
    [Button("삼향연산(이고, 또는)")]
    void TernaryOp()
    {
       
       E = (A >= 3 && A <=9) || (B > 5 && B <= 10);
       string result = E ? "참" : "거짓";

       Debug.Log(result);

    }


}
