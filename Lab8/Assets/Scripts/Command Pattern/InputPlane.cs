using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlane : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    public Transform cubePrefab;
    public Transform capPrefab;

    private bool spawnCube;

    // Start is called before the first frame update
    void Awake()
    {
        maincam = Camera.main;
        spawnCube = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnCube = !spawnCube;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
                //CubePlacer.PlaceCube(hitInfo.point, c, cubePrefab);
                if(spawnCube == true)
                {
                    ICommand command = new PlaceCubeCommand(hitInfo.point, c, cubePrefab);
                    CommandInvoker.AddCopmmand(command);
                }                
                if(spawnCube == false)
                {
                    ICommand command = new PlaceCubeCommand(hitInfo.point, c, capPrefab);
                    CommandInvoker.AddCopmmand(command);
                }  
                
            }
        }
        
    }

    public void SetCubeClick()
    {
        spawnCube = true;
    }
    public void SetCapClick()
    {
        spawnCube = false;
    }
}
