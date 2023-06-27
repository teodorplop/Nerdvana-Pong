using UnityEngine;

public class FitToCamera : MonoBehaviour
{
    [SerializeField] private float m_Multiplier = 1.0f;
    [SerializeField] private float m_Offset = 0.5f;

    private void Awake()
    {
        float limit = ComputeCameraLimit();
        transform.position = new Vector3((limit + m_Offset) * m_Multiplier, transform.position.y, transform.position.z);
    }

    private float ComputeCameraLimit()
    {
        Camera camera = Camera.main;
        return camera.orthographicSize * camera.aspect;
    }
}
