using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="pig")//���� ������ � ������
        {
            Score_player.instance.score += 50;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "wall")//���� ������ � �����
        {
            Score_player.instance.score += 25;
            Destroy(other.gameObject);
        }
    }
}
