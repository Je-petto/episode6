using UnityEngine;
using TMPro;

//단순 바인딩이면 같은 코드를 코드용 오브젝트에 추가하는 것이 아닌
//연결하고자하는 오브젝트의 상위 계층에 Add Component를 하여 연결하고자하는 하위계층에 연결 가능
public class IfInputController : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI output_field;
    [SerializeField] private TMP_InputField input_field;

   //입력을 받되, 문자는 패스, 숫자만 입력 후 전달
   // NumFilter
    void Update()
    {
        //output_field.text = input_field.text;

        output_field.text = NumFilter(input_field.text);

    }

    // 입력 : 문자(string) -> 출력 : 숫자(int)
    //string으로 바꾸고 싶으면 .ToString()을 사용
    private int _temp;
    string NumFilter(string s)
    {
        //return int.Parse(input_field);
        //return int.Parse(s).ToString();

        //참 일 경우 실행
        if (int.TryParse(s, out int o))
        {
            _temp = o;
            return o.ToString();
        }
        //거짓일 경우
        else
        {
            return _temp.ToString();
        }

    }
}
