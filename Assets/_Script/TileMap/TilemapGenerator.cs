using System.IO.Compression;
using NaughtyAttributes;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    [Header("하이트맵 소스")]
    [SerializeField] Texture2D heightmap;
    [SerializeField] GameObject tilePrefab; // 지형 프리팹
    [SerializeField] GameObject treePrefab; // 나무 프리팹
    
    [Header("하이트맵 속성")]
    [MinValue(0.0f), MaxValue(50.0f)]
    [SerializeField] float heightRange;
    [SerializeField] float Treeoffset; //Offset = 추가값




    [Button]
    void Getinfo()
    {
        int w = heightmap.width; // = Horizontal(가로)
        int h = heightmap.height; // = Vertical(세로)
        Debug.Log($"width = {w}, height = {h}");

        //루프문으로 w,h 크기만큼 반복하면서
        //반환값(Color)을 콘솔에 출력 -> Debug.Log()사용

        // 문제
        // col.r이 0.5를 기준으로 크면 (x,y,z) y를 1로 판단
        // col.r이 0.5를 기준으로 작으면 (x,y,z) y를 0로 판단
        // instantiate 함수를 활용하여 cube 프리팹을 생성한다
        for (int x = 0; x < w; x++)
        {
            for (int z = 0; z < h; z++)
            {
                Color col = heightmap.GetPixel(x, z);
                Debug.Log($"컬러 = {col}");

            }

        }

        // col (r,g,b,a)
        // r : 레벨을 디자인
        // g : 나무 심기
        // b : 몹 배치
        // a : Start , Goal

        // col을 추가하여 4가지 요소를 더욱 추가할 수 있음


    }

    [Button("DO NOT PRESS")]
    void BuildMap()
    {
        // width , height만큼 루프를 돌린다
        // GetPixel() col.r을 구한다
        // col.r을 기준으로 Instantiate 할 때, y값을 성정해준다.
        // Cube 월드를 만든다(큐브, size Y 0.5f => 5.0f로)
        int w = heightmap.width;//가로길이
        int h = heightmap.height;//세로길이
        
        GameObject Empty = new GameObject("TileGroup");

        for (int x = 0; x < w; x++)
        {
            for (int z = 0; z < h; z++)
            {
                Color col = heightmap.GetPixel(x, z);

                float y = col.r * heightRange;

                // col 값에 노이즈가 섞여 있어서 0과 1로 정확하게 나오지 않아 if 함수를 이용하여 구별한 방법
                // 아래 BuildMap에서는 이러한 경우가 필요 없다.
                if (col.r > 0.5f)
                {
                    GameObject o = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity);
                    o.transform.SetParent(Empty.transform);
                }    
                else if (col.r < 0.5f)
                {
                    GameObject o = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity);
                    o.transform.SetParent(Empty.transform);
                }
                //GameObject o = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity);
                //o.transform.SetParent(Empty.transform);
            }
        }

    }
    [Button]
    void BuildMap2()
    {
        // width , height만큼 루프를 돌린다
        // GetPixel() col.r을 구한다
        // col.r을 기준으로 Instantiate 할 때, y값을 성정해준다.
        // Cube 월드를 만든다(큐브, size Y 0.5f => 5.0f로)
        int w = heightmap.width;//가로길이 - 가로로 몇 개의 픽셀이 존재하는지
        int h = heightmap.height;//세로길이 - 세로로 몇 개의 픽셀이 존재하는지
        
        GameObject Empty = new GameObject("TileGroup");

        for (int x = 0; x < w; x++)
        {
            for (int z = 0; z < h; z++)
            {
                Color col = heightmap.GetPixel(x, z);
                // col의 범위 (최소 : 0.0f ~ 최대 : 1.0f)
                // col은 플로트 값으로 도출된다

                //Red 채널만 활용 : 동고선 표현
                // 컬러의 r 채널을 높이값으로 활용
                float y = col.r * heightRange;

                
                GameObject o = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity);
                o.transform.SetParent(Empty.transform);
                    

                if( col.g != 0.0f )
                {
                // Green 채널만 활용 : 나무를 심는다
                    GameObject trees = Instantiate(treePrefab, new Vector3(x, y + Treeoffset, z), Quaternion.identity);
                    trees.transform.SetParent(Empty.transform);
                }

                //GameObject o = Instantiate(tilePrefab, new Vector3(x, y, z), Quaternion.identity);
                //o.transform.SetParent(Empty.transform);
            }
        }

    }
}
