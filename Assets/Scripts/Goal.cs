using UnityEngine;

public class Goal : MonoBehaviour
{
    public int noGoals;

    void OnTriggerExit2D()
    {
        ++noGoals;

        FindObjectOfType<BallController>().ResetToStart();
        FindObjectOfType<BallController>().Throw();

        foreach (var playerController in FindObjectsOfType<PlayerController>())
            playerController.ResetToStart();
    }
}
