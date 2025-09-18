using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    private Rigidbody rgb;
    private SpriteRenderer playerRenderer;
    private Vector3 moveInput;



    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        playerRenderer = GetComponent<SpriteRenderer>();
       
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");

        moveInput.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rgb.MovePosition(rgb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
