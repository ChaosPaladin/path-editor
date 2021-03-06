﻿#region Using

using System.Collections.Generic;
using System.IO;
using com.jds.PathEditor.classes.client.mothers;
using com.jds.PathEditor.classes.client.types;
using com.jds.PathEditor.classes.services;

#endregion

/**
 * Tested:
 * - Hellbound [WORK]
 * - Gracia 2 [WORK]
 * - Gracia Final [WORK]
 * - Gracia Plus [WORK]
 */

namespace com.jds.PathEditor.classes.client.definitions
{

    #region Definition

    public class SkillgrpInfo : Definition
    {
        /*
        Info from l2asm-disasm
        */
        public UINT skill_id;
        public UINT skill_level;
        public UINT oper_type;
        public UINT mp_consume;
        public INT cast_range;
        public UINT cast_style;
        public FLOAT hit_time;
        public INT is_magic;
        public UNICODE ani_char;
        public UNICODE desc;
        public UNICODE icon_name;
        public UINT extra_eff;
        public UINT is_ench;
        public UINT ench_skill_id;
        public UINT hp_consume;
        public INT UNK_0;
        public INT UNK_1;
    }

    public class SkillgrpInfo_CT1 : Definition
    {
        /*
        Info from l2asm-disasm
        */
        public UINT skill_id;
        public UINT skill_level;
        public UINT UNK_0;
        public UINT oper_type;
        public UINT mp_consume;
        public INT cast_range;
        public UINT cast_style;
        public FLOAT hit_time;
        public INT is_magic;
        public UNICODE ani_char;
        public UNICODE desc;
        public UNICODE icon_name;
        public UNICODE extra_eff;
        public UINT is_ench;
        public UINT ench_skill_id;
        public UINT hp_consume;
        public INT UNK_1;
        public INT UNK_2;
        public INT UNK_3;
    }

    public class SkillgrpInfo_Gracia_Plus : Definition
    {
        /**
         * by janiii
         */
        public UINT skill_id;
        public UINT skill_level;
        public UINT UNK_0;
        public UINT oper_type;
        public UINT mp_consume;
        public INT cast_range;
        public UINT cast_style;
        public FLOAT hit_time;
        public INT is_magic;
        public UNICODE ani_char;
        public UNICODE desc;
        public UNICODE icon_name;
        public UNICODE extra_eff;
        public UINT is_ench;
        public UINT ench_skill_id;
        public UINT UNK_1;
        public ASCF enchant_type;
        public UINT hp_consume;
        public INT UNK_2;
        public INT UNK_3;
    }

    public class SkillgrpInfo_Freya : Definition
    {
        /**
         * by VISTALL
         */
        public UINT skill_id;
        public UINT skill_level;
        public UINT UNK_0;
        public UINT oper_type;
        public UINT mp_consume;
        public INT cast_range;
        public UINT cast_style;
        public FLOAT hit_time;
        public INT is_magic;
        public UNICODE ani_char;
        public UNICODE desc;
        public UNICODE icon_name;
        public UNICODE extra_eff;
        public UINT is_ench;
        public UINT ench_skill_id;
        public UINT UNK_1;
        public ASCF enchant_type;
        public UINT hp_consume;
        public INT UNK_2;
        public INT UNK_3;
        public INT UNK_4;
        public ASCF enchant_type2;
    }

    #endregion

    #region Parser

    public class Skillgrp : DatParser
    {
        public override Definition getDefinition()
        {
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Freya)
                return new SkillgrpInfo_Freya();
            
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Gracia_Plus__Epilogue)
                return new SkillgrpInfo_Gracia_Plus();
            
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Gracia_Final)
                return new SkillgrpInfo_CT1();
            
            return new SkillgrpInfo();
        }

        public override Definition ParseMain(BinaryReader f, int RecNo)
        {
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Freya)
            {
               // var info = new SkillgrpInfo_Freya();
               // info = (SkillgrpInfo_Freya)base.ReadFieldValue(f, info, "skill_id", "skill_level");
               // info = (SkillgrpInfo_Freya)base.ReadFieldValue(f, info, "UNK_0");
               // info = (SkillgrpInfo_Freya)base.ReadFieldValue(f, info, "oper_type", "enchant_type2");
               // ret = info;

               return base.ParseMain(f, RecNo);
            }
            else if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Gracia_Plus__Epilogue)
            {
                //var info = new SkillgrpInfo_Gracia_Plus();
                //info = (SkillgrpInfo_Gracia_Plus) base.ReadFieldValue(f, info, "skill_id", "skill_level");
                //info = (SkillgrpInfo_Gracia_Plus) base.ReadFieldValue(f, info, "UNK_0");
                //info = (SkillgrpInfo_Gracia_Plus) base.ReadFieldValue(f, info, "oper_type", "UNK_3");
               
                return base.ParseMain(f, RecNo);
            }
            else if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Gracia_Final)
            {
                var info = new SkillgrpInfo_CT1();
                info = (SkillgrpInfo_CT1) base.ReadFieldValue(f, info, "skill_id", "skill_level");

                if (RConfig.Instance.DatVersionAsEnum >= DatVersion.HellBound)
                    info = (SkillgrpInfo_CT1) base.ReadFieldValue(f, info, "UNK_0");

                info = (SkillgrpInfo_CT1) base.ReadFieldValue(f, info, "oper_type", "UNK_3");
                return info;
            }
            else
            {
                var info = new SkillgrpInfo();
                info = (SkillgrpInfo) base.ReadFieldValue(f, info, "skill_id", "extra_eff");
                if (RConfig.Instance.DatVersionAsEnum >= DatVersion.C4)
                    info = (SkillgrpInfo) base.ReadFieldValue(f, info, "is_ench", "UNK_1");
                return info;
            }
        }

        public override void CompileMain(BinaryWriter f, List<Definition> infos, int RecNo)
        {
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Freya)
            {
                //var info = (SkillgrpInfo_Gracia_Plus) infos[RecNo];
                //base.WriteFieldValue(f, info, "skill_id", "skill_level");
                //base.WriteFieldValue(f, info, "UNK_0");
                //base.WriteFieldValue(f, info, "oper_type", "enchant_type2");

                base.CompileMain(f, infos, RecNo);
            }
            else if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Gracia_Plus__Epilogue)
            {
                //var info = (SkillgrpInfo_CT1) infos[RecNo];
                //base.WriteFieldValue(f, info, "skill_id", "skill_level");
                //base.WriteFieldValue(f, info, "UNK_0");
                //base.WriteFieldValue(f, info, "oper_type", "UNK_3");

                base.CompileMain(f, infos, RecNo);
            }
            else
            {
                var info = (SkillgrpInfo) infos[RecNo];
                base.WriteFieldValue(f, info, "skill_id", "extra_eff");
                if (RConfig.Instance.DatVersionAsEnum >= DatVersion.C4)
                    base.WriteFieldValue(f, info, "is_ench", "UNK_1");
            }
        }
    }

    #endregion
}