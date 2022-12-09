using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneTrigger : MonoBehaviour
{

    [SerializeField] private string nextSceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene(nextSceneName);
    }
}
