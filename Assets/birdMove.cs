using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class birdMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ySpeed;
    public GameObject goUI;
    public GameObject replayButton;

    float score = 0;
    public TMP_Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        goUI.SetActive(false);
        Time.timeScale = 0;
        replayButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, ySpeed);
            ScoreText.text = score.ToString();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "score")
        {
            score++;
        }

        if (collision.gameObject.tag == "ground")
        {
            Time.timeScale = 0;
            goUI.SetActive(true);
            replayButton.SetActive(true);
        }
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene(0);
    }
}
