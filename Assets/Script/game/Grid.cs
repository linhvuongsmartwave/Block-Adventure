using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int colums = 0;
    public int rows = 0;
    public float squaresGap = 0.1f;
    public GameObject gridSquare;
    public  Vector2 startPosition = new Vector2 (0, 0);
    public float squareScale = 0.5f;
    public float everySquareOffset = 0f;
    private List<GameObject> _gridSquares = new List<GameObject>(); 



    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        SpawnGridSquares();
        SetGridSquaresPosition();
    }


    public void SpawnGridSquares()
    {


        int square_index = 0;
        for (var row=0;row<rows;++row)
        {
            _gridSquares.Add(Instantiate(gridSquare) as GameObject);
            _gridSquares[_gridSquares.Count - 1].transform.SetParent(this.transform);
            _gridSquares[_gridSquares.Count - 1].transform.localScale=new Vector3 (squareScale,squareScale,squareScale);
        }
    }
    public void SetGridSquaresPosition()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
