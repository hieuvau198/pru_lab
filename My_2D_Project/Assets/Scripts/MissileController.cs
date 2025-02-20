using UnityEngine;

public class Missile : MonoBehaviour 
{
    public float missileSpeed = 50f;

    private void Update()
    {
        transform.Translate(Vector3.up * missileSpeed * Time.deltaTime);
    }
}
