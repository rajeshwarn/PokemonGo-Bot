// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/ItemSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/ItemSettings.proto</summary>
  public static partial class ItemSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/ItemSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtU2V0dGluZ3MucHJv",
            "dG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyGiNQT0dPUHJvdG9zL0Vu",
            "dW1zL0l0ZW1DYXRlZ29yeS5wcm90bxomUE9HT1Byb3Rvcy9JbnZlbnRvcnkv",
            "SXRlbS9JdGVtSWQucHJvdG8aKFBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0v",
            "SXRlbVR5cGUucHJvdG8aNFBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL0l0",
            "ZW0vRm9vZEF0dHJpYnV0ZXMucHJvdG8aNlBPR09Qcm90b3MvU2V0dGluZ3Mv",
            "TWFzdGVyL0l0ZW0vUG90aW9uQXR0cmlidXRlcy5wcm90bxo2UE9HT1Byb3Rv",
            "cy9TZXR0aW5ncy9NYXN0ZXIvSXRlbS9SZXZpdmVBdHRyaWJ1dGVzLnByb3Rv",
            "GjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0JhdHRsZUF0dHJp",
            "YnV0ZXMucHJvdG8aN1BPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL0l0ZW0v",
            "SW5jZW5zZUF0dHJpYnV0ZXMucHJvdG8aOFBPR09Qcm90b3MvU2V0dGluZ3Mv",
            "TWFzdGVyL0l0ZW0vUG9rZWJhbGxBdHRyaWJ1dGVzLnByb3RvGjxQT0dPUHJv",
            "dG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0ZvcnRNb2RpZmllckF0dHJpYnV0",
            "ZXMucHJvdG8aPFBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL0l0ZW0vRWdn",
            "SW5jdWJhdG9yQXR0cmlidXRlcy5wcm90bxo/UE9HT1Byb3Rvcy9TZXR0aW5n",
            "cy9NYXN0ZXIvSXRlbS9FeHBlcmllbmNlQm9vc3RBdHRyaWJ1dGVzLnByb3Rv",
            "GkBQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0ludmVudG9yeVVw",
            "Z3JhZGVBdHRyaWJ1dGVzLnByb3RvIrUHCgxJdGVtU2V0dGluZ3MSMgoHaXRl",
            "bV9pZBgBIAEoDjIhLlBPR09Qcm90b3MuSW52ZW50b3J5Lkl0ZW0uSXRlbUlk",
            "EjYKCWl0ZW1fdHlwZRgCIAEoDjIjLlBPR09Qcm90b3MuSW52ZW50b3J5Lkl0",
            "ZW0uSXRlbVR5cGUSMAoIY2F0ZWdvcnkYAyABKA4yHi5QT0dPUHJvdG9zLkVu",
            "dW1zLkl0ZW1DYXRlZ29yeRIRCglkcm9wX2ZyZXEYBCABKAISGgoSZHJvcF90",
            "cmFpbmVyX2xldmVsGAUgASgFEkUKCHBva2ViYWxsGAYgASgLMjMuUE9HT1By",
            "b3Rvcy5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5Qb2tlYmFsbEF0dHJpYnV0ZXMS",
            "QQoGcG90aW9uGAcgASgLMjEuUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIu",
            "SXRlbS5Qb3Rpb25BdHRyaWJ1dGVzEkEKBnJldml2ZRgIIAEoCzIxLlBPR09Q",
            "cm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0uUmV2aXZlQXR0cmlidXRlcxJB",
            "CgZiYXR0bGUYCSABKAsyMS5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5J",
            "dGVtLkJhdHRsZUF0dHJpYnV0ZXMSPQoEZm9vZBgKIAEoCzIvLlBPR09Qcm90",
            "b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0uRm9vZEF0dHJpYnV0ZXMSVgoRaW52",
            "ZW50b3J5X3VwZ3JhZGUYCyABKAsyOy5QT0dPUHJvdG9zLlNldHRpbmdzLk1h",
            "c3Rlci5JdGVtLkludmVudG9yeVVwZ3JhZGVBdHRyaWJ1dGVzEkwKCHhwX2Jv",
            "b3N0GAwgASgLMjouUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5F",
            "eHBlcmllbmNlQm9vc3RBdHRyaWJ1dGVzEkMKB2luY2Vuc2UYDSABKAsyMi5Q",
            "T0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5JdGVtLkluY2Vuc2VBdHRyaWJ1",
            "dGVzEk4KDWVnZ19pbmN1YmF0b3IYDiABKAsyNy5QT0dPUHJvdG9zLlNldHRp",
            "bmdzLk1hc3Rlci5JdGVtLkVnZ0luY3ViYXRvckF0dHJpYnV0ZXMSTgoNZm9y",
            "dF9tb2RpZmllchgPIAEoCzI3LlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
            "Lkl0ZW0uRm9ydE1vZGlmaWVyQXR0cmlidXRlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.ItemCategoryReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemTypeReflection.Descriptor, global::POGOProtos.Settings.Master.Item.FoodAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.PotionAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.ReviveAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.BattleAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.IncenseAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.PokeballAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.FortModifierAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.EggIncubatorAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.ItemSettings), global::POGOProtos.Settings.Master.ItemSettings.Parser, new[]{ "ItemId", "ItemType", "Category", "DropFreq", "DropTrainerLevel", "Pokeball", "Potion", "Revive", "Battle", "Food", "InventoryUpgrade", "XpBoost", "Incense", "EggIncubator", "FortModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ItemSettings : pb::IMessage<ItemSettings> {
    private static readonly pb::MessageParser<ItemSettings> _parser = new pb::MessageParser<ItemSettings>(() => new ItemSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.ItemSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemSettings(ItemSettings other) : this() {
      itemId_ = other.itemId_;
      itemType_ = other.itemType_;
      category_ = other.category_;
      dropFreq_ = other.dropFreq_;
      dropTrainerLevel_ = other.dropTrainerLevel_;
      Pokeball = other.pokeball_ != null ? other.Pokeball.Clone() : null;
      Potion = other.potion_ != null ? other.Potion.Clone() : null;
      Revive = other.revive_ != null ? other.Revive.Clone() : null;
      Battle = other.battle_ != null ? other.Battle.Clone() : null;
      Food = other.food_ != null ? other.Food.Clone() : null;
      InventoryUpgrade = other.inventoryUpgrade_ != null ? other.InventoryUpgrade.Clone() : null;
      XpBoost = other.xpBoost_ != null ? other.XpBoost.Clone() : null;
      Incense = other.incense_ != null ? other.Incense.Clone() : null;
      EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
      FortModifier = other.fortModifier_ != null ? other.FortModifier.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemSettings Clone() {
      return new ItemSettings(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "item_type" field.</summary>
    public const int ItemTypeFieldNumber = 2;
    private global::POGOProtos.Inventory.Item.ItemType itemType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemType ItemType {
      get { return itemType_; }
      set {
        itemType_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::POGOProtos.Enums.ItemCategory category_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.ItemCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "drop_freq" field.</summary>
    public const int DropFreqFieldNumber = 4;
    private float dropFreq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DropFreq {
      get { return dropFreq_; }
      set {
        dropFreq_ = value;
      }
    }

    /// <summary>Field number for the "drop_trainer_level" field.</summary>
    public const int DropTrainerLevelFieldNumber = 5;
    private int dropTrainerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DropTrainerLevel {
      get { return dropTrainerLevel_; }
      set {
        dropTrainerLevel_ = value;
      }
    }

    /// <summary>Field number for the "pokeball" field.</summary>
    public const int PokeballFieldNumber = 6;
    private global::POGOProtos.Settings.Master.Item.PokeballAttributes pokeball_;
    /// <summary>
    /// One of the below attributes will be set in the response, the others will be null.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.PokeballAttributes Pokeball {
      get { return pokeball_; }
      set {
        pokeball_ = value;
      }
    }

    /// <summary>Field number for the "potion" field.</summary>
    public const int PotionFieldNumber = 7;
    private global::POGOProtos.Settings.Master.Item.PotionAttributes potion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.PotionAttributes Potion {
      get { return potion_; }
      set {
        potion_ = value;
      }
    }

    /// <summary>Field number for the "revive" field.</summary>
    public const int ReviveFieldNumber = 8;
    private global::POGOProtos.Settings.Master.Item.ReviveAttributes revive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.ReviveAttributes Revive {
      get { return revive_; }
      set {
        revive_ = value;
      }
    }

    /// <summary>Field number for the "battle" field.</summary>
    public const int BattleFieldNumber = 9;
    private global::POGOProtos.Settings.Master.Item.BattleAttributes battle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.BattleAttributes Battle {
      get { return battle_; }
      set {
        battle_ = value;
      }
    }

    /// <summary>Field number for the "food" field.</summary>
    public const int FoodFieldNumber = 10;
    private global::POGOProtos.Settings.Master.Item.FoodAttributes food_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.FoodAttributes Food {
      get { return food_; }
      set {
        food_ = value;
      }
    }

    /// <summary>Field number for the "inventory_upgrade" field.</summary>
    public const int InventoryUpgradeFieldNumber = 11;
    private global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes inventoryUpgrade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes InventoryUpgrade {
      get { return inventoryUpgrade_; }
      set {
        inventoryUpgrade_ = value;
      }
    }

    /// <summary>Field number for the "xp_boost" field.</summary>
    public const int XpBoostFieldNumber = 12;
    private global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes xpBoost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes XpBoost {
      get { return xpBoost_; }
      set {
        xpBoost_ = value;
      }
    }

    /// <summary>Field number for the "incense" field.</summary>
    public const int IncenseFieldNumber = 13;
    private global::POGOProtos.Settings.Master.Item.IncenseAttributes incense_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.IncenseAttributes Incense {
      get { return incense_; }
      set {
        incense_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubator" field.</summary>
    public const int EggIncubatorFieldNumber = 14;
    private global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes eggIncubator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes EggIncubator {
      get { return eggIncubator_; }
      set {
        eggIncubator_ = value;
      }
    }

    /// <summary>Field number for the "fort_modifier" field.</summary>
    public const int FortModifierFieldNumber = 15;
    private global::POGOProtos.Settings.Master.Item.FortModifierAttributes fortModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Item.FortModifierAttributes FortModifier {
      get { return fortModifier_; }
      set {
        fortModifier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ItemType != other.ItemType) return false;
      if (Category != other.Category) return false;
      if (DropFreq != other.DropFreq) return false;
      if (DropTrainerLevel != other.DropTrainerLevel) return false;
      if (!object.Equals(Pokeball, other.Pokeball)) return false;
      if (!object.Equals(Potion, other.Potion)) return false;
      if (!object.Equals(Revive, other.Revive)) return false;
      if (!object.Equals(Battle, other.Battle)) return false;
      if (!object.Equals(Food, other.Food)) return false;
      if (!object.Equals(InventoryUpgrade, other.InventoryUpgrade)) return false;
      if (!object.Equals(XpBoost, other.XpBoost)) return false;
      if (!object.Equals(Incense, other.Incense)) return false;
      if (!object.Equals(EggIncubator, other.EggIncubator)) return false;
      if (!object.Equals(FortModifier, other.FortModifier)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (ItemType != 0) hash ^= ItemType.GetHashCode();
      if (Category != 0) hash ^= Category.GetHashCode();
      if (DropFreq != 0F) hash ^= DropFreq.GetHashCode();
      if (DropTrainerLevel != 0) hash ^= DropTrainerLevel.GetHashCode();
      if (pokeball_ != null) hash ^= Pokeball.GetHashCode();
      if (potion_ != null) hash ^= Potion.GetHashCode();
      if (revive_ != null) hash ^= Revive.GetHashCode();
      if (battle_ != null) hash ^= Battle.GetHashCode();
      if (food_ != null) hash ^= Food.GetHashCode();
      if (inventoryUpgrade_ != null) hash ^= InventoryUpgrade.GetHashCode();
      if (xpBoost_ != null) hash ^= XpBoost.GetHashCode();
      if (incense_ != null) hash ^= Incense.GetHashCode();
      if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
      if (fortModifier_ != null) hash ^= FortModifier.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (ItemType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ItemType);
      }
      if (Category != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (DropFreq != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(DropFreq);
      }
      if (DropTrainerLevel != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DropTrainerLevel);
      }
      if (pokeball_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Pokeball);
      }
      if (potion_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Potion);
      }
      if (revive_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Revive);
      }
      if (battle_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Battle);
      }
      if (food_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Food);
      }
      if (inventoryUpgrade_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(InventoryUpgrade);
      }
      if (xpBoost_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(XpBoost);
      }
      if (incense_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Incense);
      }
      if (eggIncubator_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(EggIncubator);
      }
      if (fortModifier_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FortModifier);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (ItemType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemType);
      }
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (DropFreq != 0F) {
        size += 1 + 4;
      }
      if (DropTrainerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DropTrainerLevel);
      }
      if (pokeball_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokeball);
      }
      if (potion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Potion);
      }
      if (revive_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Revive);
      }
      if (battle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Battle);
      }
      if (food_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Food);
      }
      if (inventoryUpgrade_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrade);
      }
      if (xpBoost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(XpBoost);
      }
      if (incense_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Incense);
      }
      if (eggIncubator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
      }
      if (fortModifier_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortModifier);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemSettings other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.ItemType != 0) {
        ItemType = other.ItemType;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.DropFreq != 0F) {
        DropFreq = other.DropFreq;
      }
      if (other.DropTrainerLevel != 0) {
        DropTrainerLevel = other.DropTrainerLevel;
      }
      if (other.pokeball_ != null) {
        if (pokeball_ == null) {
          pokeball_ = new global::POGOProtos.Settings.Master.Item.PokeballAttributes();
        }
        Pokeball.MergeFrom(other.Pokeball);
      }
      if (other.potion_ != null) {
        if (potion_ == null) {
          potion_ = new global::POGOProtos.Settings.Master.Item.PotionAttributes();
        }
        Potion.MergeFrom(other.Potion);
      }
      if (other.revive_ != null) {
        if (revive_ == null) {
          revive_ = new global::POGOProtos.Settings.Master.Item.ReviveAttributes();
        }
        Revive.MergeFrom(other.Revive);
      }
      if (other.battle_ != null) {
        if (battle_ == null) {
          battle_ = new global::POGOProtos.Settings.Master.Item.BattleAttributes();
        }
        Battle.MergeFrom(other.Battle);
      }
      if (other.food_ != null) {
        if (food_ == null) {
          food_ = new global::POGOProtos.Settings.Master.Item.FoodAttributes();
        }
        Food.MergeFrom(other.Food);
      }
      if (other.inventoryUpgrade_ != null) {
        if (inventoryUpgrade_ == null) {
          inventoryUpgrade_ = new global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes();
        }
        InventoryUpgrade.MergeFrom(other.InventoryUpgrade);
      }
      if (other.xpBoost_ != null) {
        if (xpBoost_ == null) {
          xpBoost_ = new global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes();
        }
        XpBoost.MergeFrom(other.XpBoost);
      }
      if (other.incense_ != null) {
        if (incense_ == null) {
          incense_ = new global::POGOProtos.Settings.Master.Item.IncenseAttributes();
        }
        Incense.MergeFrom(other.Incense);
      }
      if (other.eggIncubator_ != null) {
        if (eggIncubator_ == null) {
          eggIncubator_ = new global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes();
        }
        EggIncubator.MergeFrom(other.EggIncubator);
      }
      if (other.fortModifier_ != null) {
        if (fortModifier_ == null) {
          fortModifier_ = new global::POGOProtos.Settings.Master.Item.FortModifierAttributes();
        }
        FortModifier.MergeFrom(other.FortModifier);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            itemType_ = (global::POGOProtos.Inventory.Item.ItemType) input.ReadEnum();
            break;
          }
          case 24: {
            category_ = (global::POGOProtos.Enums.ItemCategory) input.ReadEnum();
            break;
          }
          case 37: {
            DropFreq = input.ReadFloat();
            break;
          }
          case 40: {
            DropTrainerLevel = input.ReadInt32();
            break;
          }
          case 50: {
            if (pokeball_ == null) {
              pokeball_ = new global::POGOProtos.Settings.Master.Item.PokeballAttributes();
            }
            input.ReadMessage(pokeball_);
            break;
          }
          case 58: {
            if (potion_ == null) {
              potion_ = new global::POGOProtos.Settings.Master.Item.PotionAttributes();
            }
            input.ReadMessage(potion_);
            break;
          }
          case 66: {
            if (revive_ == null) {
              revive_ = new global::POGOProtos.Settings.Master.Item.ReviveAttributes();
            }
            input.ReadMessage(revive_);
            break;
          }
          case 74: {
            if (battle_ == null) {
              battle_ = new global::POGOProtos.Settings.Master.Item.BattleAttributes();
            }
            input.ReadMessage(battle_);
            break;
          }
          case 82: {
            if (food_ == null) {
              food_ = new global::POGOProtos.Settings.Master.Item.FoodAttributes();
            }
            input.ReadMessage(food_);
            break;
          }
          case 90: {
            if (inventoryUpgrade_ == null) {
              inventoryUpgrade_ = new global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes();
            }
            input.ReadMessage(inventoryUpgrade_);
            break;
          }
          case 98: {
            if (xpBoost_ == null) {
              xpBoost_ = new global::POGOProtos.Settings.Master.Item.ExperienceBoostAttributes();
            }
            input.ReadMessage(xpBoost_);
            break;
          }
          case 106: {
            if (incense_ == null) {
              incense_ = new global::POGOProtos.Settings.Master.Item.IncenseAttributes();
            }
            input.ReadMessage(incense_);
            break;
          }
          case 114: {
            if (eggIncubator_ == null) {
              eggIncubator_ = new global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes();
            }
            input.ReadMessage(eggIncubator_);
            break;
          }
          case 122: {
            if (fortModifier_ == null) {
              fortModifier_ = new global::POGOProtos.Settings.Master.Item.FortModifierAttributes();
            }
            input.ReadMessage(fortModifier_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
