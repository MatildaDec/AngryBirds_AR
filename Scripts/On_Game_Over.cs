using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//библиотека для переключения сцен

public class On_Game_Over : MonoBehaviour
{
    private void OnEnable()//подписка
    {
        Delegate_Game_over.OnScore += Scene_Game_Over;
    }
    private void OnDisable()//отписка
    {
        Delegate_Game_over.OnScore -= Scene_Game_Over;
    }
    IEnumerator Wait_bird_fly()//подождать пока птичка долетит
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadSceneAsync(5);
    }
    public void Scene_Game_Over()//перемещение на сцену проигрыша
    {
        StartCoroutine(Wait_bird_fly());
    }
}
