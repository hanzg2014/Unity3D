using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelScript))]
public class LevelScriptEditor : Editor {

	//method called everytime when a new inspector is drawn inside Unity
	public override void OnInspectorGUI(){
		LevelScript myLevelScript	= (LevelScript)target;

		myLevelScript.experience = EditorGUILayout.IntField ("Experience", myLevelScript.experience);	//any change done need to be written back
		EditorGUILayout.LabelField ("Level", myLevelScript.Level.ToString()); //read-only; label contronl requires a string value
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


