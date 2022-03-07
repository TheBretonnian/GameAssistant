using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssistant
{
    public static class Dungeon
    {
        public static Dictionary<int,string> Table2 = new Dictionary<int, string>
        {
            {1, "value1" },
            {2, "value2" },
            {3, "value3" },
            {4, "value4" },
            {5, "value5" },
            {6, "value6" }
        };

        public static Dictionary<int, string> DungeonTopology = new Dictionary<int, string>
        {
            { 11, " Corridor "},
            { 12, " Corridor "},
            { 13, " Corridor "},
            { 14, " Corridor "},
            { 15, " Room "},
            { 16, " Room "},
            { 21, " Room "},
            { 22, " Room "},
            { 23, " Room "},
            { 24, " Room "},
            { 25, " Room "},
            { 26, " Corridor "},
            { 31, " Room "},
            { 32, " Corridor "},
            { 33, " Corridor "},
            { 34, " Room "},
            { 35, " Room "},
            { 36, " Room "},
            { 41, " Room "},
            { 42, " Corridor "},
            { 43, " Room "},
            { 44, " Room "},
            { 45, " Corridor "},
            { 46, " Room "},
            { 51, " Corridor "},
            { 52, " Room "},
            { 53, " Corridor "},
            { 54, " Room "},
            { 55, " Corridor "},
            { 56, " Room "},
            { 61, " Room "},
            { 62, " Corridor "},
            { 63, " Corridor "},
            { 64, " Room "},
            { 65, " Corridor "},
            { 66, " Room "}
        };

        public static Dictionary<int, string> RoomContent = new Dictionary<int, string>
        {
            {2  ,"Treasure found: roll D6 on the table.Treasure"},
            {3  ,"Treasure protected by a trap. Roll D6 on the table.Traps"},
            {4  ,"Roll D6 on the table.SpecialEvents"},
            {5  ,"Empty, but roll d6 on the table.SpecialFeature"},
            {6  ,"Roll D6 on the table.Vermin "},
            {7  ,"Roll D6 on the table.Minions"},
            {8  ,"Roll d6 on the table.Minions"},
            {9  ,"Empty."},
            {10 ,"Roll D6 on table.WeirdMonsters"},
            {11 ,"Roll D6 on the table.Boss . Then roll d6. Add +1 for every boss or weird monster that you have encountered so far in the game. if your total is 6+, or if the dungeon layout is complete, this is the final boss."},
            {12 ,"The room is a small dragon’s lair. The small dragon counts as a boss and may be the final boss. Roll 6d1 on table.Boss."}
        };

        public static Dictionary<int, string> CorridorContent = new Dictionary<int, string>
        {
            {2  ,"Treasure found: roll D6 on the table.Treasure"},
            {3  ,"Treasure protected by a trap. Roll D6 on the table.Traps"},
            {4  ,"Empty."},
            {5  ,"Empty, but roll d6 on the table.SpecialFeature"},
            {6  ,"Roll D6 on the table.Vermin "},
            {7  ,"Roll D6 on the table.Minions"},
            {8  ,"Empty."},
            {9  ,"Empty."},
            {10 ,"Empty."},
            {11 ,"Roll D6 on the table.Boss. Then roll dice: d6. Add +1 for every boss or weird monster that you have encountered so far in the game. if your total is 6+, or if the dungeon layout is complete, this is the final boss."},
            {12 ,"Empty."}
        };

        public static Dictionary<int, string> Treasure = new Dictionary<int, string>
        {
            {1, "D6 gold pieces" },
            {2, "2d6 gold pieces" },
            {3, "A scroll with a random spell. Roll D6 on table.Spells" },
            {4, "One gem worth 2d6 x 5 gp" },
            {5, "One item of jewelry worth 3d6 x 10 gp" },
            {6, "One random magic item. Roll D6 on table.MagicTreasure" }
        };

        public static Dictionary<int, string> MagicTreasure = new Dictionary<int, string>
        {
            {1  ,"Wand of Sleep: allows to cast Sleep 3 times before it is depleted. Only wizards and elves may use it. Add the user’s level to the spell roll.  "},
            {2  ,"Ring of Teleportation: allows user to automatically pass a Defense roll by moving that character out of the room. That character may not take part in the current combat, but rejoins the party as soon as the combat is over. After one use, the ring loses its powers and becomes a simple golden ring worth 1d6+1 gold pieces.  "},
            {3  ,"Fools Gold. These magical (but fake) gold pieces will let the user automatically bribe the next monster that asks for a bribe. No matter what the monster asks, the gold will appear enough to satisfy his greed. This is a one-use magic item.  "},
            {4  ,"Magic Weapon. Gives +1 to its user’s Attack rolls. This is a permanent magic item. Roll dice:d6 to determine its type: 1 crushing light hand weapon, 2 slashing light hand weapon, 3 crushing hand weapon, 4-5 slashing hand weapon, 6 bow.  "},
            {5  ,"Potion of Healing: Can be swallowed at any moment, healing all lost life to a single character. This does not require an action. This is a one-use magic item, usable by all classes except barbarians. 6 Fireball Staff: allows to cast Fireball spell twice."}
        };

        public static Dictionary<int, string> Traps = new Dictionary<int, string>
        {
            {1, "A dart (L2) attacks a random character" },
            {2, "Posion gas (L3) attacks all characters" },
            {3, "A trapdoor (L4) opens under the feet of the character leading the marching order" },
            {4, "Bear trap (L4) hitting the character leading the marching order" },
            {5, "Spears coming out from a wall (L5) attack 2 random characters" },
            {6, "A giant stone block (L5) falls on the last character in the marching order" }
        };

        public static Dictionary<int, string> SpecialFeature = new Dictionary<int, string> 
        {
            {1," Fountain: All wounded characters recover 1 Life the first time they encounter a fountain in an adventure. Further fountains have no effect.  "}, 
            {2," Blessed Temple: A character of your choice gains a +1 on Attack against undead monsters or demons. As soon as the character kills at least one undead or demon, the bonus is gone.  "}, 
            {3," Armory: All characters can change their weapons if they want, within the limits of the weapons allowed to their character type. For example, a Warrior who was using a sword and shield may discard his shield and take a two-handed weapon, or exchange his sword for a mace.  "}, 
            {4," Cursed Altar: As you enter the room, an eerie glow emanates from a sinister altar. A random character is cursed and has now -1 on his Defense rolls. To break the curse, the character must either slay a boss monster alone, or enter a Blessed Temple (see 2, above), or have a Blessing spell cast on himself by a cleric.  "}, 
            {5," Statue: you may leave the statue alone or touch it. If you touch it, roll dice (d_6): On a 1–3, the statue awakens and attacks your party (level 4 boss with 6 life points, immune to all spells; if you defeat it, you find 3d6 x 10 gold pieces inside). On a 4-6, the statue breaks, and you find 3d6 x 10 gold pieces inside.  "}, 
            {6," Puzzle Room: the room contains a puzzle box. Its level is d6. You may leave it alone or try to solve it. For every failed attempt, the character trying to solve it loses 1 life. Wizards and rogues add their level to their puzzle-solving roll. If the puzzle is solved, the box opens: make a Treasure roll to determine its contents."} 
        };

        public static Dictionary<int, string> SpecialEvents = new Dictionary<int, string>
        {
            {1 ,"A ghost passes through the party. All characters must save versus level 4 fear or lose 1 life. A cleric adds his level to this roll.  "},
            {2 ,"Wandering monsters attack the party. Roll d6 on table.WanderingMonster."},
            {3 ,"A lady in white appears and asks you to complete a quest. If you accept, roll D6 on the table.Quest. If you refuse, she disappears. Ignore any further appearances of the Lady in White in the game. "},
            {4 ,"Trap! Roll d6 on the table.Traps.  "},
            {5 ," You meet a wandering healer. He will heal your party at the cost of 10 gold pieces per life healed. You may heal as many life points as you can afford. You can meet the healer only once per game. If you meet him again, reroll this result.  "},
            {6 ," You meet a wandering alchemist. He will sell you up to one potion of healing per party member (50 gp each) or a single dose of blade poison (30 gp). The potion of healing will heal all lost life points to a single character, and can be swallowed at any moment during the game as a free action. The blade poison lets you envenom a single arrow or slashing weapon (not a crushing weapon). That weapon will have a +1 on Attack against the first enemy you fight. Poison will not work on undead monsters, demons, blobs, automatons, or living statues. You can meet a wandering alchemist only once per game. If you meet him again, treat this result as a trap."}
        };

        public static Dictionary<int, string> WanderingMonster = new Dictionary<int, string>
        {
            {1 , "Roll d6 on the  table.Vermin"},
            {2 , "Roll d6 on the  table.Vermin"},
            {3 , "Roll d6 on the  table.Minions"},
            {4 , "Roll d6 on the  table.Minions"},
            {5 , "Roll d6 on the  table.WeirdMonsters"},
            {6 , "Roll d6 on the  table.Boss. Reroll d6 any small dragons. A boss monster met as a wandering monster has no chance of being the final boss."} 
        };

        public static Dictionary<int, string> Vermin = new Dictionary<int, string>
        {
            { 1, " 3d6 rats. Level 1, no treasure. Any character wounded has a  in 6 chance of losing  additionallife due to an infected wound. Reactions (d_6): 1–3 flee, 4–6 fight "},
            { 2, " 3d6 vampire bats. Level 1, no treasure. Spells are cast at -1 due to their distracting shrieking.Reactions (d_6):  1–3 flee, 4–6 fight "},
            { 3, " 2d6 goblin swarmlings. Level 3, treasure -1, morale -1. Reactions (d_6): 1 flee, 2-3 flee ifoutnumbered, 4 bribe (5 gp x goblin), 5–6 fight. "},
            { 4, " D6 giant centipedes. Level 3, no treasure. Any character wounded by a giant centipede mustsave versus level 2 poison or lose 1 additional life. Reactions (d_6): 1 flee, 2-3 flee if outnumbered,4-6 fight. "},
            { 5, " D6 vampire frogs. Level 4, treasure -1. Reactions (d_6): 1 flee, 2-4 fight, 5-6 fight to the death "},
            { 6, " 2d6 skeletal rats. Level 3 undead, no treasure. Crushing weapon attacks are at +1 againstskeletal rats, but they cannot be attacked by bows and slings. Reactions (d_6): 1-2 flee, 3-6 fight "}
        };

        public static Dictionary<int, string> Minions = new Dictionary<int, string>
        {
            { 1, " D6+2 skeletons or d6 zombies (Roll die: D6 -> 1-3 skeletons, 4-6 zombies). Level 3 undead. No treasure. Crushing weapons attack Skeletons at +1. Arrows are at -1 against both skeletons and zombies. Skeletons and zombies never test morale.  Reactions: always fight to the death. "},
            { 2, " d6+3 goblins. Level 3, treasure -1. Goblins have a 1 in 6 chance of gaining surprise, thus acting before the party. Reactions (d_6): 1 flee if outnumbered, -3 bribe (5 gp per goblin), 4–6 fight. "},
            { 3, " d6 hobgoblins. Level 4, Treasure +1. Reactions (d_6): 1 flee if outnumbered, 2– bribe (10 gp per hobgoblin), 4–5 fight, 6 fight to the death. "},
            { 4, " D6+1 orcs. Level . Orcs are afraid of magic and must test morale each time one or more is killed by a spell. If a spell caused their number to drop below 50%, they will test morale at -1. They never have magic items in their treasure: treat any rolled magic as d6 x d6 gold pieces instead. Reactions(d6): 1-2 bribe (10 gp per orc), 3–5 fight, 6 fight to the death. "},
            { 5, " d3 trolls. Level , Treasure: normal.  Trolls regenerate, unless killed by a spell, or unless a character uses one attack to chop an already killed troll to bits. If this does not happen, roll a die for every killed troll on its next turn. On a 5 or 6, the troll will come back to life and continue to fight. Reactions (d_6): 1–2 fight, 3–6 fight to the death. If a dwarf is present in the party, trolls will automatically fight to the death."},
            { 6, " 2d Fungi Folk. Level 3, Treasure: normal.  Any character taking damage from the fungi folk must save versus level 3 poison or lose 1 life. Halflings add their level on this save. Reactions (d): 1-2 ask for bribe (d6 gp per fungus), 3–6 fight. "}
        };

        public static Dictionary<int, string> Boss = new Dictionary<int, string>
        {
            { 1, " Mummy. Level 5 undead, 4 life points, 2 attacks, treasure +2. Any character killed by a mummybecomes another mummy and must be fought by the party. Mummies are attacked at +2 by theFireball spell. Mummies never test morale. Reactions: always fight. "},
            { 2, " Orc Brute. Level 5, 5 life points,  attacks, treasure +1 but may not have any magic items, treat as d6x d6 gold pieces instead. Reactions (d_6): 1 bribe (50 gp), –5 fight, 6 fight to the death. "},
            { 3, " Ogre. Level 5, 6 life points, normal treasure. Each hit from an ogre inflicts 2 life points of damage.Reactions (d_6): 1 bribe (0 gp), 2– fight, 4–6 fight to the death. "},
            { 4, " Medusa. Level ,  life points, treasure +1. All characters at the beginning of the battle must saveversus a level  gaze attack or be turned to stone. Petrified characters are out of the game until aBlessing spell is cast on them. Rogues add half their level to this save. Reactions (d_6): 1 bribe (6d6 gp),2 quest, 3–5 fight, 6 fight to the death. "},
            { 5, " Chaos Lord. Level 6, 4 life, 3 attacks, 2 treasure rolls at +1. Before the fight begins, roll dice:d6 to determine if the Chaos Lord has any special powers: 1–3 no powers, 4 evil eye (characters must roll 4+ or be at -1 on all defense rolls until the chaos lord is slain),  energy drain (any character taking awound from the chaos lord must roll 4+ or lose 1 level), 6 hellfire blast (before combat, all characters must roll 6+ or lose 2 life points; Clerics add ½ level to this roll). When you kill a chaos lord, roll a die:d6; on a  or 6 a character of your choice finds a Clue (see p. ) Reactions (d_6): 1 flee if outnumbered, 2fight, 3–6 fight to the death. "},
            { 6, " Small Dragon. Level , 5 life points, 2 attacks, 3 treasure rolls at +1. On each turn of the dragon, roll die:d6, on a 1 or 2 the dragon breathes fire, inflicting 1 life  to all characters who fail to save versus level dragon breath (each character adds ½ level, rounded down). If the dragon does not breathe, he bites 2 random characters. Small dragons are never met as random monsters. Reactions (d_6): 1 Sleeping(all characters can attack at +2 on their first attack), 2–3 bribe (all the gold of the party, with a minimum of 100 gold or one magic item), 4–5 fight, 6 Quest."}
        };

        public static Dictionary<int, string> WeirdMonsters = new Dictionary<int, string>
        {
            { 1, " Minotaur. Level 5, 4 life points, 2 attacks, normal treasure. Due to the power of his bull-rushcharge, the first Defense roll against a minotaur is at -.  Minotaurs hate halflings. Reactions (d_6):1-2 bribe (60 gp), 3–4 fight, 6 fight to the death. "},
            { 2, " Iron Eater. Level 3, 4 life, 3 attacks, no treasure. Defense rolls against the iron eater do not enjoybonus from heavy armor (shield and light armor count). If the monster hits, the character takes nodamage but loses his armor, shield, main weapon, or 3d6 gp, in this order. Reactions (d_6): 1 flee,2-3 bribe (d6 gp to distract the creature; you may not fool the creature with fools gold), 4-6 fight. "},
            { 3, " Chimera. Level 5, 6 life points,  attacks, normal treasure. On every of the chimera’s turns, roll d6.On a 1 or 2 the chimera breathes fire instead of performing its multiple attacks. All charactersmust save versus level 4 fire or lose 1 life. Reactions (d_6): 1 bribe (50 gp), 2–6 fight. "},
            { 4, " Catoblepas. Level ,  life points, treasure +1. All characters at the beginning of the battle mustsave versus a level  gaze attack or lose 1 life. Reactions (d_6): 1 flee, 2-6 fight "},
            { 5, " Giant Spider. Level , 3 life, 2 attacks, 2 treasure rolls. Characters taking a wound must saveversus level 3 poison or lose an additional life. Due to the spider’s webbing, the party may notwithdraw from this fight unless they cast a Fireball spell to burn the webs. Reactions: always fight. "},
            { 6, " Invisible Gremlins. A band of gremlins steal d+3 objects from the party. You must surrender objects from any of your characters in this order of preference: magic items, scrolls, potions,weapons, gems, coins (in bundles of 10 gp each). If the gremlins steal ALL of your equipment, theywill leave a thank you message that counts as a clue. The gremlins have no combat stats becauseit is impossible to fight them. Encountering them gives no XP roll. No treasure. "}
        };

        public static Dictionary<int, string> Quest = new Dictionary<int, string>
        {
            { 1, " Bring me his head! The creature asks the party to kill a boss monster. Roll d6 on the table.Boss to determine who. The next time the party meets a boss in a room, instead of rolling it up, you may usethe boss from the quest. Killing the boss and bringing its head to the creature’s room completes thequest. "},
            { 2, " Bring me Gold! To complete the quest, the party must bring d6 x 50 worth of treasure to this room. Ifthey already have that amount available, the amount required to complete the quest is doubled. "},
            { 3, " I want him alive! As 1, above, but  the party must subdue the boss, tie him up with a rope, and takehim to the creature’s room to complete the quest. To subdue a monster, you must either use the Sleep spell or fight with -1 on all Attack rolls (striking with the flat of the blade or trying to knock out the bossinstead of killing him). "},
            { 4, " Bring me that! Roll d6 on the table.MagicTreasure to determine what the object is. Every time the party kills a boss, there is a 1 in 6 chance that he will have that object in addition to his treasure, if any. To complete the quest, the party must bring the object in the room where the quest started. "},
            { 5, " Let peace be your way! To complete the quest, the party must complete at least three encounters inthe adventure in a non violent way. This includes reactions such as bribing, getting help frommonsters, performing another quest (not this one!), or defeating a monster with the Sleep spell andthen tying him up with a rope. "},
            { 6, " Slay all the monsters! To complete the quest, all the dungeon rooms must be laid out and all the occupants slain, with the exception  of the creature who sent the party on this quest. As soon as the conditions are met, the party can claim their reward. "},
        };

        public static Dictionary<int, string> Spells = new Dictionary<int, string>
        {
            { 1, " Blessing "},
            { 2, " Fireball "},
            { 3, " Lightning bolt "},
            { 4, " Sleep "},
            { 5, " Escape "},
            { 6, " Protect "}
        };

        public static Dictionary<string, Dictionary<int, string>> Tables = new Dictionary<string, Dictionary<int, string>>
        {
            {
                "DungeonTopology", DungeonTopology
            },
            {
               "RoomContent", RoomContent
            },
            {
                "CorridorContent", CorridorContent
            },
            {
                "Treasure", Treasure
            },
            {
                "MagicTreasure", MagicTreasure
            },
            {
                "Traps", Traps
            },
            {
                "SpecialFeature", SpecialFeature
            },
            {
                "SpecialEvents", SpecialEvents
            },
            {
               "WanderingMonster", WanderingMonster
            },
            {
                "Vermin",Vermin
            },
            {
                "Minions", Minions
            },
            {
                "Boss", Boss
            },
            {
                "WeirdMonsters", WeirdMonsters
            },
            {
                "Quest", Quest
            },
            {
                "Spells",Spells
            }
        };
    }
}
