using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H : MonoBehaviour
{
    Vector3 firstPos;
    Vector3 firstSpeed;
    Vector3 gravity;
    Vector3 speed;
    Vector3 temp;
    int time;
    float speedL = 0.05f;
    float speedX;
    float speedY;
    float angle = Mathf.PI / 6;//�΂�180�x

    // Start is called before the first frame update
    void Start()
    {
        //�����x�̕���
        speedX = speedL * Mathf.Cos(angle);
        speedY = speedL * Mathf.Sin(angle);

        //�����x�̃x�N�g���̍쐬
        firstSpeed = new Vector3 (speedX, speedY, 0);

        //���x�̐ݒ�
        speed = firstSpeed;

        //�d�͉����x
        gravity = new Vector3 (0, -0.000198f,0 );

        //�x�N�g�����g��Ȃ��ق�
        temp = new Vector3 (0, 0, 0);
        firstPos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        ///*�x�N�g�����g�����v�Z*/
        //���x�̍X�V
        speed += gravity;

        //���ݒn�̍X�V
        transform.position += speed;

        ///*�x�N�g�����g��Ȃ�*/
        //temp.x = speedX * time;
        //temp.y = speedY * time + 0.5f * gravity.y * time*time;

        //���ݒn�̍X�V
        //this.transform.position = new Vector3(firstPos.x + temp.x,firstPos.y+temp.y,0);

        //�^�C�}�̍X�V
        //time++;


    }
}
