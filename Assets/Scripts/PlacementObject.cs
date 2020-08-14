using TMPro;
using UnityEngine;

public class PlacementObject : MonoBehaviour
{
    [SerializeField]
    private bool IsSelected;

    [SerializeField]
    private bool IsLocked;

    public bool Selected 
    { 
        get 
        {
            return this.IsSelected;
        }
        set 
        {
            IsSelected = value;
        }
    }

    public bool Locked 
    { 
        get 
        {
            return this.IsLocked;
        }
        set 
        {
            IsLocked = value;
        }
    }

    [SerializeField]
    private TextMeshPro OverlayText;

    [SerializeField]
    private Canvas canvasComponent;

    [SerializeField]
    private string OverlayDisplayText;

    [SerializeField]
    
    public GameObject[] myCountries;
    
    public void SetOverlayText(string text)
    {
        if(OverlayText != null)
        {
            OverlayText.gameObject.SetActive(true);
            OverlayText.text = text;
        }
    }

    void Awake ()
    {
        OverlayText = GetComponentInChildren<TextMeshPro>();
        if(OverlayText != null)
        {
            for(int i = 0; i < 3; i++)
                myCountries[i].SetActive(true);
            OverlayText.gameObject.SetActive(false);

        }
        
    }

    public void ToggleOverlay()
    {
        OverlayText.gameObject.SetActive(IsSelected);
        OverlayText.text = OverlayDisplayText;
        for(int i = 0; i < 3; i++)
            myCountries[i].SetActive(true);
    }

    public void ToggleCanvas()
    {
        canvasComponent?.gameObject.SetActive(IsSelected);
        for(int i = 0; i < 3; i++)
            myCountries[i].SetActive(true);
    }
    


}
