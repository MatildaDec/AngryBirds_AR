using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_player : MonoBehaviour
{
    public static Score_player instance;//синглтон
    public int score;//счёт игрока
    public int bird=0;//счёт птичек которые уже были
    // Start is called before the first frame update
    void Start()
    {
        //проверка нет ли больше на сцене объектов с этим скриптом
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
