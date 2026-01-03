using UnityEngine;

public class spawnCircle : MonoBehaviour
{
    /// <summary>
    /// simple spawn script
    /// </summary>
    public GameObject circle;
    int count = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnedCircle = Instantiate(circle); 
            spawnedCircle.name = $"circle_{count}";
            count++;
        }
    }
    

}
