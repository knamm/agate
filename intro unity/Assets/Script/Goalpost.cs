using UnityEngine;

public class GoalPost : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Finish");
            Destroy(gameObject);
        }
    }
}