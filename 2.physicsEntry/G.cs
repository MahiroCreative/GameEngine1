using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UIElements;

public class G : MonoBehaviour
{
    Vector3 firstPos;
    Vector3 speed;
    float speedL=0.25f;
    float speedX;
    float speedY;
    float angle=Mathf.PI/6;//�΂�180�x

    // Start is called before the first frame update
    void Start()
    {
       // speed = new Vector3(0.1f,0.1f,0);

        //���x�̕���
        speedX = speedL * Mathf.Cos(angle);
        speedY = speedL * Mathf.Sin(angle);

        //�x�N�g���̑��x�̍쐬
        speed = new Vector3 (speedX, speedY, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += speed;
    }
}
