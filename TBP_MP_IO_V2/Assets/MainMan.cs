using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMan : MonoBehaviour {
    [Header("[[Player Settings]]")]
    public int DrawDis = 10;
    [Header("[[GO]]")]
    public GameObject Player;
    public List<GameObject> PreFabsForWorldGen;
    [Header("[[UI]]")]
    public List<GameObject> ListOfHp;
    public List<GameObject> ListOfMana;
    public List<GameObject> UIGos;
    public GameObject UIItemPreFab;
    public Slider HpBar;
    public Slider ManaBar;
    public GameObject Items;
    public Image PlayerSelMat;
    public List<Sprite> WorldUI;
    public List<string> Inv;
    public int InvMax;
    string LastActiveButton;
    public List<GameObject> ActiveButtons;
    bool InvOpen = false;
    [Header("[[World Gen]]")]
    public int MaxX;
    public int MinX = 0;
    public int MaxZ;
    public int MinZ = 0;
    public float Amp;
    public int MegaAmp;
    public Material PlayerMat;
    public List<Material> WorldMats;
    public List<Vector3> BlockData;
    public List<Vector3> UnderGroundBlockData;
    public List<GameObject> LoadedBlocks;
    [Header("[[Biome mods]]")]
    public int ChanceOfTrees = 1;
    //[Header("<<DEV>>")]
    //public string ReadMe = "Nothing in Dev Right now! ;D";

    // Local meth

    
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
    void LoadBlocks()
    {
        for (int i = 0; i < BlockData.Count; i++)
        {
            for (int Draw = (DrawDis * -1); Draw < DrawDis; Draw++)
            {
                //BlockData.Add(new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt((Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp), Mathf.RoundToInt(z)));


                if (BlockData.Count != 0)
                if (
                        // I want all blocks that have a x with in +10 and -10 from me
                        BlockData[i].x > (Player.transform.position.x -10f) &&
                        BlockData[i].x < (Player.transform.position.x + 10f) &&
                        BlockData[i].z > (Player.transform.position.z - 10f) &&
                        BlockData[i].z < (Player.transform.position.z + 10f)
                   )
                {
                    GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Cube.transform.position = new Vector3(BlockData[i].x, BlockData[i].y, BlockData[i].z);
                    Cube.GetComponent<Renderer>().material = WorldMats[2];
                        Cube.transform.gameObject.name = "Grass";
                    BlockData.Remove(BlockData[i]);
                    LoadedBlocks.Add(Cube);




                        if (Random.Range(0,1000) < ChanceOfTrees)
                    {
                        // make a tree
                        GameObject Tree = GameObject.Instantiate(PreFabsForWorldGen[0]);
                        Tree.transform.position = new Vector3(Cube.transform.position.x, Cube.transform.position.y + 0.5f, Cube.transform.position.z);

                    } // make a tree code
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
    void UnLoadBlocks()
    {
        
        for (int i = 0; i < LoadedBlocks.Count; i++)
        {
            if (
                        // I want all blocks that have a x with in +10 and -10 from me
                        // I want all blocks that are outside of the +10/-10 range to die.
                        !(LoadedBlocks[i].transform.position.x > (Player.transform.position.x - 10f) &&
                        LoadedBlocks[i].transform.position.x < (Player.transform.position.x + 10f) &&
                        LoadedBlocks[i].transform.position.z > (Player.transform.position.z - 10f) &&
                        LoadedBlocks[i].transform.position.z < (Player.transform.position.z + 10f))
                   )
            {
                // unload block
                BlockData.Add(LoadedBlocks[i].transform.position);
                GameObject Thing = LoadedBlocks[i];
                LoadedBlocks.Remove(Thing);
                GameObject.Destroy(Thing);
                
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
                if(!BlockData.Contains(new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt((Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp), Mathf.RoundToInt(z))))
                BlockData.Add(new Vector3(Mathf.RoundToInt(x), Mathf.RoundToInt((Mathf.PerlinNoise(x * Amp, z * Amp)) * MegaAmp), Mathf.RoundToInt(z)));
            }
        }
    }
    void UpdateUI()
    {
        UpdateHpBar();
        UpdateManaBar();
        KeyCheck();
    }
    void KeyCheck()
    {

        if (Input.GetKeyDown("i"))
        {
            if (InvOpen == true)
            {
                // close it
                Player.SetActive(true);
                Items.SetActive(false);
                InvOpen = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                // open it
                Player.SetActive(false);
                Items.SetActive(true);
                InvOpen = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    void SetActiveAllButtons(bool state)
    {
        UIGos[1].SetActive(state);
        UIGos[2].SetActive(state);
        UIGos[3].SetActive(state);
        UIGos[4].SetActive(state);
        UIGos[5].SetActive(state);
        UIGos[6].SetActive(state);
        UIGos[7].SetActive(state);
        UIGos[8].SetActive(state);
        UIGos[9].SetActive(state);
    }
    void ClearCraftingBg()
    {
        UIGos[1].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[2].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[3].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[4].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[5].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[6].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[7].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[8].transform.GetChild(0).GetComponent<Text>().text = "";
        UIGos[9].transform.GetChild(0).GetComponent<Text>().text = "";
    }
    void Start()
    {
        AddData();
        // UI booting zone
        PlayerMat = WorldMats[0];

        // end of UI booting zone
    }
    void Update()
    {
        UpdateUI(); // Keeps the UI up to date
        LoadBlocks(); // Loads blocks into the world (just drawing the data)
        UnLoadBlocks(); // Unloads the blocks into data [Underground is not unloaded...]
    }
    // Street Meth

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
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y + MineRad, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // X +
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x + MineRad, DisBlockCords.y, DisBlockCords.z))))
            {
                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x + MineRad, DisBlockCords.y, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Z +
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z + MineRad))))
            {
                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z + MineRad));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Y -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y - MineRad, DisBlockCords.z))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y - MineRad, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // X -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x - MineRad, DisBlockCords.y, DisBlockCords.z))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x - MineRad, DisBlockCords.y, DisBlockCords.z));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
            // Z -
            if ((UnderGroundBlockData.Contains(new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z - MineRad))))
            {

                GameObject Stone = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Stone.GetComponent<Renderer>().material = WorldMats[0];
                Stone.transform.gameObject.name = "Stone";
                Stone.transform.position = (new Vector3(DisBlockCords.x, DisBlockCords.y, DisBlockCords.z - MineRad));
                UnderGroundBlockData.Remove(Stone.transform.position);
            }
        }

    }
    public void PlaceBlock(Vector3 BlockCords)
    {
        GameObject NewBlock = GameObject.CreatePrimitive(PrimitiveType.Cube);
        NewBlock.transform.position = new Vector3(BlockCords.x, BlockCords.y+1, BlockCords.z);
        NewBlock.GetComponent<Renderer>().material = PlayerMat;
    }
    public void RemoveBlock(GameObject BlockThatIsRemoved)
    {
        BlockData.Remove(BlockThatIsRemoved.transform.position);
        if (LoadedBlocks.Contains(BlockThatIsRemoved))
        {
            // kill it
            LoadedBlocks.Remove(BlockThatIsRemoved);
            
        }
    }
    public void SwitchBlock(int BlockID)
    {
        PlayerMat = WorldMats[BlockID];
        PlayerSelMat.sprite = WorldUI[BlockID];
        //Debug.Log("Switched to BLOCK_ID:" + BlockID);
    }
    public bool AddThingToInv(string Thing)
    {

        // later we need to update UI here

        if (Inv.Count < InvMax)
        {
            Inv.Add(Thing);
            return true; // this takes the thing from world
        }
        else
        {
            Debug.LogError("INV ERROR: player is out of room!");
            return false;
        }
        
    }
    public void UpdateCraftingScreen(string Place)
    {
        if (Inv.Count != 0)
        {
            //Debug.Log("I WAS CALLED!");
            // this is a call from a UI button the location of that button is located some whare on the screen
            // thus the Place string Place could = MidLeft Mid Mid Mid Right and so on this is used in finding where to put the UI element from the inv to the grid
            // now we are going to pop up the inv and fill it with stuff
            //1st we pull up the inv
            UIGos[0].SetActive(true);
            // next lets show the correct button...
            // UIGos[10] = Item Prefab
            for (int i = 0; i < Inv.Count; i++)
            {
                // make a new button!
                GameObject Button = GameObject.Instantiate(UIItemPreFab, UIItemPreFab.transform.parent);
                Button.GetComponent<Image>().enabled = true;
                Button.GetComponentInChildren<Text>().enabled = true;
                Button.GetComponent<Button>().enabled = true;
                Button.GetComponentInChildren<Text>().text = Inv[i];
                Button.name = Inv[i];
                string thing = Inv[i];
                Button.GetComponent<Button>().onClick.AddListener(delegate { AddToCrafting(thing); });
                //Button.GetComponent<RectTransform>().transform.position = new Vector3(XValue, YValue, 0);
                Button.transform.position = new Vector3(UIItemPreFab.transform.position.x + (75 * i), UIItemPreFab.transform.position.y, UIItemPreFab.transform.position.z);
                ActiveButtons.Add(Button);
                //new Vector3(XValue, YValue, 0);
                //Button.GetComponent<RectTransform>().transform.position = new Vector3(XValue, YValue, 0);
                // for now no pics...
            }
            LastActiveButton = Place;
            if (Place == "BotLeft")
            {
                UIGos[1].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[1].SetActive(true); // locks it to that button
            }
            if (Place == "BotMid")
            {
                UIGos[2].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[2].SetActive(true); // locks it to that button
            }
            if (Place == "BotRight")
            {
                UIGos[3].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[3].SetActive(true); // locks it to that button
            }
            if (Place == "MidLeft")
            {
                UIGos[4].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[4].SetActive(true); // locks it to that button
            }
            if (Place == "MidMid")
            {
                UIGos[5].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[5].SetActive(true); // locks it to that button
            }
            if (Place == "MidRight")
            {
                UIGos[6].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[6].SetActive(true); // locks it to that button
            }
            if (Place == "TopLeft")
            {
                UIGos[7].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[7].SetActive(true); // locks it to that button
            }
            if (Place == "TopMid")
            {
                UIGos[8].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[8].SetActive(true); // locks it to that button
            }
            if (Place == "TopRight")
            {
                UIGos[9].GetComponent<Image>().color = new Color(0, 100, 0, 1);
                SetActiveAllButtons(false);
                UIGos[9].SetActive(true); // locks it to that button
            }
        }
        else
        {
            Debug.LogError("Player tryed to craft with nothing in inv");
        }
    }
    public void AddToCrafting(string Thing)
    {
        // remove it from inv and find the button that is still active
        Inv.Remove(Thing);
        // but put it's text in the place of button
        for (int i = 0; i < ActiveButtons.Count; i++)
        {
            GameObject.Destroy(ActiveButtons[i]);
        }
        if (LastActiveButton == "BotLeft")
        {
            UIGos[1].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[1].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0],UIGos[0].transform.parent);
            UIGos[0].name = "REMOVED";
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
            

        }
        if (LastActiveButton == "BotMid")
        {
            UIGos[2].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[2].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
          //  NewUI.SetActive(false);
        }
        if (LastActiveButton == "BotRight")
        {
            UIGos[3].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[3].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
            //NewUI.SetActive(false);
        }
        if (LastActiveButton == "MidLeft")
        {
            UIGos[4].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[4].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
          //  NewUI.SetActive(false);
        }
        if (LastActiveButton == "MidMid")
        {
            UIGos[5].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[5].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
           // NewUI.SetActive(false);
        }
        if (LastActiveButton == "MidRight")
        {
            UIGos[6].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[6].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
           // NewUI.SetActive(false);
        }
        if (LastActiveButton == "TopLeft")
        {
            UIGos[7].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[7].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
           // NewUI.SetActive(false);
        }
        if (LastActiveButton == "TopMid")
        {
            UIGos[8].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[8].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
            //NewUI.SetActive(false);
        }
        if (LastActiveButton == "TopRight")
        {
            UIGos[9].GetComponent<Image>().color = new Color(0, 100, 0, 1);
            UIGos[9].GetComponentInChildren<Text>().text = Thing;
            SetActiveAllButtons(true);
            // clean up!
            // we need to distroy the current obj
            GameObject NewUI = GameObject.Instantiate(UIGos[0], UIGos[0].transform.parent);
            GameObject.Destroy(UIGos[0]);
            UIGos[0] = NewUI;
            
        }
        
        UIItemPreFab = UIGos[0].transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
        
        UIGos[0].SetActive(false);
    }
    public void CheckAndCraft()
    {
        if (Inv.Count != InvMax)
        {
            if (
                //                    Compressed Grass Block                     \\
                   UIGos[1].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[2].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[3].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[4].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[5].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[6].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[7].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[8].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[9].transform.GetChild(0).GetComponent<Text>().text == ""
                )

            {
                ClearCraftingBg();
                Inv.Add("Compressed Grass Block");

            }
            if (
                   //                    Compressed Grass Block                     \\
                   UIGos[1].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[2].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[3].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[4].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[5].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[6].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[7].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[8].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[9].transform.GetChild(0).GetComponent<Text>().text == ""
                )

            {
                ClearCraftingBg();
                Inv.Add("Compressed Grass Block");

            }
            if (
                   //                    Compressed Grass Block                     \\
                   UIGos[1].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[2].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[3].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[4].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[5].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[6].transform.GetChild(0).GetComponent<Text>().text == ""
                && UIGos[7].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[8].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                && UIGos[9].transform.GetChild(0).GetComponent<Text>().text == "Grass"
                )

            {
                ClearCraftingBg();
                Inv.Add("Compressed Grass Block");

            }
        }
        else
        {
            Debug.LogError("Player tryed to craft with a full screen!");
        }
    }
}
