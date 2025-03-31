using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "itemDatabase", menuName = "Inventory/Database")]
public class ItemDatabaseSO : ScriptableObject
{
    public List<ItemSO> items = new List<ItemSO>();

    private Dictionary<int, ItemSO> itemsByld;
    private Dictionary<string, ItemSO> itemsByName;

    public void Initialize()
    {
        itemsByld = new Dictionary<int, ItemSO>();
        itemsByName = new Dictionary<string, ItemSO>();

        foreach (var item in items)
        {
            itemsByld[item.id] = item;
            itemsByName[item.itemName] = item;
        }
    }
    public ItemSO GetItemByld(int id)
    {
        if (itemsByld == null)
        {
            Initialize();
        }
        if (itemsByld.TryGetValue(id, out ItemSO item))
            return item;

        return null;
    }
    public ItemSO GetItemByName(string name)
    {
        if (itemsByName == null)
        {
            Initialize();
        }
        if (itemsByName.TryGetValue(name, out ItemSO item))
            return item;
        return null;
    }
    public List<ItemSO> GetItemByType(ItemType type)
    {
        return items.FindAll(item => item.itemType == type);
    }
}
