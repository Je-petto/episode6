using UnityEngine;
using NaughtyAttributes;

public class Switch2 : MonoBehaviour
{
    [Space(10)]

    [Foldout("신호등오브젝트")]
    [SerializeField] private GameObject red;
    [Foldout("신호등오브젝트")]
    [SerializeField] private GameObject yellow;
    [Foldout("신호등오브젝트")]
    [SerializeField] private GameObject green;


    bool signalr;
    bool signaly;
    bool signalg;

    [Button]
    void Red()
    {
        // 토글 : ! 반대로 스위치 (True <=> False)
        signalr = !signalr;
        red.SetActive(signalr);
    }
    [Button]
    void Yellow()
    {
        signaly = !signaly;
        yellow.SetActive(signaly);
    }
    [Button]
    void Green()
    {
        signalg = !signalg;
        green.SetActive(signalg);
    }
    public int A;
    
    [Button("신호등켜기/끄기")]
    void Signal()
    {
        //모두키기
        //red.SetActive(true);
        //yellow.SetActive(true);
        //green.SetActive(true);
        
        // % 나머지 연산 = 반복성 연출
        
        int r = ++A % 3;
        
        //only red
        if(r == 0)
        {
            red.SetActive(true);
            yellow.SetActive(false);
            green.SetActive(false);
        }
        else if(r == 1)
        {
            red.SetActive(false);
            yellow.SetActive(true);
            green.SetActive(false);
        }
        else if(r == 2)
        {
            red.SetActive(false);
            yellow.SetActive(false);
            green.SetActive(true);
        }
        else
        {
            red.SetActive(false);
            yellow.SetActive(false);
            green.SetActive(false);
        }
        //only yellow
        //red.SetActive(false);
        //yellow.SetActive(true);
        //green.SetActive(false);


    }



}
