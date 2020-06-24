using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuChi.Class
{
    class CustomCellMergeColumnGridView
    {
        GridView _gridView;
        string _txt;

        public CustomCellMergeColumnGridView()
        {

        }

        public CustomCellMergeColumnGridView(GridView gridView, string txt)
        {
            this._gridView = gridView;
            this._txt = txt;
        }

        public void CellMergeColumnGridViewDTTC()
        {
            for (int i = 0; i < _gridView.Columns.Count; i++)
            {
                if (_gridView.Columns[i].FieldName == _txt)
                {
                    _gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    _gridView.Columns[i - 1].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
                else
                {
                    _gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
            }

        }

        public void CellMergeColumnGridViewTienCC()
        {
            for (int i = 0; i < _gridView.Columns.Count; i++)
            {
                if (_gridView.Columns[i].FieldName == _txt)
                {
                    _gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    //_gridView.Columns[i - 1].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
                else
                {
                    _gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
            }

        }
    }
}
