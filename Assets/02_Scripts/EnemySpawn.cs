using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    /* 장애물이 배치되어 있는 스테이지를 배열로 관리할때
     * 각 스테이지마다 프리팹이 들어가서 리소스가 커지게 됩니다.
     * 그래서 한 프리팹을 참조하는 식으로 변경하여 리소스를 줄이는 방법입니다.
     * */
    public GameObject prefab;
    private void Awake()
    {
        //인스펙터 창에 넣어놓는 프리팹을 생성하는 코드
        GameObject go = (GameObject)Instantiate(prefab, Vector3.zero, Quaternion.identity);
        //스테이지 삭제 될때 전체 삭제되도록 세트 설정
        go.transform.SetParent(transform, false);
    }

    
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        //배치위치를 한 눈에 보기 편하고 대략적인 위치를 정할 수 있게 함수 사용

        //기즈모 아랫부분 지면과 같은 높이 설정하는 값
        Vector3 offset = new Vector3(0, 0.5f, 0);
        //스피어 색 설정 및 위치 잡기
        Gizmos.color = new Color(0, 1, 1, 0.5f);    //색 자유로
        Gizmos.DrawSphere(transform.position + offset, 0.5f);
        //프리팹에 넣어져있는지 예외 체크
        if(prefab!=null)
        {
            Gizmos.DrawIcon(transform.position + offset, prefab.name, true);
        }
    }
}
