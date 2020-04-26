using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    public GameObject thunder;
    public GameObject Banana;

    private const float height = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController.Instance.Player.transform.position = new Vector3(-2, 4);
        StartCoroutine(InitThunder());
    }

    IEnumerator InitThunder()
    {
        yield return new WaitForSeconds(3f);
        while (true)
        {
            if (Random.Range(0, 3) == 0)
            {
                StartCoroutine(makeItem(true));
            }
            else
            {
                StartCoroutine(makeItem(false));
            }
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator makeItem(bool IsBanana)
    {
        int ran = Random.Range(0, 5);
        Vector3 vec = new Vector3();
        switch (ran)
        {
            case 0:
                {
                    vec = new Vector3(-2, height);
                    break;
                }
            case 1:
                {
                    vec = new Vector3(-1, height);
                    break;
                }
            case 2:
                {
                    vec = new Vector3(0, height);
                    break;
                }
            case 3:
                {
                    vec = new Vector3(1, height);
                    break;
                }
            case 4:
                {
                    vec = new Vector3(2, height);
                    break;
                }
        }

        GameObject tmp;
        if (IsBanana)
        {
            tmp = Instantiate(Banana);
        }
        else
        {
            tmp = Instantiate(thunder);
        }

        tmp.transform.position = vec;
        tmp.SetActive(true);
        tmp.GetComponent<Rigidbody2D>().gravityScale = 0;

        yield return new WaitForSeconds(0.3f);
        tmp.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
    }
}
