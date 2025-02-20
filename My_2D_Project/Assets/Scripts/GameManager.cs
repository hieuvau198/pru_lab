using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float minInstantiateValue;
    public float maxInstantiateValue;
    public float heightInstantiateValue;
    public float asteroidDestroyTime = 10f;

    private void Start()
    {
        InvokeRepeating("InstantiateAsteroid", 1f, 1f);
    }

    void InstantiateAsteroid()
    {
        Vector3 asteroidPosition = new Vector3(Random.Range(minInstantiateValue, maxInstantiateValue), heightInstantiateValue);
        GameObject asteroid = Instantiate(asteroidPrefab, asteroidPosition, Quaternion.Euler(0f,0f,180f));
        Destroy(asteroid, asteroidDestroyTime);
    }
}
