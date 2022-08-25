using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [SerializeField] float ileriGitmeHizi, sagaSolaGitmeHizi;

    /*Oyun objesine yatay eksen üzerinde hareket ettirmeyi sağlayan kod parçaçığı.*/
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * sagaSolaGitmeHizi *Time.deltaTime;
        transform.Translate(yatayEksen, 0f, ileriGitmeHizi * Time.deltaTime);
    }
}
