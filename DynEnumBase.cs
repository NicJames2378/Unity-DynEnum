using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace NicScripts.DynEnum {
    [ExecuteInEditMode]
    public class DynEnumBase : MonoBehaviour {

        [Tooltip("The C# Class file you wish to use for storing Enums.")]
        public UnityEngine.Object TEXT_OBJECT;
        [Tooltip("The name for the class to store all Enums in (I recommend something simple like 'EnumContainer'). Leave this blank if you wish to not use a holding class and just store the enums together in the file.")]
        public string className;
        [Tooltip("I'm a lazy developer. This is my button. Deal with it. (TIP: Click once to update the above file. The toggle will automatically untick.")]
        public bool UPDATE = false;
        [Tooltip("The list of Enums. Expand to configure."), Space(10)]
        public DynEnumObject[] EnumsList;

        private string[] tokens = new string[] {
            "public enum ",     // 0
            " {",               // 1
            "}",                // 2
            "    ",             // 3
            "public class "     // 4

        };

#if (UNITY_EDITOR)
        private void Update () {
            if ( UPDATE ) {
                WriteAllEnums ();
                UPDATE = false;
            }
        }

        private void WriteAllEnums () {
            string textToWrite = null;
            string classSpacing = "";

            if (!String.IsNullOrEmpty(className)) {
                classSpacing = tokens[3];
                textToWrite += tokens[4] + className + tokens[1] + Environment.NewLine;
            }

            for ( int en = 0; en < EnumsList.Length; en++ ) {
                textToWrite += classSpacing + tokens[0] + EnumsList[en].EnumName + tokens[1] + Environment.NewLine;

                for ( int s = 0; s < EnumsList[en].EnumValues.Length; s++ ) {
                    textToWrite += classSpacing + tokens[3] + EnumsList[en].EnumValues[s];
                    if ( s != EnumsList[en].EnumValues.Length - 1 ) { textToWrite += ","; }
                    textToWrite += Environment.NewLine;
                }
                textToWrite += classSpacing + tokens[2] + Environment.NewLine;
                if (en < EnumsList.Length - 1) { textToWrite += Environment.NewLine; }
            }

            if ( !String.IsNullOrEmpty ( className ) ) {
                textToWrite += tokens[2] + Environment.NewLine;
            }

            File.WriteAllText ( AssetDatabase.GetAssetPath ( TEXT_OBJECT ), textToWrite );
            EditorUtility.SetDirty ( TEXT_OBJECT );
            Debug.Log ( "DynEnum: Object Updated!" );
        }
#endif
    }
}