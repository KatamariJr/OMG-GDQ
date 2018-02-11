using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

public class TotallyTile : Tile { //Totally!

    public const int WATER = 0;
    public const int INLAND = 1;
    public const int COAST = 2;
    public const int COAST_UD = 3;
    public const int COAST_DD = 4;
    public const int COAST_L_CR = 5;
    public const int COAST_R_CR = 6;

    private int terrainType;
    private int variation;
    private bool flipped;

#if UNITY_EDITOR
       [MenuItem("Assets/Create/Tiles/TotallyTile")]
       public static void CreateTotallyTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Totally Tile", "New Totally Tile", "Asset", "Save Totally Tile", "Assets");
        if (path == "")
        {
            return;
        }
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<TotallyTile>(), path);
    }
#endif
    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        Scrolling s = GameObject.Find("World").GetComponent(typeof(Scrolling)) as Scrolling;
        int index = (terrainType * 3) + (variation);
        if (position.y >0)
        {
            
        }
        tileData.sprite = s.getSprites()[index];

    }

    public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
    {
       if (terrainType == INLAND || terrainType == WATER)
        {
            return false;
        }
        Scrolling s = GameObject.Find("World").GetComponent(typeof(Scrolling)) as Scrolling;
        int index = (terrainType * 3) + (variation - 1);
        tileAnimationData.animatedSprites = s.getEverySprite(index);
        tileAnimationData.animationSpeed = 1f;
        return true;
    }
    public override void RefreshTile(Vector3Int position, ITilemap tilemap)
    {
        base.RefreshTile(position, tilemap);
    }

    public void changeTile(int terrain, int vari)
    {
        terrainType = terrain;
        variation = vari;
        if (vari == 0)
        {
            variation = tileVariation();
        }
    }

    public int tileVariation()  //1 to 3
    {
        return (int) (Random.value * 2)+1;
    }

    public void flip()
    {
        this.flipped = true;
    }

    public TotallyTile init(int t, int v)
    {
        changeTile( t,v);
        return this;
    }

    public TotallyTile init(int t)
    {
        changeTile(t, tileVariation());
        return this;
    }

    public TotallyTile init()
    {
        changeTile(0, 0);
        return this;
    }


}
