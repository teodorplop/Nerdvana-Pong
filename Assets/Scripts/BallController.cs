using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float m_DelayBeforeThrow = 1.0f;
    [SerializeField] private float m_MinThrowHeight = 0.1f;
    [SerializeField] private float m_MaxThrowHeight = 0.5f;
    [SerializeField] private float m_Speed = 10;

    private Vector2 m_StartPosition;
    private Rigidbody2D m_Rigidbody;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        m_StartPosition = transform.position;
        Throw();
    }

    public void ResetToStart()
    {
        transform.position = m_StartPosition;
        m_Rigidbody.velocity = Vector2.zero;
    }

    public void Throw()
    {
        StartCoroutine(ThrowCoroutine());
    }

    private IEnumerator ThrowCoroutine()
    {
        yield return new WaitForSeconds(m_DelayBeforeThrow);

        float x = Random.Range(0, 2) * 2 - 1;
        float y = Random.Range(m_MinThrowHeight, m_MaxThrowHeight) * (Random.Range(0, 2) * 2 - 1);

        m_Rigidbody.AddForce(new Vector2(x, y) * m_Speed);
    }
}
