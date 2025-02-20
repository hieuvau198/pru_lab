using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    [Header("Missile")]
    public GameObject missile;
    public Transform missileSpawnPosition;
    public float destroyTime = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component
    }

    void Update()
    {
        // Get input from WASD & Arrow Keys
        moveInput.x = Input.GetAxisRaw("Horizontal"); // A, D, Left, Right
        moveInput.y = Input.GetAxisRaw("Vertical");   // W, S, Up, Down

        moveInput.Normalize(); // Prevent diagonal speed boost
        PlayerShoot();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * speed; // Apply movement
    }

    void PlayerShoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gm = Instantiate(missile, missileSpawnPosition);
            gm.transform.SetParent(null);
            Destroy(gm, destroyTime);
        }
    }
}
