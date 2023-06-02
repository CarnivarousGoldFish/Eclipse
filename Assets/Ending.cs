using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    [SerializeField] SpriteRenderer towerRenderer;
    [SerializeField] SpriteRenderer moonRenderer;
    [SerializeField] GameObject moonObj;
    [SerializeField] Transform endPos;
    bool isFadeFinished = false;
    Color color;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Enter");
            StartCoroutine(FadeTower());
            collision.gameObject.GetComponent<Movement>().canMove = false;
            collision.gameObject.GetComponent<Movement>().enabled = false;

        }
    }


    IEnumerator FadeTower()
    {
        //int tick = 100;

        yield return new WaitForSeconds(2f);
        color = towerRenderer.color;
       for(float i = 1; i >= 0.12f; i -=0.12f)
        {
            color.a = i;
            towerRenderer.color = color;
            yield return new WaitForSeconds(0.1f);
        }

        isFadeFinished = true;
        //yield return null;
    }


    private void Update()
    {
        if (isFadeFinished)
            StartCoroutine(ShowMoon());
    }

    IEnumerator ShowMoon()
    {
        isFadeFinished = false;
        color = moonRenderer.color;
        
        for (float i = 0f; i <= 1f; i += 0.05f)
        {
            color.a = i;
            moonRenderer.color = color;
            yield return new WaitForSeconds(0.1f);
        }
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Home");
    }
}
