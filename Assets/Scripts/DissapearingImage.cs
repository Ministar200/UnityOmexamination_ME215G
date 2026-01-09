using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DissapearingImage : MonoBehaviour
{
    private float alphaValue = 255;
    [SerializeField] private Image image;

    public static bool playerHasMoved;
    
    // Update is called once per frame
    void Update()
    {
        if (!playerHasMoved) return;
        
        if (alphaValue > 0)
        {
            alphaValue -= 100f * Time.deltaTime;
        }
        
        image.color = new Color(0,0,0,alphaValue/255);
    }
}
