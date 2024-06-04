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
    //�d�͑��x(1���ő�l)
    float _gravitySpeed;

    // Start is called before the first frame update
    void Start()
    {
        //���̐ݒ�
        //�Q�[���I�u�W�F�N�g�̎擾�����C�ɂ����W�܂Ŏ擾
        _floorY= GameObject.Find("Floor").transform.position.y;
        _floorSize = 1.8f;//���̃T�C�Y
        _delSize = _floorY + _delSize;

        //�d�͂̐ݒ�
        _gravitySpeed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        //���ɓ������Ă邩�̔���
        if (this.transform.position.y < _delSize)
        {
            _hitFloorFlag = true;
        }
        else
        {
            _hitFloorFlag = false;
        }


        //���ɓ������Ă��Ȃ��Ȃ�A����
        if (_hitFloorFlag == false)
        {
            this.transform.position += Vector3.down * _gravitySpeed;
        }
    }
}
