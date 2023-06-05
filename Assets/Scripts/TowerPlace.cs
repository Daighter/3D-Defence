using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlace : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IPointerClickHandler//, IDragHandler
{
    [SerializeField] Color normal;
    [SerializeField] Color onMouse;

    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            Debug.Log("¿Þ Å¬¸¯");
        else if (eventData.button == PointerEventData.InputButton.Right)
            Debug.Log("ÁÂ Å¬¸¯");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        render.material.color = onMouse;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        render.material.color = normal;
    }
    /*
    public void OnDrag(PointerEventData eventData)
    {
        transform.position += new Vector3(eventData.delta.x, 0, eventData.delta.y);
    }*/
}
