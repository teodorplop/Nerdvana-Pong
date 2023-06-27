using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Goal m_Goal;

    private TMP_Text m_Text;

    private void Awake()
    {
        m_Text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        m_Text.text = m_Goal.noGoals.ToString();
    }
}
