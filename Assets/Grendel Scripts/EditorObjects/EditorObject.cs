using UnityEngine;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

public class EditorObject : MonoBehaviour
{
	public bool DebugMode = false;
	public string Comment = "";
	public List<EditorObjectConnection> Connections = new List<EditorObjectConnection>();	
	
	protected Transform _transform;
	protected GameObject _gameObject;
	protected GUIStyle SelectedTextStyle = new GUIStyle();
	protected int _labelWidth = 128;
	protected int _labelHeight = 32;
	protected GameObject _currentActiveObject;
	
	
	[HideInInspector]
	public bool SubjectActivateOpen = false;
	[HideInInspector]
	public bool SubjectDeactivateOpen = false;
	[HideInInspector]
	public bool SubjectToggleOpen = false;
	
	[HideInInspector]
	public bool MasterActivateOpen = false;
	[HideInInspector]
	public bool MasterDeactivateOpen = false;
	[HideInInspector]
	public bool MasterToggleOpen = false;
	
	[HideInInspector]
	public bool ActivateHighlight = false; //the highlight to show when in editor when this object is going to be activated by another	
	[HideInInspector]
	public bool DeactivateHighlight = false; //the highlight to show when in editor when this object is going to be deactivated by another
	[HideInInspector]
	public bool ToggleHighlight = false; //the highlight to show when in editor when this object is going to be toggled by another
	[HideInInspector]
	public bool HighlightHighlight = false; //the highlight to show when in editor when this object highlight via the info panel
	
	protected Rect _inRect = new Rect();
	protected Rect _outRect = new Rect();
	protected float _depth = 0f;
	protected Camera _cameraToUse;
	protected string _gizmoName = "";
	protected bool _nameConflict = false; //used by the editor to flag this object if it has a name conflict with another object
	
//	public Vector3 InPoint
//	{
//		get 
//		{ 			
//			return new Vector3(_inRect.x - (_labelWidth * 0.5f) - _inRect.width, _inRect.center.y, 0);
//		}
//	}
//	
//	public Vector3 OutPoint
//	{
//		get { return new Vector3( _outRect.x - _labelWidth, _outRect.center.y, 0); }
//	}
	
//	public float Depth
//	{
//		get { return _depth; }
//	}
	
	public bool NameConflict
	{
		get {return _nameConflict;}
		set {_nameConflict = value;}
	}
	
	public string GizmoName
	{
		get {return _gizmoName;}		
	}
	
	virtual protected void Awake ()
	{
	
	}
	
	// Use this for initialization
	virtual protected void Start () 
	{
	
	}
	
	// Update is called once per frame
	virtual protected void Update () 
	{
	
	}	
	
	virtual public void OnSceneGUI()
	{	
		
		//DrawSimpleLabel(Camera.main);				
	}
	
	public void DrawSimpleLabel(Camera cameraToUse)
	{		
		Vector3 distance = cameraToUse.transform.position - transform.position;	
		_cameraToUse = cameraToUse;
		
		SelectedTextStyle = GUI.skin.button;
		SelectedTextStyle.normal.textColor = Color.yellow;
		Vector2 screenCoords = cameraToUse.WorldToScreenPoint(transform.position);
		screenCoords.y = cameraToUse.pixelHeight - screenCoords.y;			
		
		Rect labelRect = new Rect(screenCoords.x - (_labelWidth * 0.5f), screenCoords.y - (_labelHeight * 0.5f), _labelWidth, _labelHeight);
		
		//GUILayout.Window(GetInstanceID(),labelRect,LabelWindow,"", GUI.skin.);
		
	}
		
	public void LabelWindow(int windowID)
	{		
//		GUILayout.BeginHorizontal();
//			DrawSimpleInConnections(_cameraToUse);
//			GUILayout.FlexibleSpace();
//			
//				
//		if( GUILayout.Button(name, SelectedTextStyle) )
//		{
//			Selection.activeGameObject = this.gameObject;		
//		}
//		GUILayout.FlexibleSpace();
//		
//		DrawSimpleOutConnections(_cameraToUse);
//		
//		GUILayout.EndHorizontal();		
	}
	
	virtual protected void OnDrawGizmos()
	{
		if (!DebugMode) { return; }
		//_currentActiveObject = Selection.activeGameObject;
//		if (Selection.activeObject != gameObject)
//		{
//			SubjectActivateOpen = false;
//			SubjectDeactivateOpen = false;
//			SubjectToggleOpen = false;
//		}
	}
	
	virtual protected void OnPlayGizmos()
	{
			
	}
	
	virtual protected void OnEditGizmos()
	{
				
	}
	
//	public void DrawSimpleInConnections(Camera cameraToUse)
//	{
//		GUILayout.BeginVertical();
//			
//			GUILayout.FlexibleSpace();
//			GUILayout.Button("", GUILayout.Width(16));
//			//HandleUtility.Repaint();
//			_inRect = GUILayoutUtility.GetLastRect();
//			GUILayout.FlexibleSpace();
//		
//		GUILayout.EndVertical();
//	}	
//	
//	public void DrawSimpleOutConnections(Camera cameraToUse)
//	{
//		GUILayout.BeginVertical();
//		
//			GUILayout.FlexibleSpace();
//			GUILayout.Button("", GUILayout.Width(16));
//			//HandleUtility.Repaint();
//			_outRect = GUILayoutUtility.GetLastRect();
//			GUILayout.FlexibleSpace();
//		
//		GUILayout.EndVertical();
//	}
	
}
