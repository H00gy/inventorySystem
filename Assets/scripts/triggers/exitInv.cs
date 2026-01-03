using UnityEngine;

public class exitInv : MonoBehaviour
{
    /// <summary>
    /// this script is the exit function for the exit inventory collider, 
    /// so when your take out your inventory objects and place them back into the game
    /// in this implementation the inventory objects are placed in a random specified transform
    /// </summary>
    

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.CompareTag("object"))
        {
            other.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(-0.5f, -1f));
            Debug.Log("objects new location is " + other.transform.position);
        }
    }
}
