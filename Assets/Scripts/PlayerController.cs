using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float xLimit = 8f;
   /* void Start()

    {
        Debug.Log("Hellow!! The game has strated");
        
    }*/

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * move * speed * Time.deltaTime);


        float clampedX = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        transform.position = new Vector3(clampedX, transform.position.y, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fruit"))
        {
            Debug.Log("Caught a Fruit");

            // Add this line so the GameManager knows to increase the score!
            GameManager.instance.AddScore(1);

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bomb"))
        {
            GameManager.instance.LoseLife();
            Destroy(other.gameObject);
        }
    }


}
    
        
    

