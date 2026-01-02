using UnityEngine;

public class enterInv : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "object")
        {
            other.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-2.5f, -4.5f), 0);
        }
    }
    
}
