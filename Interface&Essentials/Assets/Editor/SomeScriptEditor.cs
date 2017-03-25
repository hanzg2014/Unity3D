using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SomeScript))]
public class SomeScriptEditor : Editor 
{
	public override void OnInspectorGUI(){
//		SomeScript mySomeScript	= (SomeScript)target;
//
//		EditorGUILayout.IntField ("Level", mySomeScript.level);
//		EditorGUILayout.FloatField ("Health", mySomeScript.health);
//		EditorGUILayout.Vector3Field ("Target", mySomeScript.target);


		DrawDefaultInspector();	//will draw all the defaults, while still allowing customization
		EditorGUILayout.HelpBox("This is a help box", MessageType.Info);


	}
}