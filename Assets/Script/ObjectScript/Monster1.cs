using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour
{
    private bool isGameOver = false;
    private bool isCollision = false;

    private IEnumerator Cor_disappear = null;

    private void Start()
    {
        Cor_disappear = disappear();
    }

    private void OnEnable()
    {
        ClearObject.instance.GameOverMsg += stopCoroutineMonster1;
    }

    private void OnDisable()
    {
        Debug.Log("monster1 OnDisable");
        ClearObject.instance.GameOverMsg -= stopCoroutineMonster1;
    }
    private void OnDestroy()
    {
        Debug.Log("monster1 OnDestroy");
        ClearObject.instance.GameOverMsg -= stopCoroutineMonster1;
    }

    private void stopCoroutineMonster1()
    {
        Debug.Log("stop Coroutine");
        isGameOver = true;
        StopCoroutine(Cor_disappear);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PlayerController.Instance.gameObject)
        {
            if (!isCollision)
            {
                StartCoroutine(Cor_disappear);
                isCollision = true;
            }
        }
    }

    private IEnumerator disappear()
    {
        this.GetComponent<AudioSource>().Play();
        float time = 0;
        while (true)
        {
            this.transform.eulerAngles += new Vector3(0, 0, 360 * Time.deltaTime);
            time += Time.deltaTime;
            if (time > 3)
            {
                break;
            }
            if (isGameOver)
            {
                Debug.Log("monster1 break");
                yield break;
            }
            yield return null;
        }
        
        SceneController.Instance.ChangeScene(2);

        //Destroy(this.gameObject);
        yield return null;
    }
}
