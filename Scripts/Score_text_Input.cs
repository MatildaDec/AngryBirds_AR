using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//���������� ��� ����������

public class Score_text_Input : MonoBehaviour
{
    public Text text_score;
    // Update is called once per frame
    void Update()
    {
        text_score.text = Score_player.instance.score + " scores";//������ ����� �����
    }
}
