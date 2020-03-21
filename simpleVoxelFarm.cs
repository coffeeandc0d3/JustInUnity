using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleVoxelFarm : MonoBehaviour
{
  public GameObject currentBlockType;
  public float amp = 10f;
  public float freq = 10f;

  private Vector3 myPos;
    // Start is called before the first frame update
    void Start()
    {
        generateTerrain();
    }

  void generateTerrain()
    {
        myPos = this.transform.position;
        int cols = 100;
        int rows = 100;
    
    for (int x = 0; x < cols; x++)
        {
      for (int z = 0; z < rows; z++)
            {
              float y = Mathf.PerlinNoise(x / freq, z / freq) * amp;
             GameObject newBlock = GameObject.Instantiate(currentBlockType);
             newBlock.transform.position = new Vector3(myPos.x + x, y, myPos.z + z);
            }
 
        }
    
    }
}
