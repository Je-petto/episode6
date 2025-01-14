using UnityEngine;
using NaughtyAttributes;

public class Switch3 : MonoBehaviour
{
    [SerializeField] private Color HPFull;
    [SerializeField] private Color HPMid;
    [SerializeField] private Color HPLow;
    [SerializeField] private Color HP0;   
    [SerializeField] private int HP;
    [SerializeField] private int Damage;
    [SerializeField] private int Heal;
    
    //GetComponent<MeshRenderer>().material.color = transparent; materical.color 값에 해당 색갈 값을 대입시키겠다
    //GetComponent<MeshRenderer>().material.color = Color.red; - rgb값을 정하여 대입도 가능
    //Color.색 = 정해진 rgb값을 대입 or 변수로 정해준 값을 대입시킬 수 있음    
    [Button("Change Color")]
    void ChangeColor()
    {
        Color col;
        
        if(HP> 70)
            col = HPFull;
        else if(HP > 40)
            col = HPMid;
        else if(HP > 0)
            col = HPLow;
        else
            col = HP0;

        GetComponent<MeshRenderer>().material.color = col;
        //연산을 먼저 해주고 최종적인 값을 전달할 때는 값을 전달해줘야 하는 코드는 아래에 두기
        //GetComponent<MeshRenderer>().material.color = col; - 색 변환 기본 코드
        

    }
    
    [Button("ChangeColorSwitch")]
    void ChangeColorSwitch()
    {
        Color col = HP switch
        {
            
        > 70 => HPFull,
        > 40 => HPMid,
        > 0 => HPLow,
        _ => HP0
        };

        GetComponent<MeshRenderer>().material.color = col;
    }
    [Button("Damage")]
    void damage()
    {
        
        HP = HP - Damage;
        // HP -= Damage 위와 동일
        //내가 한 닶: int HP = HP - Damage;
        // 나오는 값에 int와 같은 규정을 더하면 멤버변수에서 지역변수로 바뀜
        
        Debug.Log(HP);
        //
        ChangeColorSwitch();

        //hp가 최소 0에서 멈추게 한다
        //=HP가 0 이하입니까? True면 0 고정,  False면 패스
        //Else가 따로 처리할 값이 없으면 else에 뭔가를 기입할 필요가 없다
        if(HP == 0)
            HP = 0;
        //삼향연산으로
        // 변수 = 조건 ? 참 : 거짓
        HP = HP <= 0 ? HP = 0 : HP;
        //2) int HPStatus = (HP > 0) ? HP : 0 ;
        //   Debug.Log(HPStatus);
        GetComponent<MeshRenderer>().material.SetFloat("_Fade", (float)HP/100);

    }
    [Button("Heal")]
    void heal()
    {
        HP = HP + Heal;
        Debug.Log(HP);
        ChangeColorSwitch();

        //if(HP >= 100)
        //    HP = 100;

        HP = HP >= 100 ? HP = 100 : HP;
        GetComponent<MeshRenderer>().material.SetFloat("_Fade", (float)HP/100);
    }
}
