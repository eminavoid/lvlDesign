using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] public Text aliveText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            StartCoroutine(waiter());

        }
    }

    IEnumerator waiter()
    {
        aliveText.gameObject.SetActive(true);

        yield return new WaitForSecondsRealtime(2f);

        Application.Quit();
        
    }
}
