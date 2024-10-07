using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] public Text deadText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(waiter2());

        }
    }
    IEnumerator waiter2()
    {
        deadText.gameObject.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        SceneManager.LoadScene(0);
    }
}
