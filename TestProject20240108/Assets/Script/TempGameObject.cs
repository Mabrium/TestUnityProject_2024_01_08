using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGameObject : MonoBehaviour
{
    public int Hp = 30000; 

    void Start()
    {
        Hp = 50;
        Debug.Log("ü���� ������");
    }

      
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Hp -= 1;
            Debug.Log("-1");
            
            if (Hp < 0)
            {
                Hp = 3000;
            }
        }
    }
}
