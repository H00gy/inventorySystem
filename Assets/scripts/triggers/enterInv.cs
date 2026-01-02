using UnityEngine;

public class enterInv : MonoBehaviour
{
    
    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.CompareTag("object"))
        {
            other.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(-2.5f, -4.5f));
            Debug.Log("objects new location is " + other.transform.position);
        }
    }

}
