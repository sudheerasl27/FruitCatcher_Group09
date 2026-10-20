using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float bottomY = -6f;

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            // Only a MISSED FRUIT costs a life. A missed bomb is good!
            if (CompareTag("Fruit"))
            {
                GameManager.instance.LoseLife();
            }
            Destroy(gameObject);
        }
    }
}