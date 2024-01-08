using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGameObject : MonoBehaviour
{
    public int Hp = 30000; 
    public Vector3 pos = Vector3.zero;
    public float MoveSpeed = 1.0f;

    void Start()
    {
        Hp = 50;
        Debug.Log("체력이 정해짐");
        pos = new Vector3(0.0f, 5.0f, 0.0f);
        transform.position = pos;
    }


    void Update()
    {
        MoveCube();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hp -= 1;
            Debug.Log("-1");
        }

        
    }
    public void MoveCube()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0.0f, MoveSpeed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.position += new Vector3(0.0f, -MoveSpeed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
