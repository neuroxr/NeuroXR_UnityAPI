#if UNITY_EDITOR
using NeuroXR;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NeuroXR_API_Unity))]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        NeuroXR_API_Unity _NeuroXR_API_Unity = (NeuroXR_API_Unity)target;

        GUIStyle guildLineStyle = new GUIStyle(GUI.skin.label);
        guildLineStyle.wordWrap = true;
        guildLineStyle.fontStyle = FontStyle.Bold;

        GUIStyle additionalInformationStyle = new GUIStyle(GUI.skin.label);
        additionalInformationStyle.wordWrap = true;
        additionalInformationStyle.fontStyle = FontStyle.Italic;

        GUILayout.Space(10);
        EditorGUILayout.LabelField("1. Set the resolution of the top view camera.", guildLineStyle);
        EditorGUILayout.LabelField("Or use maxEdgePixelCount = <int>.", additionalInformationStyle);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Maximum edge pixel count");
        GUILayout.Space(5);
        _NeuroXR_API_Unity.maxEdgePixelCount = int.Parse(GUILayout.TextField(_NeuroXR_API_Unity.maxEdgePixelCount.ToString(), GUILayout.MinWidth(100)));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("2. Fill in the GameObjects in the area that need to be observed.", guildLineStyle);
        EditorGUILayout.LabelField("Or use observedObjects.Add(<GameObject>)", additionalInformationStyle);
        EditorGUILayout.LabelField("(If there are too many GameObjects or the GameObject's mesh is too complicated, just create a simple GameObject with mesh covering the whole area to speed up the area analyzation)", additionalInformationStyle);
        serializedObject.Update();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("observedObjects"), true);
        serializedObject.ApplyModifiedProperties();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("3. Generate a top view camera named 'nxrTopViewCamera' to catch the view.", guildLineStyle);
        EditorGUILayout.LabelField("Or use SetTopViewCamera(). To get the camera information, use .viewbox", additionalInformationStyle);
        if (GUILayout.Button("Generate a top view camera"))
        {
            _NeuroXR_API_Unity.SetTopViewCamera();
        }
        GUILayout.BeginHorizontal();
        GUILayout.Label("Top view camera");
        GUILayout.Space(5);
        EditorGUILayout.ObjectField(_NeuroXR_API_Unity.topViewCamera, typeof(GameObject), true, GUILayout.MinWidth(100));
        GUILayout.EndHorizontal();
        GUILayout.Label("View area");
        GUILayout.BeginHorizontal();
        GUILayout.Label($"Xmin: {_NeuroXR_API_Unity.viewBox.Xmin}");
        GUILayout.FlexibleSpace();
        GUILayout.Label($"Xmax: {_NeuroXR_API_Unity.viewBox.Xmax}");
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Label($"Ymin: {_NeuroXR_API_Unity.viewBox.Ymin}");
        GUILayout.FlexibleSpace();
        GUILayout.Label($"Ymax: {_NeuroXR_API_Unity.viewBox.Ymax}");
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Label($"Zmin: {_NeuroXR_API_Unity.viewBox.Zmin}");
        GUILayout.FlexibleSpace();
        GUILayout.Label($"Zmax: {_NeuroXR_API_Unity.viewBox.Zmax}");
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("4. Input the character that needs to be tracked.", guildLineStyle);
        EditorGUILayout.LabelField("Or use SetTrackedCharacter(<GameObject>).", additionalInformationStyle);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Character");
        GUILayout.Space(5);
        _NeuroXR_API_Unity.character = (GameObject)EditorGUILayout.ObjectField(_NeuroXR_API_Unity.character, typeof(GameObject), true, GUILayout.MinWidth(100), GUILayout.MaxWidth(300));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("5. Input the name of this application.", guildLineStyle);
        EditorGUILayout.LabelField("Or use SetAppName(<string>).", additionalInformationStyle);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Name");
        GUILayout.Space(5);
        _NeuroXR_API_Unity.appName = GUILayout.TextField(_NeuroXR_API_Unity.appName, GUILayout.MinWidth(100));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("6. Fill in the server port of NeuroXR.", guildLineStyle);
        EditorGUILayout.LabelField("Or use SetServerIpPort(<string>).", additionalInformationStyle);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Server IP:Port");
        GUILayout.Space(5);
        _NeuroXR_API_Unity.serverIpPort = GUILayout.TextField(_NeuroXR_API_Unity.serverIpPort, GUILayout.MinWidth(100));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        EditorGUILayout.LabelField("7. Use Connect() and DisConnect() to start and stop communicating with NeuroXR.", guildLineStyle);
    }
}
#endif