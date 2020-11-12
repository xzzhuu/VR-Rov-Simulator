using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CancelUIRaycast 
{
    [MenuItem("GameObject/UI/Image WithoutRay", false, 10)]
    static void CreatImage(MenuCommand menuCommand)
    {
        EditorApplication.ExecuteMenuItem("GameObject/UI/Image");
        GameObject go = Selection.activeGameObject;
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        go.GetComponent<Image>().raycastTarget = false;
    }

    [MenuItem("GameObject/UI/Text WithoutRay", false, 10)]
    static void CreatText(MenuCommand menuCommand)
    {
        EditorApplication.ExecuteMenuItem("GameObject/UI/Text");
        GameObject go = Selection.activeGameObject;
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        go.GetComponent<Text>().raycastTarget = false;
        go.GetComponent<Text>().supportRichText = false;
    }
    [MenuItem("GameObject/UI/Raw Image WithoutRay", false, 10)]
    static void CreatRawImage(MenuCommand menuCommand)
    {
        EditorApplication.ExecuteMenuItem("GameObject/UI/Raw Image");
        GameObject go = Selection.activeGameObject;
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        go.GetComponent<RawImage>().raycastTarget = false;
    }
    [MenuItem("GameObject/UI/Canvas WithoutRay", false, 10)]
    static void CreatCanvas(MenuCommand menuCommand)
    {
        EditorApplication.ExecuteMenuItem("GameObject/UI/Canvas");
        GameObject go = Selection.activeGameObject;
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        go.GetComponent<GraphicRaycaster>().enabled = false;
    }

    [MenuItem("GameObject/UI/Panel WithoutRay", false, 10)]
    static void CreatPanel(MenuCommand menuCommand)
    {
        EditorApplication.ExecuteMenuItem("GameObject/UI/Panel");
        GameObject go = Selection.activeGameObject;
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        go.GetComponent<Image>().raycastTarget = false;
    }
}
