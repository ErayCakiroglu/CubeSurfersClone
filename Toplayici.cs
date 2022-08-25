using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject anaKup;
    int yukseklik;

    /*AnaKup adındaki oyun objesini arayan ve anaKup değişkenine atayan kod parçacığı.*/
    void Start()
    {
        anaKup = GameObject.Find("AnaKup");
    }

    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0f, -yukseklik, 0f);
    }

    public void YukseklikAzalt()
    {
        yukseklik--;
    }

    /*Temas edilen oyun objesinin etiketinin Topla olduğunu ve toplanmamış bir obje olduğu kontrolünü eden eğer toplanmamışsa toplandı olarak değiştiren ve anaKup oyun objesinin çocuğu olmasını sağlayan methot.*/
    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.tag == "Topla" && temas.gameObject.GetComponent<ToplanabilirKup>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            temas.gameObject.GetComponent<ToplanabilirKup>().ToplandiYap();
            temas.gameObject.GetComponent<ToplanabilirKup>().IndexAyarla(yukseklik);
            temas.gameObject.transform.parent = anaKup.transform;
        }
    }
}
