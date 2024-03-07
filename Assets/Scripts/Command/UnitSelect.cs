using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitSelect : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private Unit curUnit; //current selected single unit
    
    [SerializeField]
    private Building curBuilding; //current selected single building
    public Building CurBuilding { get { return curBuilding; } }

    public Unit CurUnit { get { return curUnit; } }

    private Camera cam;
    private Faction faction;
    
    [SerializeField]
    private Building curBuilding; //current selected single building
    public Building CurBuilding { get { return curBuilding; } }

    public static UnitSelect instance;

    void Awake()
    {
        faction = GetComponent<Faction>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        layerMask = LayerMask.GetMask("Unit", "Building", "Resource", "Ground");

        instance = this;
 
    }

    // Update is called once per frame
    void Update()
    {
        //mouse down
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }
            
            ClearEverything();
        }

        // mouse up
        if (Input.GetMouseButtonUp(0))
        {
            TrySelect(Input.mousePosition);
        }

    }
    
    private void SelectUnit(RaycastHit hit)
    {
        curUnit = hit.collider.GetComponent<Unit>();

        curUnit.ToggleSelectionVisual(true);

        Debug.Log("Selected Unit");
<<<<<<< HEAD

=======
>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
        if (GameManager.instance.MyFaction.IsMyUnit(curUnit))
        {
            ShowUnit(curUnit);
        }
    }
    
    private void TrySelect(Vector2 screenPos)
    {
        Ray ray = cam.ScreenPointToRay(screenPos);
        RaycastHit hit;

        //if we left-click something
        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            switch (hit.collider.tag)
            {
                case "Unit":
                    SelectUnit(hit);
                    break;
                case "Building":
                    BuildingSelect(hit);
                    break;
            }
        }
    }
    
    private void ClearAllSelectionVisual()
    {
        if (curUnit != null)
            curUnit.ToggleSelectionVisual(false);
        
        if (curBuilding != null)
            curBuilding.ToggleSelectionVisual(false);
    }
    
    private void ClearEverything()
    {
        ClearAllSelectionVisual();
        curUnit = null;
<<<<<<< HEAD
        curBuilding = null;
        
        InfoManager.instance.ClearAllInfo();
    }
    
    private void ShowUnit(Unit u)
    {
        InfoManager.instance.ShowAllInfo(u);
    }
    
    private void ShowBuilding(Building b)
    {
        InfoManager.instance.ShowAllInfo(b);
    }
    
    private void BuildingSelect(RaycastHit hit)
    {
        curBuilding = hit.collider.GetComponent<Building>();
        curBuilding.ToggleSelectionVisual(true);

        if (GameManager.instance.MyFaction.IsMyBuilding(curBuilding))
        {
            //Debug.Log("my building");
            ShowBuilding(curBuilding);//Show building info
        }
=======
        
        InfoManager.instance.ClearAllInfo();
>>>>>>> 3dcc0656f223033f819d453d2cde4a81cae89834
    }
    
    private void ShowUnit(Unit u)
    {
        InfoManager.instance.ShowAllInfo(u);
    }
    

}
