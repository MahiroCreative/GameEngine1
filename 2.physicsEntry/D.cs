using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour
{
    float time = 0;//[/f]
    float firstSpeed = -0.02f; //[/f]
    float accel = 0.0001f;//[/f]
    float firstX;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        firstX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //���ԍX�V
        time++;

        //���������̉^���̎�
        //this.transform.position = 1 / 2 * vaccel * time * time + vspeed * time;
        x = 0.5f * accel * time * time + firstSpeed * time + firstX;

        //�x�N�g���ϊ������āA���݂̍��W�ɑ��
        this.transform.position = new Vector3(x, 0, 0);
    }
}
