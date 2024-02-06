using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Button Button;
    public float HoverScale = 1.2f;
    public float Duration = 0.3f;

    private Vector3 originalScale;
    private void Start()
    {
        originalScale = Button.transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.transform.DOScale(originalScale * HoverScale, Duration).SetUpdate(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.transform.DOScale(originalScale, Duration).SetUpdate(true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Button.transform.DOScale(originalScale, Duration);
    }
}