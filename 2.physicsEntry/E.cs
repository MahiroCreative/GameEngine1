using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
    Vector2 yPos;//�����̈ʒu(x,y)
    Vector2 speed;//�����̑��x
    Vector2 accel;//�����x
    Vector2 temp;//�v�Z���ʂ̈ꎞ�i�[
    Vector2 firstPos;
    int time;//����

    // Start is called before the first frame update
    void Start()
    {
        firstPos = this.transform.position;//�I�u�W�F�N�g�쐬���̈ʒu
        speed = new Vector2();//�[�����ꂽ
        accel = new Vector2(0,-0.00098f);
    }

    // Update is called once per frame
    void Update()
    {
        /*�����̎��I�ȏ�����*/
        ////�����Ȃ茻�ݒn���o���̎��ɒ���
        //this.transform.position = firstPos + 0.5f*accel*time*time;

        ////���Ԃ̍X�V
        //time++;

        /*�v���O���~���O���ۂ�������*/
        //���x�𖈃t���[���v�Z����
        speed += accel;//�P�ʎ��Ԃ��Ƃɉ�������̂ŉ��Z

        //�X�V
        temp = this.transform.position;//���ݒn�̑��
        temp += speed;//���ݒn�̍X�V
        this.transform.position = temp;//�I�u�W�F�N�g�Ɍv�Z���ʂ𔽉f
    }
}
