using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField] public Text goalText;
    // Start is called before the first frame update
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        //Destroy(goalText.gameObject);
    //        StartCoroutine(waiter3());
    //    }
    //}
    private void Start()
    {
        StartCoroutine(waiter3());
    }

    IEnumerator waiter3()
    {
        yield return new WaitForSecondsRealtime(3);
        goalText.gameObject.SetActive(false);
    }
}
