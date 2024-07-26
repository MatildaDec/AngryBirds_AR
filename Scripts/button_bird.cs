using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_bird : MonoBehaviour
{
    public GameObject bird_red;//красная птичка
    public GameObject bird_yellow;//желтая птичка
    public GameObject black;//черная птичка
    public GameObject red_button;//красная кнопка
    public GameObject yellow_button;//желтая кнопка
    public GameObject black_button;//черная кнопка
    public AudioSource button;//звук кнопки
    public void bird_red_button()//кнопка для красной птички
    {
        button.Play();
        bird_red.SetActive(true);
        Destroy(red_button);
    }
    public void bird_yellow_button()//кнопка для желтой птички
    {
        button.Play();
        bird_yellow.SetActive(true);     
        Destroy(yellow_button);
    }
    public void bird_black_button()//кнопка для черной птички
    {
        button.Play();
        black.SetActive(true);
        Destroy(black_button);
    }
}
