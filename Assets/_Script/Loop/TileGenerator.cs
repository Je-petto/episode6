using UnityEngine;
using NaughtyAttributes;

public class TileGenerator : MonoBehaviour
{


    [Foldout("프리팹")]
    public GameObject tilePrefab;

    public int horzCnt;
    public int vertCnt;
    public int floor;
    public float gap;

    //int n
    //n수만큼 x 축으로 순차적으로 생성되게 한다.
    //인스턴스 ? 객체, 오브젝트
    //클래스 틀(template)에서 생성된 제품 중 하나
    // new Vector3(1f, 0f, 0f) - 새로 생성되는 제품 좌표
    //GameObject.Instantiate(tilePrefab, new Vector3(x, 0f, z), Quaternion.identity);
    //}

    [Button]
    void PutIn()
    {

        GameObject Empty = new GameObject("Group");

        // 가로 X 세로 배치한다
        // (옵션1) 2중 for 문 활용할 수 있다
        // (옵션2) 단일 for 문 카운트를 더 늘려서 할 수 있다(줄 바꿈)
        for (int h = 0; h < horzCnt; h++)
        {
            //h = 0부터 시작하여 그 h의 값이 v로 대입되어 v와 연결되어 있는 for부터 대입
            for (int v = 0; v < vertCnt; v++)
            {
                for (int f = 0; f < floor; f++)
                {

                    GameObject o = Instantiate(tilePrefab, new Vector3(h+gap, f+(gap/3), v+gap), Quaternion.identity);
                    o.transform.SetParent(Empty.transform);
                }
            }

            //for (int c = 0; c < floor; c++)
            //{
            //    Instantiate(tilePrefab, new Vector3(x, c, b), Quaternion.identity);
            //}

        }
        // *함수 만들기 전 규칙성 찾아보기*
        //0,0 => gap;2 =>0,0
        //1,0 => gap;2 =>2,0
        //2,0 => gap;2 =>4,0

        //0,0 => +2 =>2,0
        //1,0 => +2 =>3,0
        //2,0 => +2 =>4,0

        //1,0 => X2 =>2,0
        //2,0 => x2 =>4,0

        //0,0
        //1,0
        //2,0
        //3,0


    }


}
