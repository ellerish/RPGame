# RPG Characters
C# console application creating RPG characters.

## Table of Contents
- [Install](#install)
- [Usage](#usage)
- [Maintainers](#maintainers)

## Features
- Generates characters and demonstrate the level up/stats increase by giving them experience points. 
- Generates different kinds of weapons and armors. 
- Demonstration of weapons, different scaling depends on type and level
- Demonstration of armors, different scalling depends on type, level and slots(Head, Body, Legs)
- Demonstration of characters equipping diffrent kinds of armor and weapons. 
- Demonstration of characters amount of damage to deal when having a weapon. 

### Hero/:
- Abstract class Hero, defines base class and method of a hero.
- Mage, Ranger, Warrior class are subclasses from parent(Hero)
- Stats class, properties for stats(Attributes) with getters, setters health, strength, dexterity, intelligence

### Items/:

#### Armor/:
- Abstract class Armor, defines base class and methods for armors
- ClothArmor, LeatherArmor, Platearmor are sublcasses of parent(Armor), overriding methods
- ArmorType, enums to define type of armor
- Slots, enums for slots(body, head, legs) assiged with scale value

#### Weapon/:
- Abstract class Weapon, defines base class and methods for weapons.
- MagicWeapon, MeleeWeapon, RangedWeapon are sublacces of parent(Weapon), overriding methods
- WeaponType, enums to define type of weapon.

### Services/:
- Itemservice: declarations of methods for heroservice
- HeroService: implementing methods for a hero to equip weapons or armor, and attack.

## Install
- Clone 
- Open in Visual Studio
- Build the application

## Usage
- Run the application from Visual Studio.

## Maintainers
- Elise Rishaug
