using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public event Action OnHover;
    public event Action OnOut;
    public event Action OnClick;
    public event Action OnUp;
    public event Action OnDown;
    public event Action OnLongPress;
    public event Action OnSelected;
    public event Action OnDeselected;

    // Start is called before the first frame update
    void Start()
    {
    }
    /*     
    private void Start()
    {
        ARInteractiveItem item = GetComponent<ARInteractiveItem>();
        item.OnHover += OnHover; 
        item.OnOut += OnOut;
        item.OnClick += OnClick;
        firstPos = this.transform.position;
        firstScale = this.transform.localScale;

        Shader shader = Shader.Find("Unlit/Texture");
        shader = Shader.Find("VideoPlayer/ScreenAndroid");

        this.GetComponent<MeshRenderer>().material.shader = shader;
    }
    */
    public void OnPointerClick(PointerEventData eventData)
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("hi");
        OnHover();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}