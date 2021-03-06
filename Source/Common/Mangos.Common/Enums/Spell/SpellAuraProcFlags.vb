﻿Namespace Enums.Spell
    Public Enum SpellAuraProcFlags As Integer
        AURA_PROC_NULL = &H0
        AURA_PROC_ON_ANY_HOSTILE_ACTION = &H1
        AURA_PROC_ON_GAIN_EXPIERIENCE = &H2
        AURA_PROC_ON_MELEE_ATTACK = &H4
        AURA_PROC_ON_CRIT_HIT_VICTIM = &H8
        AURA_PROC_ON_CAST_SPELL = &H10
        AURA_PROC_ON_PHYSICAL_ATTACK_VICTIM = &H20
        AURA_PROC_ON_RANGED_ATTACK = &H40
        AURA_PROC_ON_RANGED_CRIT_ATTACK = &H80
        AURA_PROC_ON_PHYSICAL_ATTACK = &H100
        AURA_PROC_ON_MELEE_ATTACK_VICTIM = &H200
        AURA_PROC_ON_SPELL_HIT = &H400
        AURA_PROC_ON_RANGED_CRIT_ATTACK_VICTIM = &H800
        AURA_PROC_ON_CRIT_ATTACK = &H1000
        AURA_PROC_ON_RANGED_ATTACK_VICTIM = &H2000
        AURA_PROC_ON_PRE_DISPELL_AURA_VICTIM = &H4000
        AURA_PROC_ON_SPELL_LAND_VICTIM = &H8000
        AURA_PROC_ON_CAST_SPECIFIC_SPELL = &H10000
        AURA_PROC_ON_SPELL_HIT_VICTIM = &H20000
        AURA_PROC_ON_SPELL_CRIT_HIT_VICTIM = &H40000
        AURA_PROC_ON_TARGET_DIE = &H80000
        AURA_PROC_ON_ANY_DAMAGE_VICTIM = &H100000
        AURA_PROC_ON_TRAP_TRIGGER = &H200000                'triggers on trap activation
        AURA_PROC_ON_AUTO_SHOT_HIT = &H400000
        AURA_PROC_ON_ABSORB = &H800000
        AURA_PROC_ON_RESIST_VICTIM = &H1000000
        AURA_PROC_ON_DODGE_VICTIM = &H2000000
        AURA_PROC_ON_DIE = &H4000000
        AURA_PROC_REMOVEONUSE = &H8000000                   'remove AURA_PROChcharge only when it is used
        AURA_PROC_MISC = &H10000000                          'our custom flag to decide if AURA_PROC dmg or shield
        AURA_PROC_ON_BLOCK_VICTIM = &H20000000
        AURA_PROC_ON_SPELL_CRIT_HIT = &H40000000
        AURA_PROC_TARGET_SELF = &H80000000                   'our custom flag to decide if AURA_PROC target is self or victim
    End Enum
End NameSpace