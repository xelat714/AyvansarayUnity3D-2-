using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman") || collision.gameObject.CompareTag("Zemin"))
        {
            Debug.Log("Zemine değdi");
            //SceneManager.LoadScene(0)
            Time.timeScale = 0;
            _gameOverPanel.SetActive(true);
        }
    }

    public void Button()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
