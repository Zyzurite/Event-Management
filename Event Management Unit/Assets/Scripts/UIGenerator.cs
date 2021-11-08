using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGenerator : MonoBehaviour
{
    private Text text;
    public GameObject player;

    void Awake()
    {

        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        GameObject canvasUI = new GameObject();
        canvasUI.name = "Canvas";
        canvasUI.AddComponent<Canvas>();
        canvasUI.AddComponent<CanvasScaler>();
        canvasUI.AddComponent<GraphicRaycaster>();

        Canvas canvas;
        canvas = canvasUI.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasUI.transform;
        textGO.AddComponent<Text>();

        text = textGO.GetComponent<Text>();
        text.font = arial;
        text.fontSize = 30;
        text.alignment = TextAnchor.UpperLeft;

        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(canvas.renderingDisplaySize.x - 20, canvas.renderingDisplaySize.y);
    }

    void Update()
    {
        int cubeCount = player.GetComponent<SimplePlayerController>().cubeCount;
        text.text = ("Material Left: " + cubeCount);
    }
}