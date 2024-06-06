using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Gravity2*/
//�����̎��ɉ������������d�͂����܂��B
//�E���̎��ł̏d�̗͂���
//�E���Ԃ̓���(Fixedupdate())
//�E���x�Ɖ����x�̓���
//������Ă݂܂��B

public class StandardGravity : MonoBehaviour
{
    //���֘A
    float _floorY;
    float _floorSize;
    float _delSize;
    //����ϐ�
    bool _hitFloorFlag;//���ɓ������Ă��邩
    //�d�͂̒����ϐ�
    float _gravitySpeed;
    //���x
    float _velocityY;//Y�����̑��x
    //�����x
    float _accel;

    //�I�u�W�F�N�g�쐬���Ɉ�񂾂����s
    void Start()
    {
        //���̐ݒ�
        //�Q�[���I�u�W�F�N�g�̎擾�����C�ɂ����W�܂Ŏ擾
        _floorY= GameObject.Find("Floor").transform.position.y;
        _floorSize = 1.5f;//���̃T�C�Y
        _delSize = _floorY + _floorSize;

        //�d�͂̒����ϐ�
        _gravitySpeed = 0.04f;

        //���x�̐ݒ�
        _velocityY = 0;

        //�����x�̐ݒ�

    }


    // ���t���[���X�V(�ō����x�ōX�V�F���\�ɂ��X�V�񐔂��ς��)
    void Update()
    {
        /*�����蔻��*/
        //���ɓ������Ă邩�̔���
        if (this.transform.position.y < _delSize)
        {
            _hitFloorFlag = true;
        }
        else
        {
            _hitFloorFlag = false;
        }


        /*�d�͓���*/
        //���ɓ������Ă��Ȃ��Ȃ�A����
        if (_hitFloorFlag == false)
        {
            this.transform.position += Vector3.down * _gravitySpeed;
        }
    }

    private void FixedUpdate()
    {
        
    }
}
