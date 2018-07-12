using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMan : MonoBehaviour {
    [Header("Player Settings")]
    public int DrawDis = 10;
    [Header("GO's")]
    public GameObject Player;
    public List<GameObject> PreFabsForWorldGen;
    [Header("UI stuff")]
    public List<GameObject> ListOfHp;
    public List<GameObject> ListOfMana;
    public Slider HpBar;
    public Slider ManaBar;
    [Header("World Gen stuff")]
    public int MaxX;
    public int MinX = 0;
    public int MaxZ;
    public int MinZ = 0;
    public float Amp;
    public int MegaAmp;
    public Material DefMat;
    public List<Material> WorldMats;
    public List<Vector3> BlockData;
    public List<Vector3> UnderGroundBlockData;
    [Header("Biome mods")]
    public int ChanceOfTrees = 1;
    [Header("DEV")]
    public int AddedDataCount = 0;
    


    void UpdateHpBar()
    {
        if (HpBar.value >= 1)
        {
            ListOfHp[10].SetActive(true); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.9)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(true); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.8)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(true); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.7)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(true); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.6)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(true); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.5)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(true); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.4)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(true); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.3)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(true); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.2)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(true); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value < 0.1)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(true); // 10
            ListOfHp[0].SetActive(false); // 0
        }
        if (HpBar.value <= 0)
        {
            ListOfHp[10].SetActive(false); // 100
            ListOfHp[9].SetActive(false); // 90
            ListOfHp[8].SetActive(false); // 80
            ListOfHp[7].SetActive(false); // 70
            ListOfHp[6].SetActive(false); // 60
            ListOfHp[5].SetActive(false); // 50
            ListOfHp[4].SetActive(false); // 40
            ListOfHp[3].SetActive(false); // 30
            ListOfHp[2].SetActive(false); // 20
            ListOfHp[1].SetActive(false); // 10
            ListOfHp[0].SetActive(true); // 0
        }
    }
    void UpdateManaBar()
    {
        if (ManaBar.value == 0)
        {
            ListOfMana[10].SetActive(true); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.1)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(true); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.2)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(true); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.3)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(true); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.4)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(true); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.5)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(true); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.6)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(true); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.7)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(true); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.8)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(true); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value > 0.9)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(true); // 10
            ListOfMana[0].SetActive(false); // 0
        }
        if (ManaBar.value >= 1)
        {
            ListOfMana[10].SetActive(false); // 100
            ListOfMana[9].SetActive(false); // 90
            ListOfMana[8].SetActive(false); // 80
            ListOfMana[7].SetActive(false); // 70
            ListOfMana[6].SetActive(false); // 60
            ListOfMana[5].SetActive(false); // 50
            ListOfMana[4].SetActive(false); // 40
            ListOfMana[3].SetActive(false); // 30
            ListOfMana[2].SetActive(false); // 20
            ListOfMana[1].SetActive(false); // 10
            ListOfMana[0].SetActive(true); // 0
        }
    }
    void DrawBlocks() // Out of date
    {
       
        /*if (BlockData.Contains(new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y), Mathf.RoundToInt(Player.transform.position.z))))
        {
            Debug.Log("FOUND BLOCK @ " + new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y), Mathf.RoundToInt(Player.transform.position.z)));
           // GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            // Cube.transform.position = Player.transform.position;
            //Cube.GetComponent<Renderer>().material = DefMat;
           // Cube.name = "Chunk_" + Chunks.Count;
            Player.transform.position = new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y) + 10, Mathf.RoundToInt(Player.transform.position.z));
            
            BlockData.Remove(new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y), Mathf.RoundToInt(Player.transform.position.z)));
            Vector3 RoundedPlayer = new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y), Mathf.RoundToInt(Player.transform.position.z));
            
           // Debug.Log("[SB]" + StartBlock);
            
        }*/
        /*
        Vector3 StartBlock = new Vector3(Mathf.RoundToInt(Player.transform.position.x), Mathf.RoundToInt(Player.transform.position.y), Mathf.RoundToInt(Player.transform.position.z));
        //Vector3 StartBlock = new Vector3(Player.transform.position.x,Player.transform.position.y,Player.transform.position.z);
        for (float z = (StartBlock.z * -1); z < DrawDis; z += 1f)
        {
            for (float x =(StartBlock.x * -1); x < DrawDis; x += 1f)
            {
                for (float y =( StartBlock.y * -1); y < DrawDis; y += 1f)
                {
                    if (BlockData.Contains(new Vector3(x, y, z)))
                    {
                        Debug.Log("FOUND BLOCK [xbp] @ " + new Vector3(x, y, z));
                        GameObject Cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Cube2.transform.position = new Vector3(x, y, z);

                        Cube2.GetComponent<Renderer>().material = DefMat;
                        BlockData.Remove(new Vector3(x, y, z));

                    }
                }
            }
        }
        */

    }
    void DrawblocksV2(int Min, int Max)
    {
        for (int x = Min; x < Max; x++)
        {
            for (int y = Min; y < Max; y++)
            {
                for (int z = Min; z < Max; z++)
                {
                    if (BlockData.Contains(new Vector3(x, y, z)))
                    {
                        GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Cube.transform.position = new Vector3(x, y, z);
                        BlockData.Remove(Cube.transform.position);
                    }
                }
            }
        }
    }
    void DrawBlocksV3()
    {
        for (int i = 0; i < BlockData.Count; i++)
        {
            for (int Draw = (DrawDis * -1); Draw < DrawDis; Draw++)
            {
                if ((BlockData[i].x == Mathf.Round(Player.transform.position.x) + Draw || BlockData[i].z == Mathf.Round(Player.transform.position.z) + Draw ) && ((BlockData[i].x < Mathf.Round(Player.transform.position.x) + DrawDis)&& (BlockData[i].z < Mathf.Round(Player.transform.position.z) + DrawDis)))
                {
                    GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Cube.transform.position = new Vector3(BlockData[i].x, BlockData[i].y, BlockData[i].z);
                    Cube.GetComponent<Renderer>().material = DefMat;
                    BlockData.Remove(BlockData[i]);
                    if(Random.Range(0,1000) < ChanceOfTrees)
                    {
                        // make a tree
                        GameObject Tree = GameObject.Instantiate(PreFabsForWorldGen[0]);
                        Tree.transform.position = new Vector3(Cube.transform.position.x, Cube.transform.position.y + 0.5f, Cube.transform.position.z);

                    }
                    // Make blocks under you
                    Vector3 StonePos = new Vector3(Cube.transform.position.x,Cube.transform.position.y - 1,Cube.transform.position.z);
                    while (StonePos.y != 0)
                    {
                        // make stone!
                        //GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        UnderGroundBlockData.Add(StonePos);
                        //Stone.GetComponent<Renderer>().material = WorldMats[0];
                        //Stone.name = "Stone";
                       StonePos = new Vector3(Cube.transform.position.x, StonePos.y - 1, Cube.transform.position.z);
                    }
                    

                }
            }
            

        }
    }
    void DelData(int Max)
    {
        for (int i = 0; i < Max; i++)
        {
            BlockData.Remove(BlockData[i]);
        }
    }
    void AddData()
    {
        BlockData.Clear();
        AddedDataCount++;
        for (int z = MinZ; z < MaxZ; z++)
        {
            for (int x = MinX; x < MaxX; x++)
            {

                //  GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                // for the sake of looking good.
                //Cube.GetComponent<Renderer>().material = DefMat;
                // Cube.transform.position = new Vector3(x,(Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp,z);
                //Cube.name = "fakeblock";
                //if (!BlockData.Contains(new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt((Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp), Mathf.RoundToInt(z))))
                BlockData.Add(new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt((Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp), Mathf.RoundToInt(z)));
            }
        }
    }
    public void MakeStone(Vector3 DisBlockCords)
    {
        int MineRad = 1;
        //Debug.LogError("GOT THE MESSAGE BUT I AM NOT DOING SH!T");
        // HERE we make stone! well not make it but using data from UndergroundBlockData we make blocks!
        for (int i = 0; i < MineRad; i++)
        {
            // Y +
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y + MineRad, DisBlockCords.z))))
            {
                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y + MineRad, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // X +
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x + MineRad, DisBlockCords.y, DisBlockCords.z))))
            {
                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x + MineRad, DisBlockCords.y, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Z +
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z + MineRad))))
            {
                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z + MineRad));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Y -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y - MineRad, DisBlockCords.z))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y - MineRad, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // X -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x - MineRad, DisBlockCords.y, DisBlockCords.z))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x - MineRad, DisBlockCords.y, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Z -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z - MineRad))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z - MineRad));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
        }

    }
    public void PlaceBlock(Vector3 BlockCords)
    {
        GameObject NewBlock = GameObject.CreatePrimitive(PrimitiveType.Cube);
        NewBlock.transform.position = new Vector3(BlockCords.x, BlockCords.y+1, BlockCords.z);
        NewBlock.GetComponent<Renderer>().material = WorldMats[1];
    }

    // Use this for initialization
    void Start () {
        AddData();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateHpBar();
        UpdateManaBar();
        DrawBlocksV3();

        // right now the world has a like idk 2k block lim to help make rpg stuff
        // Also uped the draw dis so that people would not have to walk around!
        // Mega Amp = more/less hills
      /*  if (BlockData.Count < 500 * (AddedDataCount))
        {
            // make more data
            MinX = 500 * (AddedDataCount);
            MinZ = 500 * (AddedDataCount);
            MaxX += MaxX;
            MaxZ += MaxZ;
            AddData();
        }
        */
    }
}
