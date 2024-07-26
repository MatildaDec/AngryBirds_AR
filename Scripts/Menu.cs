using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//���������� ��� ������������ ����
using UnityEngine.UI;//���������� ��� ����������

public class Menu : MonoBehaviour
{
    public AudioSource button;//����� ������
    public Text text_async;//����� ���������
    public Slider async_slider;//������� ��������
   IEnumerator Loaded_Async_Scene(int Loaded_Scene_Number)//����������� ��������
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Loaded_Scene_Number);
        operation.allowSceneActivation = false;
        async_slider.gameObject.SetActive(true);
        async_slider.value = operation.progress;
        while(!operation.isDone)
        {
            if(operation.progress>=0.9f && !operation.allowSceneActivation)
            {
                text_async.gameObject.SetActive(true);
                if(Input.anyKeyDown)
                {
                    operation.allowSceneActivation = true;
                }
            }
            yield return null;
        }
        
    }
    public void Play_button()//������ ������
    {
        button.Play();
        SceneManager.LoadSceneAsync(1);
    }
    public void Level_Scene_button(int Loaded_Scene_Number)//������ ������� ������
    {
        button.Play();
        StartCoroutine(Loaded_Async_Scene(Loaded_Scene_Number));
    }
    public void Exit_button()//������ ������
    {
        button.Play();
        Application.Quit();
    }
    public void Back_button()//������ �����
    {
        button.Play();
        SceneManager.LoadSceneAsync(0);
    }
}
