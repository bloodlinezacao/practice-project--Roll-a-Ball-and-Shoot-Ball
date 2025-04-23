using UnityEngine;
using UnityEngine.InputSystem;


public class MyFirstScript : MonoBehaviour
{
    //public int myInt = 0;
    //public bool myBool = false;
    //public GameObject myGameObject = null;
    public Vector3 moveDir = new Vector3(0, 0, 0);
    //private Vector2 _input;
    //private PlayerControls _controls;
    public float speed = 10.0f;
    public Rigidbody myRigibody;
    private float moveX = 0;
    private float moveZ = 0;


    private void Start()
    {
        
    }

    private void Update()
    {
        DoMove();
    }
    private void FixedUpdate()
    {
        myRigibody.AddForce(moveDir * speed);
    }

    public void DoMove()
    {
        //Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
        //Debug.Log("Vertical" + Input.GetAxis("Vertical"));
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        

        //新版
        //Vector2 input = Keyboard.current.wasdKey.ReadValue();

        moveDir = new Vector3(moveX, 0, moveZ).normalized;//.normalized是限制移动速度上限用的
        
    }
}

//打印句
//Debug.Log("Hello World");

//public int myInt = 0;
//    public float myFloat = 0;
//    public string myString = "Hello World";
//    public bool myBool = false;

//// 检测 A 键是否被按下（按下瞬间触发一次）
//if (Keyboard.current.aKey.wasPressedThisFrame)
//{
//    Debug.Log("A 键被按下！");
//}

//// 检测 A 键是否被长按（按住期间每帧触发）
//if (Keyboard.current.aKey.isPressed)
//{
//    Debug.Log("A 键被按住...");
//}

//// 检测 A 键是否被释放（松开瞬间触发一次）
//if (Keyboard.current.aKey.wasReleasedThisFrame)
//{
//    Debug.Log("A 键被松开！");
//}

//移动
//gameObject.transform.Translate(myVector3);

//旋转
//gameObject.transform.Rotate(myVector3);

//加物理
//myRigibody.AddForce(myVector3);

//传统移动
//public void DoMove()
//{
//    if (Keyboard.current.wKey.isPressed)
//    {
//        moveDir = new Vector3(0, 0, 1);
//    }
//    else if (Keyboard.current.aKey.isPressed)
//    {
//        moveDir = new Vector3(-1, 0, 0);
//    }
//    else if (Keyboard.current.sKey.isPressed)
//    {
//        moveDir = new Vector3(0, 0, -1);
//    }
//    else if (Keyboard.current.dKey.isPressed)
//    {
//        moveDir = new Vector3(1, 0, 0);
//    }
//    else
//    {
//        Debug.Log("没有按下移动按键");
//        moveDir = new Vector3(0, 0, 0);
//    }

//    myRigibody.AddForce(moveDir * speed);
//}