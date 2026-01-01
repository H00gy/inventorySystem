using UnityEngine;

public class spawnCircle : MonoBehaviour
{
    public GameObject circle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(circle); 
        }
    }
}
