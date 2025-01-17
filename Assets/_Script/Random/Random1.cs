using UnityEngine;
using NaughtyAttributes;
using NUnit.Framework.Interfaces;

public class Random1 : MonoBehaviour
{

    //[SerializeField] int Seed;
    void Start()
    {
        // static(정적인) <-> dynamic(동적인)
        // static의 목적, 용도: 유틸리티 (도구로 활용)

        //맨 위에 있는 유니티 자체 제공 Random 사용
        // .Net Framework 제공 Random
    }

    [Button()]
    void RandomRange()
    {
        //Random.InitState(Seed); -> 특정 값으로 정해져 나오게끔 함
        //Debug.Log($"랜덤(int) = {Random.Range(1, 10)}");
        //Debug.Log($"랜덤(float) = {Random.Range(0.5f, 1.5f):F2}"); 
        //Range 안에 float를 집어넣으면 range의 범위가 float로 바뀜, :F(숫자) = float의 소숫점 (숫자)자리까지 적용한다, Debug.Log()로 숫자를 표시할때만 달아줄 수 있다

        // value 증폭(value의 range를 확대) 후 실현
        //Random.value; 기본값을 단위 수치(0.0f - 1.0f)설정해서 출력

        //Debug.Log($"랜덤(value) = {Random.value}");

        //특정 범위 내에서 랜덤하게 생성되게끔하기
        //Random.insideUnitCircle - 프로퍼티(Property) = 속성/2D 용 랜덤 생성(x -1.0f ~ 1.0f, y ...)
        //Random.insideUnitSphere - 3D 용 랜덤 생성(x -1.0f ~ 1.0f, y ..., z...)

        // Random float 1개 출력 : value
        // Random float 2개 출력 : UnitCircle : Vector2
        // Random float 3개 출력 : UnitSphere : Vector3
        //: Vector4 == Color(r,g,b,a)
    }
    // 멤버 변수에 입력한 숫자가 안나오도록
    // 1~10 까지 
    [SerializeField] int excludenum;
    [Button()]
    void RandomExclude()
    {
        //1포함, 11 미포함
        int result = Random.Range(1, 11);
        //excludenum이 안나오도론
        if (result != excludenum)
        {
            Debug.Log($"랜덤의 결과 = {result}");
        }
        else
        {
            //Debug.Log($"재외 번호 {excludenum} 출력");
            RandomExclude();
        }
    }

    // 5% 확률로, 입력한 숫자가 나오도록
    // 시도횟수
    // 결론 : n번째 시도 끝에, 입력한 숫자 출력 : ? %확률
    [SerializeField] int insertnum;
    [SerializeField] int probability;
    [SerializeField] int attempt;
    [Button]
    void RandomRate()
    {
        // float형 1개 (float는 이미 0.xxx ~1) => 퍼센트

        float result = Random.value * 100f; //100f를 곱함으로서 퍼센트가 정수로 표시되게끔 바뀌게 함
        Debug.Log($"랜덤(Value) = {result}");

        if (result <= 5f)
        {
            Debug.Log($"당첨");
        }
        else
        {
            Debug.Log($"실패");
        }

    }
}

