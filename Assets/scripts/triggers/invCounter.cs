using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class invCounter : MonoBehaviour
{
    public TMP_Text counterTXT;
    int count = 0;
    public void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.CompareTag("object"))
        {
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
        counterTXT.text = count.ToString();
    }
}
