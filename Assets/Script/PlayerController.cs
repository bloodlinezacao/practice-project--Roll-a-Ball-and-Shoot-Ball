using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public float speed = 10.0f;                         //  ����ٶ�
    public Rigidbody myRG;                              //  ����ģ�������׼����
    public Text scoreText;
    public GameObject RestarGameObject;
    public AudioClip eatSound;
    public AudioSource audioSource;

    public Vector3 moveDir = new Vector3(0, 0, 0);      //  ��ʼ�����������
    float moveX = 0;                                    //  x����������С
    float moveZ = 0;                                    //  z����������С

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        RestarGameObject.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
        DoMove();
    }
    // 
    private void FixedUpdate()
    {
        myRG.AddForce(moveDir * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            score++;
            scoreText.text = "Score��" + score;

            audioSource.PlayOneShot(eatSound);

            if (score >= 8)
            {
                RestarGameObject.SetActive(true);
            }
            Destroy(other.gameObject);
        }
    }

    public void DoMove()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        moveDir = new Vector3(moveX, 0, moveZ).normalized;  // normalized ��׼��
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
