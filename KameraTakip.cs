using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;
    /*Parametre olarak gönderilen oyun objesini takip etmeyi sağlayan kod parçacığı.*/
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.transform.position + mesafe, Time.deltaTime);
    }
}
