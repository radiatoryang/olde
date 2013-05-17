using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AutoBrush : MonoBehaviour {
    public Mesh shell; // basic CSG / BSP shell, used for collision
    public BrushSurface[] surfaces; // a BrushSurface is a plane, and can be made of many faces
    public BrushSection[] sections; // a BrushSection is a modular chunk of faces

    public BrushFace[] faces;
    public BrushEdge[] edges;
    public Vector3[] verticesLocal;
    public Vector3[] verticesWorld; // property


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // called in editor when AutoBrush regenerates its shell; use this for structural stuff (windows, doors)
    void OnBrushShell() {

    }

    void OnBrushDetail() {

    }


}

[System.Serializable]
public class BrushSurface {
    public Material material;
    public Vector2 uvScale;
    public Vector2 uvRotation;
    public Vector2 uvOffset;
}

[System.Serializable]
public class BrushSection {

}

[System.Serializable]
public class BrushFace {
    public bool isOutward; // make this a property
}

[System.Serializable]
public class BrushEdge {

}


