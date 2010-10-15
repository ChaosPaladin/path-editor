using com.jds.PathEditor.classes.client.mothers;
using com.jds.PathEditor.classes.client.types;
using com.jds.PathEditor.classes.services;

/**
 * Tested:
 *  - Anniversary [WORK]
 */
namespace com.jds.PathEditor.classes.client.definitions
{
    #region Definition

    public class AdditionalItemgrp_Info : Definition
    {
        public UINT item_id;
        public UINT zero_1;
        public UINT zero_2;
        public UINT item_id_1;
        public UINT item_id_2;
        public UINT item_id_3;
        public UINT item_id_4;
        public UINT item_id_5;
        public UINT item_id_6;
        public UINT item_id_7;
        public UINT item_id_8;
        public UINT item_id_9;
        public UINT item_id_10;
        public INT max_energy;
    }

    #endregion

    #region Parser

    public class AdditionalItemgrp : DatParser
    {
        public override Definition getDefinition()
        {
            if (RConfig.Instance.DatVersionAsEnum >= DatVersion.Anniversary)
                return new AdditionalItemgrp_Info();

            return null;
        }
    }

    #endregion
}