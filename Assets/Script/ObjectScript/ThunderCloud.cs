using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderCloud : MonoBehaviour
{
    public GameObject Thunder;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitThunder());
    }

    IEnumerator InitThunder()
    {
        yield return new WaitForSeconds(3f);
        while (true)
        {
            int ran = Random.Range(0, 5);
            StartCoroutine(makeItem());
            switch (ran)
            {
                case 0:
                    {
                        yield return new WaitForSeconds(0.5f);
                        break;
                    }
                case 1:
                    {
                        yield return new WaitForSeconds(1f);
                        break;
                    }
                case 2:
                    {
                        yield return new WaitForSeconds(1.5f);
                        break;
                    }
                case 3:
                    {
                        yield return new WaitForSeconds(2f);
                        break;
                    }
                case 4:
                    {
                        yield return new WaitForSeconds(2.5f);
                        break;
                    }
            }
        }
    }

    
    IEnumerator makeItem()
    {
        GameObject tmp;
        tmp = Instantiate(Thunder);
        tmp.transform.SetParent(this.transform);
        tmp.transform.localPosition = new Vector3(0, 0, 0);
        tmp.SetActive(true);
        tmp.GetComponent<Rigidbody2D>().gravityScale = 0;

        yield return new WaitForSeconds(0.3f);
        tmp.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
    }
}
