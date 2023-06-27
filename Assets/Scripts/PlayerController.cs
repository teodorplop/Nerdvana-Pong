using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeyCode m_UpKey = KeyCode.W;
    [SerializeField] private KeyCode m_DownKey = KeyCode.S;
    [SerializeField] private float m_Speed = 1.0f;

    private Vector3 m_StartPosition;

    private Rigidbody2D m_Rigidbody;
    private Vector2 m_Velocity;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        m_StartPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKey(m_UpKey))
            m_Velocity = Vector2.up * m_Speed;
        else if (Input.GetKey(m_DownKey))
            m_Velocity = Vector2.down * m_Speed;
        else
            m_Velocity = Vector2.zero;
    }

    private void FixedUpdate()
    {
        if (m_Velocity.magnitude >= Mathf.Epsilon)
        {
            m_Rigidbody.AddForce(m_Velocity);
        }
    }

    public void ResetToStart()
    {
        transform.position = m_StartPosition;
        m_Rigidbody.velocity = Vector2.zero;
    }
}
