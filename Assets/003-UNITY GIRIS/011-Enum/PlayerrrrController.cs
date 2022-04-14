using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerrrrController : MonoBehaviour
{
    [SerializeField] Transform _body;
    int _score;
    [SerializeField] Text _scoreText,_highScoreText;
    int _highScore;
    private void FixedUpdate()
    {
        _body.transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            _score += Random.Range(1, 10);
            Destroy(collision.gameObject);
            _scoreText.text = _score.ToString();
            PlayerPrefs.SetInt("skor", _score);

           
        }
    }

    private void Start()
    {
        _highScore =PlayerPrefs.GetInt("skor");
        EnYuksekSkor();
       
    }
    void EnYuksekSkor()
    {
        if (_score>_highScore)
        {
            PlayerPrefs.SetInt("skor", _score);
            _highScoreText.text = "En Yuksek Skor:"+ _score.ToString();
        }
    }

}
