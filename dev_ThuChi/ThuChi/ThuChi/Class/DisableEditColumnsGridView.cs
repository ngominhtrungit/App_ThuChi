using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuChi.Class
{
    class DisableEditColumnsGridView
    {
        /// <summary>
        /// Tạo contractor với tham số là Griview và array chỉ số Columns
        /// thiết lập vòng for duyệt < lenght array
        /// 
        /// </summary>
        GridView _gridView;

        DisableEditColumnsGridView(GridView gridView, int[] indexColunm)
        {
            this._gridView = gridView;
            for (int i = 0; i < indexColunm.Length; i++)
            {
                this._gridView.Columns[indexColunm[i]].OptionsColumn.ReadOnly = true;
                this._gridView.Columns[indexColunm[i]].OptionsColumn.AllowEdit = false;
            }

        }

        public static void CustomEditColumnsGridView(GridView gridView, int[] indexColunm)
        {
            new DisableEditColumnsGridView(gridView, indexColunm);
        }
    }
}
