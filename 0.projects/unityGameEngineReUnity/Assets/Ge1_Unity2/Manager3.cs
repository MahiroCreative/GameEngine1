using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager3 : MonoBehaviour
{
    GameObject Force, Impulse, Acceleration, VelocityChange;
    Vector3 Pow;

    // Start is called before the first frame update
    void Start()
    {
        //�Q�[���I�u�W�F�N�g�̎擾
        Force = GameObject.Find("Force");
        Impulse = GameObject.Find("Impulse");
        Acceleration = GameObject.Find("Acceleration");
        VelocityChange = GameObject.Find("VelocityChange");

        //�͂̐ݒ�
        Pow = new Vector3(0,0,1.0f);

        //�͂�������
        Force.GetComponent<Rigidbody>().AddForce(Pow,ForceMode.Force);
        Impulse.GetComponent<Rigidbody>().AddForce(Pow,ForceMode.Impulse);
        Acceleration.GetComponent<Rigidbody>().AddForce(Pow, ForceMode.Acceleration);
        VelocityChange.GetComponent<Rigidbody>().AddForce(Pow, ForceMode.VelocityChange);
    }
}
