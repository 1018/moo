using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mooEditor
{
    public class PageInfo
    {
        private string _tabName;
        private string _rowName;
        private string _editorName;
        private int _cursorPosiX;
        private int _cursorPosiY;
        private bool _dirtyFlag;
        private bool _readOnlyFlag;

        public PageInfo() { }        
        public PageInfo(string tab, string row, string editor, int x = 0, int y = 0, bool dFlag = false, bool rFlag = false)
        {
            _tabName = tab;
            _rowName = row;
            _editorName = editor;
            _cursorPosiX = x;
            _cursorPosiY = y;
            _dirtyFlag = dFlag;
            _readOnlyFlag = rFlag;
        }

        public string TabName
        {
            get
            {
                return _tabName;
            }
        }

        public string RowNoName
        {
            get
            {
                return _rowName;
            }
        }
        public string EditorName 
        {
            get
            {
                return _editorName;
            }
            
        }
        public int CursorPosiX { get; set; }
        public int CursorPosiY { get; set; }
        public bool DirtyFlag { get; set; }
        public bool ReadOnlyFlag { get; set; }
           

    }
}
