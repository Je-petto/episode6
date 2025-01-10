using UnityEditor.PackageManager.Requests;
using UnityEditor.ShortcutManagement;
using UnityEngine;

// if 메소드 - ( 참/거짓 )  함수 - {}
// Branch 문

public class IFtutorial : MonoBehaviour
{
   
    public int A = 16;

    //void Start()
    //{
        // and는 &&로 표시
        // '='는 항상 뒤에
        // 중간에 다른 if를 추가하기 위해서는 else if로 함수를 만들면 됨

        // A가 10 이상이고 20 미만이면 참
        //if (A >= 10 && A < 20)
        //{
            
            
            //참 = True 실행, 거짓 = 패스;
            //Debug.Log("True");
        //}
        //거짓인 부분들 표현
        //else는 가장 가까이 붙어 있는 if와만 연결된다
        //else
        //{
            
            //Debug.Log("False");

        //}

    
        //"참 = 실행, 거짓 = 패스"; 
    
        
        
    //}

    //A가 90 이상이면 A학점
    //A가 80 이상이면 B학점
    //A가 60 이상이면 C학점
    //A가 60 미만이면 F학점
    void Start()
    {
        if (A >= 90)
        {
            Debug.Log("A학점");
        }
        else if (A >= 80)
        {
            Debug.Log("B학점");
        }
        else if (A >= 60)
        {
            Debug.Log("C학점");
        }
        else
        {
            Debug.Log("F학점");
        }
    }


}
