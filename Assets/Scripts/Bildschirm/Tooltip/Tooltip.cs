using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem;

[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField; 

    public TextMeshProUGUI contentField; 
    public LayoutElement layoutElement; 

    public int characterWrapLength;

    public RectTransform rectTransform;
    

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }
    
    
    public void SetText(string content, string header = ""){

        if (string.IsNullOrEmpty(header))
        {
            headerField.gameObject.SetActive(false);
        }
        else
        {
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }

        contentField.text = content;
        int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        layoutElement.enabled = (headerLength > characterWrapLength || contentLength > characterWrapLength) ? true : false;
    }


    private void Update() {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 mousePosition = new Vector2(worldPosition.x, worldPosition.y);

        float pivotX = mousePosition.x / Screen.width;
        float pivotY = mousePosition.y / Screen.height;
        
        rectTransform.pivot = new Vector2(pivotX, pivotY);
        transform.position = mousePosition;


    }

}
