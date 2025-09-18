using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public int life = 10;
    [SerializeField] public float speed = 5f;
    private Rigidbody rgb;
    private SpriteRenderer playerRenderer;
    private Vector3 moveInput;

    [SerializeField] Scrollbar Vida;


    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        playerRenderer = GetComponent<SpriteRenderer>();
        Vida = GetComponent<Scrollbar>();
       
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
