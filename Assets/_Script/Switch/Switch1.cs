using UnityEngine;
using NaughtyAttributes;

//ctrl + k + f =코딩 줄 관리
// switch (조건)
// {
//  case 해당조건1 :
//       작업
//       break;

//  case 해당조건2 :
//       작업
//       break;

//  default 아닐경우 :
//       break;
// }

public class Switch1 : MonoBehaviour
{
    [SerializeField] private int A;

    [Button]
    void SwitchDayWeek()
    {
        // a가 1이면 월요일, 2면 수요일, 3이면 금요일, 4이면 일요일, 그외는 잘못 입력
        switch (A) // 변수 자체를 삽입
        {
            case 1:
                Debug.Log("월요일");
                break;
            case 2:
                Debug.Log("수요일");
                break;
            case 3:
                Debug.Log("금요일");
                break;
            case 4:
                Debug.Log("일요일");
                break;
            default:
                Debug.Log("잘못 입력");
                break;
        }


    }
    [Button]
    void NewSwitch()
    {
        string r = A switch
        {
            // =>(람다)
            1 => "월요일",
            2 => "수요일",
            3 => "금요일",
            4 => "일요일",
            // _의 의미는 '없다'
            _ => "잘못입력"
        };

        Debug.Log(r);
    }
    // 3, 4, 5 = 봄
    // 6, 7, 8 = 여름
    // 9, 10, 11 = 가을
    // 12, 1, 2 = 겨울

    [Button("계절if")]
    void Seasons()
    {
        string r;

        //줄이 하나일때는 {} 생략 가능
        if (A >= 3 && A <= 5)
            r = "봄";
        else if (A >= 6 && A <= 8)
            r = "여름";
        else if (A >= 9 && A <= 11)
            r = "가을";
        else if (A == 12 || (A >= 1 && A <= 2))
            r = "겨울";
        else
            r = "잘못입력";
        Debug.Log(r);

    }
    [Button("계절switch")]
    void Seasons2()
    {

        string rr = A switch
        {
            // 딱 떨어지는 값에 사용
            3 or 4 or 5 => "봄",
            6 or 7 or 8 => "여름",
            9 or 10 or 11 => "가을",
            12 or 1 or 2 => "겨울",
            _ => "잘못입력"
        };

        Debug.Log(rr);
    }
}
