using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool canTrowDog = true; // переменная которая не дает нам выпускать собак и будет переключаться
                                   // своим методом

    private void Start()
    {
        InvokeRepeating("CanTrowDogAgain", 2, 2); //вызываем свой метод который переключает canTrowDog на тру и
                                                  // мы можем выпускать собаку
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canTrowDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canTrowDog = false; // при выпуске собаки мы делаем выпуск собаки невозможным следующий
                                // выпуск будет доступен после вызова InvokeReapiting;
        }
    }

    void CanTrowDogAgain()
    {
        canTrowDog = true;
    }
}
