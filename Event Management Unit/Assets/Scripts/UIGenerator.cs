using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGenerator : MonoBehaviour
{
    private Text cubeText;
    public GameObject player;
    private Text timerText;
    

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

        cubeText = textGO.GetComponent<Text>();
        cubeText.font = arial;
        cubeText.fontSize = 30;
        cubeText.alignment = TextAnchor.UpperLeft;

        RectTransform rectTransform;
        rectTransform = cubeText.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(canvas.renderingDisplaySize.x - 20, canvas.renderingDisplaySize.y);

        GameObject timer = new GameObject("timer");
        timer.transform.parent = canvasUI.transform;
        timer.AddComponent<Text>();

        timerText = timer.GetComponent<Text>();
        timerText.font = arial;
        timerText.fontSize = 30;
        timerText.alignment = TextAnchor.UpperLeft;

        RectTransform timerTransform;
        timerTransform = timerText.GetComponent<RectTransform>();
        timerTransform.localPosition = new Vector3(0, 0, 0);
        timerTransform.sizeDelta = new Vector2(canvas.renderingDisplaySize.x /16, canvas.renderingDisplaySize.y); 
    }

    void Update()
    {
        float cubeCount = player.GetComponent<SimplePlayerController>().cubeCount;
        cubeText.text = ("Material Left: " + cubeCount);
        cubeText.text = cubeCount.ToString("Materials Left: " + "0");

        float timerCount = player.GetComponent<SimplePlayerController>().timer;
        timerText.text = timerCount + "";
        timerText.text = timerCount.ToString("0.0");
    }
}