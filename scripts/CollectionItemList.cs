using Godot;
using System;

public partial class CollectionItemList : ItemList {
    public override void _Ready() {
        LoadItems(0); // default set of items
    }

    public void LoadItems(int collectionId) {
        Clear();
        switch (collectionId) {
            case CollectionSelector.Motion:
                // add motion related items
                break;
        }
    }
}
