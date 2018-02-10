using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Test : MonoBehaviour {
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
	public Tile t;

	Queue columns;

	// Use this for initialization
	void Start () {

		T1.size = new Vector3Int (1, 16, 0);
		T1.origin = new Vector3Int (0, 0, 0);
		T2.size = new Vector3Int (1, 16, 0);
		T2.origin = new Vector3Int (1, 0, 0);
		T3.size = new Vector3Int (1, 16, 0);
		T3.origin = new Vector3Int (2, 0, 0);
		T4.size = new Vector3Int (1, 16, 0);
		T4.origin = new Vector3Int (3, 0, 0);
		T5.size = new Vector3Int (1, 16, 0);
		T5.origin = new Vector3Int (4, 0, 0);
		T6.size = new Vector3Int (1, 16, 0);
		T6.origin = new Vector3Int (5, 0, 0);
		T7.size = new Vector3Int (1, 16, 0);
		T7.origin = new Vector3Int (6, 0, 0);
		T8.size = new Vector3Int (1, 16, 0);
		T8.origin = new Vector3Int (7, 0, 0);
		T9.size = new Vector3Int (1, 16, 0);
		T9.origin = new Vector3Int (8, 0, 0);
		T10.size = new Vector3Int (1, 16, 0);
		T10.origin = new Vector3Int (9, 0, 0);
		T11.origin = new Vector3Int (10, 0, 0);
		T11.size = new Vector3Int (1, 16, 0);
		T12.origin = new Vector3Int (11, 0, 0);
		T12.size = new Vector3Int (1, 16, 0);
		T13.origin = new Vector3Int (12, 0, 0);
		T13.size = new Vector3Int (1, 16, 0);
		T14.origin = new Vector3Int (13, 0, 0);
		T14.size = new Vector3Int (1, 16, 0);
		T15.origin = new Vector3Int (14, 0, 0);
		T15.size = new Vector3Int (1, 16, 0);
		T16.origin = new Vector3Int (15, 0, 0);
		T16.size = new Vector3Int (1, 16, 0);
		T17.origin = new Vector3Int (16, 0, 0);
		T17.size = new Vector3Int (1, 16, 0);
		T18.origin = new Vector3Int (17, 0, 0);
		T18.size = new Vector3Int (1, 16, 0);
		T1.FloodFill (new Vector3Int(0,0,0), t);
		T2.FloodFill (new Vector3Int(0,0,0), t);
		T3.FloodFill (new Vector3Int(0,0,0), t);
		T4.FloodFill (new Vector3Int(0,0,0), t);
		T5.FloodFill (new Vector3Int(0,0,0), t);
		T6.FloodFill (new Vector3Int(0,0,0), t);
		T7.FloodFill (new Vector3Int(0,0,0), t);
		T8.FloodFill (new Vector3Int(0,0,0), t);
		T9.FloodFill (new Vector3Int(0,0,0), t);
		T10.FloodFill (new Vector3Int(0,0,0), t);
		T11.FloodFill (new Vector3Int(0,0,0), t);
		T12.FloodFill (new Vector3Int(0,0,0), t);
		T13.FloodFill (new Vector3Int(0,0,0), t);
		T14.FloodFill (new Vector3Int(0,0,0), t);
		T15.FloodFill (new Vector3Int(0,0,0), t);
		T16.FloodFill (new Vector3Int(0,0,0), t);
		T17.FloodFill (new Vector3Int(0,0,0), t);
		T18.FloodFill (new Vector3Int(0,0,0), t);

		columns = new Queue (18);
		columns.Enqueue (T1);
		columns.Enqueue (T2);
		columns.Enqueue (T3);
		columns.Enqueue (T4);
		columns.Enqueue (T5);
		columns.Enqueue (T6);
		columns.Enqueue (T7);
		columns.Enqueue (T8);
		columns.Enqueue (T9);
		columns.Enqueue (T10);
		columns.Enqueue (T11);
		columns.Enqueue (T12);
		columns.Enqueue (T13);
		columns.Enqueue (T14);
		columns.Enqueue (T15);
		columns.Enqueue (T16);
		columns.Enqueue (T17);
		columns.Enqueue (T18);



	}
	
	// Update is called once per frame
	void Update () {
		T1.transform.Translate (Vector3.left * Time.deltaTime ); 
		T2.transform.Translate (Vector3.left * Time.deltaTime ); 
		T3.transform.Translate (Vector3.left * Time.deltaTime ); 
		T4.transform.Translate (Vector3.left * Time.deltaTime ); 
		T5.transform.Translate (Vector3.left * Time.deltaTime ); 
		T6.transform.Translate (Vector3.left * Time.deltaTime ); 
		T7.transform.Translate (Vector3.left * Time.deltaTime ); 
		T8.transform.Translate (Vector3.left * Time.deltaTime ); 
		T9.transform.Translate (Vector3.left * Time.deltaTime ); 
		T10.transform.Translate (Vector3.left * Time.deltaTime ); 
		T11.transform.Translate (Vector3.left * Time.deltaTime ); 
		T12.transform.Translate (Vector3.left * Time.deltaTime ); 
		T13.transform.Translate (Vector3.left * Time.deltaTime ); 
		T14.transform.Translate (Vector3.left * Time.deltaTime ); 
		T15.transform.Translate (Vector3.left * Time.deltaTime ); 
		T16.transform.Translate (Vector3.left * Time.deltaTime ); 
		T17.transform.Translate (Vector3.left * Time.deltaTime ); 
		T18.transform.Translate (Vector3.left * Time.deltaTime ); 


	}
}
