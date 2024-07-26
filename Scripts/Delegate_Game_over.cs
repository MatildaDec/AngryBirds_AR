using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_Game_over : MonoBehaviour
{
    public delegate void GameOver();//делегат
    public static GameOver OnScore;//событие
    // Update is called once per frame
    void Update()
    {
        if(Score_player.instance.bird==3)//если все пптички кинуты
        {
            Score_player.instance.bird = 0;
            OnScore?.Invoke();//вызов события
        }
    }
}
