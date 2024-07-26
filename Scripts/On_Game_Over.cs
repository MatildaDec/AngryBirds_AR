using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//���������� ��� ������������ ����

public class On_Game_Over : MonoBehaviour
{
    private void OnEnable()//��������
    {
        Delegate_Game_over.OnScore += Scene_Game_Over;
    }
    private void OnDisable()//�������
    {
        Delegate_Game_over.OnScore -= Scene_Game_Over;
    }
    IEnumerator Wait_bird_fly()//��������� ���� ������ �������
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadSceneAsync(5);
    }
    public void Scene_Game_Over()//����������� �� ����� ���������
    {
        StartCoroutine(Wait_bird_fly());
    }
}
