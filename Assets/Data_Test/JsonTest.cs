using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class myData
{
    public int hp=10;
    public int mp=5;

    public void saveMyData(myData Data)
    {
        File.WriteAllText(Application.dataPath + "/TestJson.json", JsonUtility.ToJson(Data));
    }

    public void readMyData()
    {
        string myReadText = File.ReadAllText(Application.dataPath + "/TestJson.json");
        myData myTest2 = JsonUtility.FromJson<myData>(myReadText);
        Debug.Log("hp : " + myTest2.hp);
        Debug.Log("mp : " + myTest2.mp);
    }
}

public class JsonTest : MonoBehaviour
{
    myData myTest = new myData();
    private float timer;

    // Start is called before the first frame update 
    void Start()
    {
        //myTest.hp = 10;
        //myTest.mp = 5;
        //string str = JsonUtility.ToJson(myTest);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            myTest.hp--;
            myTest.mp--;

            myTest.saveMyData(myTest);
            myTest.readMyData();
            timer = 0; 
        }
    }
}