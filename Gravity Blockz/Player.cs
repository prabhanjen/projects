
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public TextController text;
    private bool isTop = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (text == null)
        {
            text = GameObject.FindObjectOfType<TextController>();
        }
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (rb != null)
            {
                rb.gravityScale *= -1;
                isTop = !isTop;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject != null && other.gameObject.tag == "spike")
        {
            if (SceneManager.GetActiveScene() != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (text != null)
            {
                text.score = 0;
            }
        }
    }
}
