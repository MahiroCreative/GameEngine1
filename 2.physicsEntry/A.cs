using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    float fspeed=0.01f;//���x
    Vector3 vspeed;

    // Start is called before the first frame update
    void Start()
    {
        //���x���x�N�g���ɕϊ�
        //�E�����Ɍ������x�N�g��
        vspeed = new Vector3(fspeed,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //���t���[���A�������ɐi�ށB
        this.transform.position += vspeed;
    }
}
