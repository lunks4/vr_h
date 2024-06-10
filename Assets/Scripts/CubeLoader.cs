using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



[System.Serializable]
public class CubePosition
{
  public float x;
  public float y;
  public float z;
}

[System.Serializable]
public class CubeColor
{
  public float r;
  public float g;
  public float b;
}

[System.Serializable]
public class CubeData
{
  public CubePosition position;
  public CubeColor color;
}


public class CubeLoader : MonoBehaviour

{

  public GameObject cubePrefab;

  public CubeData GetCubeData()
  {
    string path = Application.dataPath + "/Data/Cube.json"; // Path to your JSON file
    string json = File.ReadAllText(path); // Read the JSON file

    CubeData data = JsonUtility.FromJson<CubeData>(json); // Deserialize the JSON into your Data class
    // Access the data
    Debug.Log("Position: (" + data.position.x + ", " + data.position.y + ", " + data.position.z + ")");
    Debug.Log("Color: (" + data.color.r + ", " + data.color.g + ", " + data.color.b + ")");
    return data;

  }

  public void Start()
  {

    LoadCube();
  }
  public void LoadCube()
  {
    var data = GetCubeData();
    GameObject newCube = Instantiate(cubePrefab, new Vector3(data.position.x, data.position.y, data.position.z), new Quaternion(0, 0, 0, 0));
    Renderer renderer = newCube.GetComponent<Renderer>();
    renderer.material.color = new Color(data.color.r, data.color.g, data.color.b);
    Debug.Log("cube loaded");
  }

}
