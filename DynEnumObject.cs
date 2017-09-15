using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NicScripts.DynEnum {
    [System.Serializable]
    public class DynEnumObject {
        [SerializeField]
        public string EnumName;
        [SerializeField]
        public string[] EnumValues;
        //[SerializeField]
        //public Type EnumType;
        //[SerializeField]
        //public DynEnumerable[] vals;
    }

    //public enum Type {
    //    _Byte,
    //    _Sbyte,
    //    _Short,
    //    _Ushort,
    //    _Int,
    //    _Uint,
    //    _Long,
    //    _Ulong
    //}

    //[System.Serializable]
    //public class DynEnumerable {

    //}
}