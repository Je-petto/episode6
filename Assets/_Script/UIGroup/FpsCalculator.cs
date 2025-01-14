//네임스페이스 영역
using UnityEngine;
using TMPro;

// 클래스 영역 : 클래스의 부모 클래스
public class FpsCalculator : MonoBehaviour
{
    //멤버 변수 영역
    [Header("FPS CALCULATOR")]
    [SerializeField] private TextMeshProUGUI tmFps;

    //[Header("FPS VALUE")]
    //[SerializeField] private int fpscvalue;


    private float dt = 0.0f;
    

    // 멤버 함수 영역
    // Start()는 MonoBehaviour에 미리 선언된 함수 : 1번만 실행
    void Update()
    {
        // FPS 구하는 공식
        dt += (Time.deltaTime-dt) * 0.1f;
        int fps =  (int)(1.0f / dt);
        
        tmFps.text = $"<size=80%>FPS</size> : {fps}";
    }
}
