using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int myInt = 0;
    public bool myBool = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        MyFirstFun();
    }

    public void MyFirstFun()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Hello World");
        }
        
    }
}

//¥Ú”°æ‰
//Debug.Log("Hello World");

//public int myInt = 0;
//    public float myFloat = 0;
//    public string myString = "Hello World";
//    public bool myBool = false;