using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
