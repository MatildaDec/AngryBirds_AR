using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_bird : MonoBehaviour
{
    public GameObject bird_red;//������� ������
    public GameObject bird_yellow;//������ ������
    public GameObject black;//������ ������
    public GameObject red_button;//������� ������
    public GameObject yellow_button;//������ ������
    public GameObject black_button;//������ ������
    public AudioSource button;//���� ������
    public void bird_red_button()//������ ��� ������� ������
    {
        button.Play();
        bird_red.SetActive(true);
        Destroy(red_button);
    }
    public void bird_yellow_button()//������ ��� ������ ������
    {
        button.Play();
        bird_yellow.SetActive(true);     
        Destroy(yellow_button);
    }
    public void bird_black_button()//������ ��� ������ ������
    {
        button.Play();
        black.SetActive(true);
        Destroy(black_button);
    }
}
