using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    public GameObject thunder;
    public GameObject Banana;

    private const float height = 4f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitThunder());
    }

    IEnumerator InitThunder()
    {
        while (true)
        {
            if (Random.Range(0, 3) == 0)
            {
                makeItem(true);
            }
            else
            {
                makeItem(false);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private void makeItem(bool IsBanana)
    {
        int ran = Random.Range(0, 6);
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
        if (IsBanana)
        {
            GameObject tmp = Instantiate(Banana);
            tmp.transform.position = vec;
            tmp.SetActive(true);
        }
        else
        {
            GameObject tmp = Instantiate(thunder);
            tmp.transform.position = vec;
            tmp.SetActive(true);
        }
    }
}
