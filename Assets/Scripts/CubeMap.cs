using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMap : MonoBehaviour
{
    public GameObject _obj;

    [SerializeField]
    private Vector3Int _vec;

    private Cube[,,] _cubes;

    private Queue<Cube>[] _frontQueue;
    private Queue<Cube>[] _heightQueue;
    private Queue<Cube>[] _widthQueue;
    void Start()
    {
        _cubes = new Cube[_vec.x, _vec.y, _vec.z];
        for (int i = 0; i< _vec.x; i++)
		{
            for(int j = 0; j<_vec.y; j++)
			{
                for(int l =0; l<_vec.z; l++)
				{
                    GameObject obj = Instantiate(_obj, this.transform);
                    obj.transform.localPosition = new Vector3(i*1.1f, j*1.1f, l*1.1f);
                    _cubes[i,j,l] = obj.GetComponent<Cube>();
                    Cube cubeObj = _cubes[i, j, l];
                    cubeObj.pos = new Vector3Int(i, j, l);

                    //_frontQueue[l].Enqueue(cubeObj);
                    //_heightQueue[j].Enqueue(cubeObj);
                    //_widthQueue[i].Enqueue(cubeObj);
                }
			}
		}
    }

    void Update()
    {

    }

    void FrontRotate(int row, bool isColockWise = true)
	{
        if(isColockWise)
		{
            for(int i = 0; i< _vec.y; i++)
			{
                
			}
		}
        else
		{

		}
	}
}
