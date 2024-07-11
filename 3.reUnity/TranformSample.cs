using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformSample : MonoBehaviour
{
    //�ړ��֘A
    float speed = 0.2f;
    Vector3 moveX, moveY;

    //�g��A�k����
    float scaleSize = 0.5f;
    Vector3 delScale;

    //��]
    Vector3 arrow = new Vector3(0,1,0);//��
    float angle = 0.5f;//��]��
    Quaternion qr,ql;


    private void Start()
    {
        //�ړ��ʂ̍쐬
        moveX = new Vector3(speed,0,0);
        moveY = new Vector3(0, speed, 0);

        //��]�ʂ̍쐬
        delScale = new Vector3(scaleSize,scaleSize,scaleSize);

        //��]�N�H�[�^�j�I���̍쐬
        qr = Quaternion.AngleAxis(-angle,arrow);
        ql = Quaternion.AngleAxis(angle, arrow);
    }

    private void Update()
    {
        //�ړ�
        //��
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= moveX;
        }
        //�E
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += moveX;
        }
        //��
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += moveY;
        }
        //��
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position -= moveY;
        }

        //�g��k��
        if(Input.GetKey(KeyCode.Q))//�g��
        {
            this.transform.localScale += delScale;
        }
        if(Input.GetKey(KeyCode.Z))//�k��
        {
            this.transform.localScale -= delScale;
        }

        //��]
        if(Input.GetMouseButton(1))//�E
        {
            this.transform.rotation = qr * this.transform.rotation;
        }
        if (Input.GetMouseButton(0))//��
        {
            this.transform.rotation = ql * this.transform.rotation;
        }

    }

}
