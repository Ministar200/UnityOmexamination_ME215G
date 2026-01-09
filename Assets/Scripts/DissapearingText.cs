using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;

public class DissapearingText : MonoBehaviour
{
    private float alphaValue = 255;
    [SerializeField] private TextMeshProUGUI text;

    public static bool playerHasMoved;
    
    // Update is called once per frame
    void Update()
    {
        if (!playerHasMoved) return;
        
        if (alphaValue > 0)
        {
            alphaValue -= 100f * Time.deltaTime;
        }
        
        text.alpha = alphaValue/255;
    }
}
