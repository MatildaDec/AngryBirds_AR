using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_Game_over : MonoBehaviour
{
    public delegate void GameOver();//�������
    public static GameOver OnScore;//�������
    // Update is called once per frame
    void Update()
    {
        if(Score_player.instance.bird==3)//���� ��� ������� ������
        {
            Score_player.instance.bird = 0;
            OnScore?.Invoke();//����� �������
        }
    }
}
