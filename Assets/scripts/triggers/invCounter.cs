using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class invCounter : MonoBehaviour
{
    /// <summary>
    /// Inventory item counter
    /// can be expanded upon to add features such as limits to inventory items 
    /// this implementation only has a counter
    /// </summary>

    public TMP_Text counterTXT;
    static int count = 0;
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("object"))
        {
            Debug.Log("count called");
            count++;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("object"))
        {
           
            count--;
        }
    }
    private void Update()
    {
        Debug.Log("current count" + count);
        counterTXT.text = count.ToString();
    }
}
