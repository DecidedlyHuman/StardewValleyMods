# Mapping Extensions and Extra Properties (MEEP) Documentation
**Important**: Remember to read the section on [adding the correct keys to your manifest](../readme.md#Adding-MEEP-feature-keys-to-your-manifest) for the specific features you intend to use first.

### Spawning farm animals

To spawn farm animals with MEEP, you'll be editing one of MEEP's data models using CP's `EditData` property. If you're unsure of how to do this, you can find a link to the `EditData` section of CP's documentation near the top of the [main readme here](../readme.md).

Here's an example of an edit that will spawn two farm animals. One in the submarine, and one in Alex's house respectively:

```json
{
    "Changes": [
        {
            "Action": "EditData",
            "Target": "MEEP/FarmAnimals/SpawnData",
            "Entries": {
                "DH.TilePropertyTestMod.WhiteChickenSubmarine": {
                    "AnimalId": "White Chicken",
                    "Age": 0,
                    "LocationId": "Submarine",
                    "DisplayName": "Animal One Name",
                    "PetMessage": [
                        "UwU",
                        "I'm a baby chicken!"
                    ],
                    "HomeTileX": 13,
                    "HomeTileY": 5,
                    "Condition": ""
                },
                "DH.TilePropertyTestMod.WhiteChickenSubmarine": {
                    "AnimalId": "White Chicken",
                    "Age": 100,
                    "LocationId": "Submarine",
                    "DisplayName": "Animal One Name",
                    "PetMessage": [
                        "I'm a very old chicken, so you won't get an UwU from me!"
                    ],
                    "HomeTileX": 13,
                    "HomeTileY": 5,
                    "Condition": ""
                },
                "DH.TilePropertyTestMod.BrownCowJoshHouse": {
                    "Id": "DH.TilePropertyTestMod.BrownCowJoshHouse",
                    "AnimalId": "Brown Cow",
                    "LocationId": "JoshHouse",
                    "DisplayName": "Animal Two Name",
                    "PetMessage": [
                        "MUwU",
                        "What? I'm a cow, what else would I say?",
                        "Certainly not \"moo\"!"
                    ],
                    "HomeTileX": 9,
                    "HomeTileY": 20,
                    "Condition": ""
                }
            }
        }
    ]
}
```

In this case, we're adding two animals to `MEEP/FarmAnimals/SpawnData`. Each one is separated with a comma like many different things you would patch with CP.
Let's look at one in isolation.

```json
"DH.TilePropertyTestMod.WhiteChickenSubmarine": {
    "AnimalId": "White Chicken",
    "Age": 0,
    "LocationId": "Submarine",
    "DisplayName": "Animal One Name",
    "PetMessage": [
        "UwU",
        "I'm a baby chicken!"
    ],
    "HomeTileX": 13,
    "HomeTileY": 5,
    "Condition": ""
},
```

* `"DH.TilePropertyTestMod.WhiteChickenSubmarine"` is the spawn ID for the animal. This needs to be 100% unique per animal spawn, so it's recommended that you use the format `YourName.YourMod.AnimalType`. You can also do, for example, `YourName.YourMod.Animal1` if you plan on spawning multiple of the same animal. Just increment the number at the end!
* `"AnimalId": "White Chicken"`: This is the internal animal ID of the animal. In this case, we're spawning a vanilla white chicken, and its internal ID is `White Chicken`.
* `"Age": 0,`: This is the age of the animal!
* `"LocationId": "Submarine"`: This is the location name. For example, `SeedShop` is Pierre's shop, `JoshHouse` is Alex's house, and `ScienceHouse` is Robin's house.
* `"DisplayName": "Animal One Name"`: This is currently unused, but feel free to add it for the future when the name will be displayed alongside the pet message.
```json
"PetMessage": [
        "UwU",
        "I'm a baby chicken!"
]
```

This is a JSON list of messages to be displayed when the player interacts with a farm animal. In the above example, there are two entries. Just one entry will work, but you can have as many as you like.

```json
"HomeTileX": 13,
"HomeTileY": 5
```

These are the tiles the animal spawns on. They will wander around as usual, however.

```json
"Condition": ""
```

The condition field is a [Game State Query](https://stardewvalleywiki.com/Modding:Migrate_to_Stardew_Valley_1.6#Game_state_queries). The animal will only spawn if this condition is true, so you can have animals that only spawn in the sun, in the rain, or any other number of things supported by the game.