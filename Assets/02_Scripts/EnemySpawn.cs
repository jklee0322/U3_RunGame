using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    /* ��ֹ��� ��ġ�Ǿ� �ִ� ���������� �迭�� �����Ҷ�
     * �� ������������ �������� ���� ���ҽ��� Ŀ���� �˴ϴ�.
     * �׷��� �� �������� �����ϴ� ������ �����Ͽ� ���ҽ��� ���̴� ����Դϴ�.
     * */
    public GameObject prefab;
    private void Awake()
    {
        //�ν����� â�� �־���� �������� �����ϴ� �ڵ�
        GameObject go = (GameObject)Instantiate(prefab, Vector3.zero, Quaternion.identity);
        //�������� ���� �ɶ� ��ü �����ǵ��� ��Ʈ ����
        go.transform.SetParent(transform, false);
    }

    
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        //��ġ��ġ�� �� ���� ���� ���ϰ� �뷫���� ��ġ�� ���� �� �ְ� �Լ� ���

        //����� �Ʒ��κ� ����� ���� ���� �����ϴ� ��
        Vector3 offset = new Vector3(0, 0.5f, 0);
        //���Ǿ� �� ���� �� ��ġ ���
        Gizmos.color = new Color(0, 1, 1, 0.5f);    //�� ������
        Gizmos.DrawSphere(transform.position + offset, 0.5f);
        //�����տ� �־����ִ��� ���� üũ
        if(prefab!=null)
        {
            Gizmos.DrawIcon(transform.position + offset, prefab.name, true);
        }
    }
}
