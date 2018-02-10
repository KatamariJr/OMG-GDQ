using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Scrolling : MonoBehaviour {
    public float scrollSpeed;
	public Tilemap T1;
	public Tilemap T2;
	public Tilemap T3;
	public Tilemap T4;
	public Tilemap T5;
	public Tilemap T6;
	public Tilemap T7;
	public Tilemap T8;
	public Tilemap T9;
	public Tilemap T10;
	public Tilemap T11;
	public Tilemap T12;
	public Tilemap T13;
	public Tilemap T14;
	public Tilemap T15;
	public Tilemap T16;
	public Tilemap T17;
	public Tilemap T18;
    
    [SerializeField]
	public Sprite[] allSprites;

	private Queue <Tilemap> columns;
    

	// Use this for initialization
	void Start () {

        columns = new Queue<Tilemap>(18);
        columns.Enqueue(T1);
        columns.Enqueue(T2);
        columns.Enqueue(T3);
        columns.Enqueue(T4);
        columns.Enqueue(T5);
        columns.Enqueue(T6);
        columns.Enqueue(T7);
        columns.Enqueue(T8);
        columns.Enqueue(T9);
        columns.Enqueue(T10);
        columns.Enqueue(T11);
        columns.Enqueue(T12);
        columns.Enqueue(T13);
        columns.Enqueue(T14);
        columns.Enqueue(T15);
        columns.Enqueue(T16);
        columns.Enqueue(T17);
        columns.Enqueue(T18);


        int i = 0;
        foreach (Tilemap t in columns)
        {
            t.size = new Vector3Int(1, 16, 0);
            t.transform.Translate(new Vector3Int(9-i, -8, 0));
            for (int j = 0; j < 16; j++)
            {
                if (j < 2 || j >13)
                {

                    t.SetTile(new Vector3Int(0, j, 0), TotallyTile.CreateInstance<TotallyTile>().init(TotallyTile.INLAND));
                }
                else if (j == 2 || j == 13)
                {

                    t.SetTile(new Vector3Int(0, j, 0), TotallyTile.CreateInstance<TotallyTile>().init(TotallyTile.COAST));
                }
                else
                {
                    t.SetTile(new Vector3Int(0, j, 0), TotallyTile.CreateInstance<TotallyTile>().init(TotallyTile.INLAND));
                }

            }
            //t.FloodFill(Vector3Int.zero, new TotallyTile(0,0));
            t.FloodFill(Vector3Int.zero, tile);
            i++;
        }

	}
	
	// Update is called once per frame
	void Update () {
        ScrollTiles();
	}

    void ScrollTiles()
    {
        bool popQueue = false;
        foreach (Tilemap t in columns)
        {
            t.transform.Translate(Vector3.left *scrollSpeed* Time.deltaTime);
            if (t.transform.position.x <= -8)
            {
                t.transform.Translate(new Vector3(18, 0, 0));
                popQueue = true;
            }
        }
        if (popQueue)
        {
            columns.Enqueue(columns.Dequeue()); //Back to the end of the line!!!
        }
    }

    public  Sprite[] getSprites()
    {
        return allSprites;
    }

}
