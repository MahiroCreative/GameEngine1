using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Gravity1*/
//���ɊȒP�ȏd�͂�����Ă݂܂��B
//�E���̗̂���
//�E���ɓ���������~�܂�
//������Ă݂܂��B


public class SimpleGravity : MonoBehaviour
{
    //���֘A
    GameObject _floor;
    Transform _floorTrans;
    float _floorY;
    float _floorSize;

    //����ϐ�
    bool _hitFloorFlag;//���ɓ������Ă��邩

    //�d�͑��x(1���ő�l)
    float _gravitySpeed;

    // Start is called before the first frame update
    void Start()
    {
        //���̐ݒ�
        _floor = GameObject.Find("Floor");//�Q�[���I�u�W�F�N�g�擾
        _floorTrans = _floor.transform;//�g�����X�t�H�[���擾
        _floorY = _floor.transform.position.y;//Y���W�擾
        _floorSize = 1.5f;//���̃T�C�Y 

        //�d�͂̐ݒ�
        _gravitySpeed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        //���ɓ������Ă邩�̔���
        if (this.transform.position.y <= (_floorY +_floorSize))
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
