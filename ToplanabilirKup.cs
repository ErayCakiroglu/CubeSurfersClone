using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirKup : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public Toplayici toplayici;
    /*Oyun başında toplanacak olan oyun objelerinin toplanmadığını belirten kod parçacığı.*/
    void Start()
    {
        toplandiMi = false;
    }

    /*Oyuncunun topladığı oyun objelerinin ebeveyni olduğu ve kendi pozisyonunun bir eksiğinde bulunmasını sağlayan kod parçacığı.*/
    void Update()
    {
        if(toplandiMi == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0f, -index, 0f);
            }
        }
    }

    /*Temas edilen oyun objesinin Engel olup olmadığı kontrol eden ve engel olduğu zaman oyuncunun yüksekliğinin azaldığı engele çarpan oyun objesinin oyuncudan ayrıldığı methot.*/
    void OnTriggerEnter(Collider temas)
    {
        if(temas.tag == "Engel")
        {
            toplayici.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            temas.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    
    public bool GetToplandiMi()
    {
        return toplandiMi;
    }

    public void ToplandiYap()
    {
        toplandiMi = true;
    }

    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
