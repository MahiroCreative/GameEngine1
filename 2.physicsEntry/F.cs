using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    Vector3 yPos;//�����̈ʒu(x,y)
    Vector3 speed;//�����̑��x
    Vector3 firstSpeed;//�����x
    Vector3 accel;//�����x
    Vector3 firstPos;//�ŏ��̈ʒu
    int time;//����

    // Start is called before the first frame update
    void Start()
    {
        //�ŏ��̈ʒu�̎擾
        firstPos = this.transform.position;
        //�����x
        accel = new Vector3(0,-0.00098f,0);
        //�����x
        firstSpeed = new Vector3(0, 0.1f, 0);
        //���x�ɏ����x������
        speed = firstSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        ///*�v���O���~���O�I�ȏ�����*/
        ////���x�v�Z
        ////�O��̃t���[���̑��x�ɉ����x�𑫂����ƂŁA����̃t���[���̑��x���o��B
        //speed += accel;

        ////�ʒu�̍X�V
        ////�O��̃t���[���̈ʒu�ɍ���̃t���[���̑��x�𑫂����ƂŁA����̃t���[���̈ʒu���o��B
        //this.transform.position += speed;

        /*�����̎�*/
        //1/2gt^2 + v0t + �ŏ��̈ʒu
        this.transform.position = 0.5f*accel*time*time + firstSpeed*time + firstPos;

        //�^�C�}�̍X�V
        time++;
    }
}
