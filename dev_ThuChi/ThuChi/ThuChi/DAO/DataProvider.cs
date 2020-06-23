using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuChi.frm;

namespace ThuChi.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = "Data Source=.;Initial Catalog=BaoCaoThuChi;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public void GetDatatenCabyNgay(DateTime ngay, ComboBox cbBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_RetrieveTenCabyNgay", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Parse(ngay.Date.ToString()));
                    cmd.Parameters.Add("@tenCa", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@tenCa"].Direction = ParameterDirection.Output;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    cbBox.Items.Add(cmd.Parameters["@tenCa"].Value.ToString());
                    //cbBox.Text = cmd.Parameters["@tenCa"].Value.ToString();

                    //SqlDataAdapter da = new SqlDataAdapter();
                    //da.SelectCommand = cmd;
                    //DataTable result = new DataTable();
                    //da.Fill(result);

                    //cbBox.DataSource = result;
                }
            }


        }

        public void GetDataTienDelaibyNgay(DateTime ngay, TextBox textBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_RetrieveTienLaibyDay", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Parse(ngay.Date.ToString()));
                    cmd.Parameters.Add("@tiendelai", SqlDbType.Float);
                    cmd.Parameters["@tiendelai"].Direction = ParameterDirection.Output;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                }
            }
        }

        public void GetDataDoanhThuIdbyNgay(DateTime ngay, TextBox textBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_RetrieveDoanhThuIDbyDay", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Parse(ngay.Date.ToString()));
                    cmd.Parameters.Add("@doanhthuID", SqlDbType.Int);
                    cmd.Parameters["@doanhthuID"].Direction = ParameterDirection.Output;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (cmd.Parameters["@doanhthuID"].Value.ToString() == "")
                    {

                        //

                        DialogResult result = MessageBox.Show("bạn chưa tạo ngày " + ngay + ", xin mời Click Ok để tạo ngày, CANCE để kết thúc!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            //mở form dk ngày dt
                            using (frm_InsertDoanhThuNgay f2 = new frm_InsertDoanhThuNgay())
                            {
                                f2.ShowDialog();
                            }

                        }
                        else
                        {
                            // Do something  
                        }

                        return;
                       
                    }
                     textBox.Text = cmd.Parameters["@doanhthuID"].Value.ToString();
                    
                }
            }
        }

        public void InsertDataDoanhThu(DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertDoanhThu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                 
                    cmd.Parameters.AddWithValue("@ngaytaodt", DateTime.Parse(ngay.Date.ToString()));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    MessageBox.Show("Thêm " + ngay + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void InsertDataDoanhThu1(string doanhthuID,string tiendelai,string doanhthutrongngay,string doanhthukhac, DateTime ngay)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertDoanhThu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doanhthuID",doanhthuID);
                    cmd.Parameters.AddWithValue("@tiendelai",float.Parse( tiendelai.ToString()));
                    cmd.Parameters.AddWithValue("@doanhthutrongngay", float.Parse(doanhthutrongngay.ToString()));
                    cmd.Parameters.AddWithValue("@doanhthukhac", float.Parse(doanhthukhac.ToString()));
                    cmd.Parameters.AddWithValue("@ngaytaodt", DateTime.Parse(ngay.Date.ToString()));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    MessageBox.Show("Thêm " + doanhthuID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void UpdateDataDoanhThu1(string doanhthuID, string doanhthutrongngay, string doanhthukhac)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_UpdateDoanhThu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doanhthuID", doanhthuID);
                    //cmd.Parameters.AddWithValue("@tiendelai", float.Parse(tiendelai.ToString()));
                    cmd.Parameters.AddWithValue("@doanhthutrongngay", float.Parse(doanhthutrongngay.ToString()));
                    cmd.Parameters.AddWithValue("@doanhthukhac", float.Parse(doanhthukhac.ToString()));
                    //cmd.Parameters.AddWithValue("@ngaytaodt", DateTime.Parse(ngay.Date.ToString()));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();

                    MessageBox.Show("Update " + doanhthuID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void DeleteDataDoanhThu1(string doanhthuID)
        {
            //try
            //{
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    using (SqlCommand cmd = new SqlCommand("proc_DeleteDoanhThu", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doanhthuID", doanhthuID);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    }
                }
            //}
            //catch (SqlException exc)
            //{
            //    MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Doanh Thu! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           
        }

        public void DeleteDataTienLoiCN(string tlID)
        {
            //try
            //{
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_DeleteTienLoiCN", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tlID", tlID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                }
            }
            //}
            //catch (SqlException exc)
            //{
            //    MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Doanh Thu! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        public void DeleteDataChiPhi(string chiPhiID)
        {
            //try
            //{
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_DeleteChiPhi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@chiphiID", chiPhiID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                }
            }
            //}
            //catch (SqlException exc)
            //{
            //    MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Doanh Thu! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        public void DeleteDataDoanhThu(int chiPhiID)
        {
            //try
            //{
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_DeleteDoanhThu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doanhthuID", chiPhiID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                }
            }
            //}
            //catch (SqlException exc)
            //{
            //    MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Doanh Thu! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        public void LoadComboBox(ComboBox comboBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select ngaytaodt from dbo.DoanhThu";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetDateTime(0);
                        comboBox.Items.Add(name);
                    }
                }
                saConn.Close();
            }
          
        }

        //
        public void LoadtenCa_by_NgayTaoDT(string ngay, ComboBox comboBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();
                
                string query = "exec proc_RetrieveTenCabyNgayTaoDT @ngay = '" + ngay + "'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {

                        var name = saReader.GetString(0);
                        comboBox.Items.Add(name);


                    }
                }
                saConn.Close();
            }

        }

        public void LoadCB_tenCa_by_Ngay(string ngay,ComboBox comboBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select tenCa from DoanhThu dt, DoanhThuTheoCa ca where dt.ngaytaodt = '"+ ngay +"' and dt.doanhthuID = ca.doanhthuID";
                SqlCommand cmd = new SqlCommand(query, saConn);
           
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                       
                            var name = saReader.GetString(0);
                            comboBox.Items.Add(name);
                        
                        
                    }
                }
                saConn.Close();
            }

        }

        public void LoadCB_tenCDT(ComboBox comboBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select tenCDT from dbo.ChuDauTu";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetString(0);
                        comboBox.Items.Add(name);
                    }
                }
                saConn.Close();
            }
        }

        public void ChoseComboBoxChangeTextBox(ComboBox comboBox,TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select doanhthuID from dbo.DoanhThu where ngaytaodt = '" +comboBox.Text+"'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetString(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name;
                    }
                }
                saConn.Close();
            }

        }

        public void ChoseComboBoxChangeTextBoxDTTC(DateTime ngay, ComboBox comboBox, TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select tien.tienconlaitheoca from DoanhThu dt, DoanhThuTheoCa ca, TienConLaiTheoCa tien where dt.doanhthuID = ca.doanhthuID and ca.caID = tien.caID and dt.ngaytaodt = '"+ ngay +"'  and ca.tenCa = '" + comboBox.Text +"'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetDouble(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name.ToString();

                        //check điều kiện nếu như tiền còn lại cuối ca ==null thì 
                       
                    }
                }
                saConn.Close();
            }

        }


        public void ChoseComboBoxChangeTextBox_CPtcID_by_TenNgayCP(DateTime ngay, ComboBox comboBox, TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "exec [dbo].[proc_ShowChiPhiIDbyTenCaAndNgayTaoCP] @tenCa='" + comboBox.Text + "', @ngay = '" + ngay + "'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetInt32(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name.ToString();
                    }
                }
                saConn.Close();
            }

        }

        //ddang sưaeer
        public void ChoseComboBoxChangeTextBoxChiPhiTC(DateTime ngay, ComboBox comboBox, TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "select ca.caID from DoanhThuTheoCa ca, DoanhThu dt	where ca.tenCa = '"+comboBox.Text+"' and dt.doanhthuID = ca.doanhthuID and dt.ngaytaodt = '"+ngay+"'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetInt32(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name.ToString();
                    }
                }
                saConn.Close();
            }

        }

        public void InsertDataChiPhiTheoCa(DateTime ngay, string caID)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertChiPhiTheoCa", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngaytaocp", DateTime.Parse(ngay.Date.ToString()));
                    cmd.Parameters.AddWithValue("@caID", caID);

                    connection.Open();
                    cmd.ExecuteScalar();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    MessageBox.Show("Thêm chi phí Ca" + ngay + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void InsertDataCTChiPhi(string chiphitcID, string mota, string dvt, string soluong, string dongia)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertCTChiPhiTheoCa", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@chiphitcID", chiphitcID);
                    cmd.Parameters.AddWithValue("@mota", mota);
                    cmd.Parameters.AddWithValue("@donvitinh", dvt);
                    cmd.Parameters.AddWithValue("@soluong", float.Parse(soluong.ToString()));
                    cmd.Parameters.AddWithValue("@dongia",float.Parse(dongia.ToString()));


                    connection.Open();
                    cmd.ExecuteScalar();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    //MessageBox.Show("Thêm " + chiphiID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ShowDatabychiphiID(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_ShowCTCP_by_chiphiID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@chiphiID", id);

                    connection.Open();
                    cmd.ExecuteScalar();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    //MessageBox.Show("Thêm " + chiphiID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void DeleteDataCDT(string cdtID)
        {
            //try
            //{
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_DeleteCDT", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cdtID", cdtID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                }
            }
            //}
            //catch (SqlException exc)
            //{
            //    MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Doanh Thu! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        public void InsertDataCDT(string cdtID, string tenCDT, string sdtCDT,string diachiCDT)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_InsertCDT", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cdtID", cdtID);
                    cmd.Parameters.AddWithValue("@tenCDT", tenCDT);
                    cmd.Parameters.AddWithValue("@sdtCDT", int.Parse(sdtCDT.ToString()));
                    cmd.Parameters.AddWithValue("@diachiCDT", diachiCDT);

                    connection.Open();
                    cmd.ExecuteScalar();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    //MessageBox.Show("Thêm " + chiphiID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void GetDataDoanhThuIDbyNgay(DateTime ngay, TextBox textBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_RetrieveDoanhThuIDbyDay", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Parse(ngay.Date.ToString()));
                    cmd.Parameters.Add("@doanhthuID", SqlDbType.VarChar,10);
                    cmd.Parameters["@doanhthuID"].Direction = ParameterDirection.Output;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    textBox.Text = cmd.Parameters["@doanhthuID"].Value.ToString();
                }
            }
        }

        public void InsertDataTienLoiCN(string cdtID, string doanhthuID)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand cmd = new SqlCommand("proc_AddTienLoi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tlID", cdtID);
                    cmd.Parameters.AddWithValue("@doanhthuID", doanhthuID);
                    

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    // textBox.Text = cmd.Parameters["@tiendelai"].Value.ToString();
                    MessageBox.Show("Thêm " + cdtID + " thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void LoadCB_tenCa_by_NgayTaoCP(string ngay, ComboBox comboBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "exec proc_ShowTenCabyNgaytaocp '" + ngay + "'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {

                        var name = saReader.GetString(0);
                        comboBox.Items.Add(name);


                    }
                }
                saConn.Close();
            }

        }

        public void ChoseComboBoxChangeTextBoxCDTNhanTien(DateTime ngay, ComboBox comboBox, TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "exec proc_ShowChiPhiIDbyTenCaAndNgayTaoCP @tenCa ='" + comboBox.Text + "', @ngay ='" + ngay + "'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetInt32(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name.ToString();
                    }
                }
                saConn.Close();
            }

        }

        public void ChoseComboBoxChangeTextBox_cdtID(ComboBox comboBox, TextBox textBox)
        {
            using (SqlConnection saConn = new SqlConnection(this.connectionSTR))
            {
                saConn.Open();

                string query = "exec proc_RetrieveCDTID_by_TenCDT @tenCDT = N'"+comboBox.Text+"'";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        var name = saReader.GetInt32(0);
                        //textBox.Text = comboBox.SelectedItem.ToString();
                        textBox.Text = name.ToString();
                    }
                }
                saConn.Close();
            }

        }
    }
}
