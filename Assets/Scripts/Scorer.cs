using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits += 1;
            Debug.Log("You've bumped into a think this many times: " + hits);
        }
    }
}
