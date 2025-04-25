using UnityEngine;

public class Food : MonoBehaviour
{
    public Vector3 foodVector3 = new Vector3(0, 1, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(foodVector3, Space.World);
    }
}
