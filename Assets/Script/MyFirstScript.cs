using UnityEngine;
//using UnityEngine.InputSystem;
using UnityEngine.UI;


public class MyFirstScript : MonoBehaviour
{
    //public Text myText;
    public Slider mySlider;
    public float myFloat = 0.0f;

    public void Start()
    {
        //myText.text = "Hello World";
    }
    public void Update()
    {
        mySlider.value = myFloat;
    }

    public void OnButtonClick()
    {
        //Debug.Log("Botton Click");
    }

}





//��ӡ��
//Debug.Log("Hello World");

//public int myInt = 0;
//    public float myFloat = 0;
//    public string myString = "Hello World";
//    public bool myBool = false;

//// ��� A ���Ƿ񱻰��£�����˲�䴥��һ�Σ�
//if (Keyboard.current.aKey.wasPressedThisFrame)
//{
//    Debug.Log("A �������£�");
//}

//// ��� A ���Ƿ񱻳�������ס�ڼ�ÿ֡������
//if (Keyboard.current.aKey.isPressed)
//{
//    Debug.Log("A ������ס...");
//}

//// ��� A ���Ƿ��ͷţ��ɿ�˲�䴥��һ�Σ�
//if (Keyboard.current.aKey.wasReleasedThisFrame)
//{
//    Debug.Log("A �����ɿ���");
//}

//�ƶ�
//gameObject.transform.Translate(myVector3);

//��ת
//gameObject.transform.Rotate(myVector3);

//������
//myRigibody.AddForce(myVector3);

//��ͳ�ƶ�
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
//        Debug.Log("û�а����ƶ�����");
//        moveDir = new Vector3(0, 0, 0);
//    }

//    myRigibody.AddForce(moveDir * speed);
//}




//��ײ���ຯ������
//private void OnCollisionEnter(Collision collision)//��ײ������ʱ��������
//{
//    Debug.Log("������");
//}
//private void OnCollisionStay(Collision collision)
//{
//    Debug.Log("ͣ����");
//}
//private void OnCollisionExit(Collision collision)
//{
//    Debug.Log("�뿪��");
//}



//�������ຯ������
//private void OnTriggerEnter(Collider other)
//{
//    Debug.Log("���봥����");
//}
//private void OnTriggerStay(Collider other)
//{
//    Debug.Log("��������");
//}
//private void OnTriggerExit(Collider other)
//{
//    Debug.Log("�뿪������");
//}


//��������
//collision.gameObject.name;
//�����ǩ
//collision.gameObject.tag



//С���ƶ�����
////public int myInt = 0;
//    //public bool myBool = false;
//    //public GameObject myGameObject = null;
//    public Vector3 moveDir = new Vector3(0, 0, 0);
//    //private Vector2 _input;
//    //private PlayerControls _controls;
//    public float speed = 10.0f;
//    public Rigidbody myRigibody;
//    private float moveX = 0;
//    private float moveZ = 0;


//    private void Start()    //unity�Զ�ִ�еĺ���Ϊ��ɫ
//{
//    moveDir = new Vector3(0, 0, 0);
//}

//private void Update()
//{
//    DoMove();
//}
//private void FixedUpdate()  //�˶��ຯ������
//{
//    myRigibody.AddForce(moveDir * speed);
//}


//private void OnCollisionEnter(Collision collision)//��ײ������ʱ��������
//{
//    if (collision.gameObject.tag == "Food")
//    {
//        Debug.Log(collision.gameObject.tag);
//    }
//}

//private void OnTriggerEnter(Collider other)
//{
//    if (other.gameObject.tag == "Food2")
//    {
//        Debug.Log(other.gameObject.tag);
//    }
//    //Debug.Log("���봥����");
//}

//public void DoMove()
//{
//    //Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
//    //Debug.Log("Vertical" + Input.GetAxis("Vertical"));
//    moveX = Input.GetAxis("Horizontal");
//    moveZ = Input.GetAxis("Vertical");


//    //�°�
//    //Vector2 input = Keyboard.current.wasdKey.ReadValue();

//    moveDir = new Vector3(moveX, 0, moveZ).normalized;//.normalized�������ƶ��ٶ������õ�

//}



//�����ı�
//myText.text = "Hello World";