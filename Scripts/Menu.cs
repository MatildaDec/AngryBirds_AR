using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//библиотека для переключения сцен
using UnityEngine.UI;//библиотека для интерфейса

public class Menu : MonoBehaviour
{
    public AudioSource button;//аудио кнопки
    public Text text_async;//текст подсказка
    public Slider async_slider;//слайдер загрузки
   IEnumerator Loaded_Async_Scene(int Loaded_Scene_Number)//асинхронная загрузка
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
    public void Play_button()//кнопка играть
    {
        button.Play();
        SceneManager.LoadSceneAsync(1);
    }
    public void Level_Scene_button(int Loaded_Scene_Number)//кнопка каждого уровня
    {
        button.Play();
        StartCoroutine(Loaded_Async_Scene(Loaded_Scene_Number));
    }
    public void Exit_button()//кнопка выхода
    {
        button.Play();
        Application.Quit();
    }
    public void Back_button()//кнопка назад
    {
        button.Play();
        SceneManager.LoadSceneAsync(0);
    }
}
