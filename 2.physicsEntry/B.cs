using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    float fspeed = 0;//���x
    float faccel = 0.0001f;//�����x
    Vector3 vspeed;

    // Start is called before the first frame update
    void Start()
    {
        //���x�Ɖ����x�̏�����
        //�x�N�g���ɕϊ�
        vspeed = new Vector3();
  
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̃t���[���̑��x�̌v�Z
        //�O�̃t���[���ł̑��x��1�t���[�����ɑ������鑝���ʂ𑫂��Ă�
        //�܂�Afaccel�����x�����A[/s]�ł͂Ȃ��A[/f]�ł̉����x�B
        fspeed = faccel + fspeed;

        //�x�N�g���ϊ�
        vspeed = new Vector3(fspeed,0,0);

        //���݂̃t���[���̑��x�𑫂�
        this.transform.position += vspeed;
    }
}
