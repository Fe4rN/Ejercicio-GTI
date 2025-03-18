using System.Collections.Generic;
using UnityEngine;

public class EnemiesRandomizer : MonoBehaviour
{

    [SerializeField] GameObject cell;
    // [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject corner;
    [SerializeField] GameObject table;
    [SerializeField] GameObject enemy;
    [SerializeField] float cellSize = 4;
    [SerializeField] int quantity = 5;
    [SerializeField] float size = 5;

    void Awake()
    {
        float initX = (cellSize * (size - 1)) / 2;
        float initY = (cellSize * (size - 1)) / 2;

        Dictionary<string, Transform> cells = new Dictionary<string, Transform>();

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                Vector3 pos = new Vector3(i * cellSize - initX, 0, j * cellSize - initY);

                if(i==0 && j==0)
                {
                    Transform w = Instantiate(corner, pos, Quaternion.identity).transform;
                    w.Rotate(Vector3.up, 180);
                    continue;
                }

                if(i==0 && j==size-1)
                {
                    Transform w = Instantiate(corner, pos, Quaternion.identity).transform;
                    w.Rotate(Vector3.up, -90);
                    continue;
                }

                if(i==size-1 && j==0)
                {
                    Transform w = Instantiate(corner, pos, Quaternion.identity).transform;
                    w.Rotate(Vector3.up, 90);
                    continue;
                }

                if(i==size-1 && j==size-1)
                {
                    Transform w = Instantiate(corner, pos, Quaternion.identity).transform;
                    continue;
                }

                if(i == 0 || i == size -1 || j == 0 || j == size -1)
                {
                    Transform w = Instantiate(wall, pos, Quaternion.identity).transform;
                    if(j == 0) w.Rotate(Vector3.up, 180);
                    if(i == 0) w.Rotate(Vector3.up, -90);
                    if(i == size - 1) w.Rotate(Vector3.up, 90);
                    continue;
                }

                GameObject newCell = Random.Range(0f, 1f) < .8f ? cell : table;

                if(newCell == cell) {
                    // Debug.Log($"f: {i} - j: {j}");
                    //Transform upCell = cells.get[$"f: {i -1} - j: {j}"];
                    if(cells.TryGetValue($"f: {i -1} - j: {j}", out Transform upCell)
                        && upCell.CompareTag("Table")){
                        newCell = enemy;
                    }
                }

                cells.Add($"f: {i} - j: {j}", Instantiate(newCell, pos, Quaternion.identity).transform);
            }
        }


    //Generación de enemigos
        // for (int i = 0; i < quantity; i++)
        // {
        //     Transform currentCell = cells[Random.Range(0, cells.Count)];
        //     cells.Remove(currentCell);
        //     Vector2 randomPos = Random.insideUnitCircle;
        //     Vector3 newPos = new Vector3(randomPos.x, 0, randomPos.y);
        //     newPos *= cellSize - 1;
        //     Instantiate(enemyPrefab, currentCell.position + newPos, Quaternion.identity);
        // }
    }

}
