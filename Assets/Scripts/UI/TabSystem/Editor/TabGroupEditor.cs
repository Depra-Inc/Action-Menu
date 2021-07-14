using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace FD.UI.TabSystem.Editor
{
    using Panels;
    
    [CustomEditor(typeof(TabGroup))]
    internal class TabGroupEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.DrawDefaultInspector();

            if (GUILayout.Button("Setup"))
            {
                var tabGroup = target as TabGroup;

                var buttons = tabGroup.GetComponentsInChildren<TabButton>(true);
                
                var rootPanel = tabGroup.GetComponent<Panel>();
                var panels = rootPanel
                        ? GetComponentsInChildrenWithout(tabGroup.transform, rootPanel)
                        : tabGroup.GetComponentsInChildren<Panel>(true);

                tabGroup.Init(buttons, panels);
            }
        }

        private T[] GetComponentsInChildrenWithout<T>(Transform root, T exception)
        {
            var panels =  new HashSet<T>(root.GetComponentsInChildren<T>(true));
            panels.Remove(exception);

            return panels.ToArray();
        }
    }
}