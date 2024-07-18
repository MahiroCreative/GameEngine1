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
        //ゲームオブジェクトの取得
        Force = GameObject.Find("Force");
        Impulse = GameObject.Find("Impulse");
        Acceleration = GameObject.Find("Acceleration");
        VelocityChange = GameObject.Find("VelocityChange");

        //力の設定
        Pow = new Vector3(0,0,1.0f);

        //力を加える
        Force.GetComponent<Rigidbody>().AddForce(Pow,ForceMode.Force);
        Impulse.GetComponent<Rigidbody>().AddForce(Pow,ForceMode.Impulse);
        Acceleration.GetComponent<Rigidbody>().AddForce(Pow, ForceMode.Acceleration);
        VelocityChange.GetComponent<Rigidbody>().AddForce(Pow, ForceMode.VelocityChange);
    }
}
