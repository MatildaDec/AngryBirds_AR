using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_player : MonoBehaviour
{
    public static Score_player instance;//��������
    public int score;//���� ������
    public int bird=0;//���� ������ ������� ��� ����
    // Start is called before the first frame update
    void Start()
    {
        //�������� ��� �� ������ �� ����� �������� � ���� ��������
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
    }

    
}
