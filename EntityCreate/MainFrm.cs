using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Threading;
using System.IO;

namespace EntityCreate
{
    public partial class MainFrm : Form
    {
        IList<String> _iTableName = new List<String>();
        IDbConnection _conn = null;
        IDbCommand _cmd = null;
        IDbDataAdapter _adp = null;
        string path = "";
        public MainFrm()
        {
            InitializeComponent();
            this.radbt_oracle.Checked = true;
        }

        private void btn_createEntity_Click(object sender, EventArgs e)
        {
            dbType dt = dbType.ORACLE;
            if (this.radbt_mysql.Checked)
            {
                dt = dbType.MYSQL;
            }
            else if (this.radbt_mssql.Checked)
            {
                dt = dbType.SQLSERVER;
            }
            else
            {
                dt = dbType.ORACLE;
            }
            path = "class\\" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            GetAllTableName(dt);
            CreateClass(dt);
        }

        IDbConnection GetConenction(dbType type)
        {
            if (type == dbType.ORACLE)
            {
                _conn = new OracleConnection(this.rtbx_showCreateState.Text);
            }
            else if (type == dbType.SQLSERVER)
            {
                _conn = new SqlConnection(this.rtbx_showCreateState.Text);
            }
            return _conn;
        }

        void GetAllTableName(dbType type)
        {
            string _sqlStringAllTable = "";
            IDataReader _reader = null;
            switch (type)
            {
                case dbType.ORACLE:
                    _sqlStringAllTable = "select TABLE_NAME from user_tables";
                    _cmd = new OracleCommand(_sqlStringAllTable, (OracleConnection)GetConenction(type));
                    _conn.Open();
                    _reader = _cmd.ExecuteReader();
                    while (_reader.Read())
                    {
                        _iTableName.Add(_reader["TABLE_NAME"].ToString());
                    }
                    break;
                case dbType.SQLSERVER:
                    _sqlStringAllTable = "select name from sysobjects where xtype='U'";
                    _cmd = new SqlCommand(_sqlStringAllTable, (SqlConnection)GetConenction(type));
                    _conn.Open();
                    _reader = _cmd.ExecuteReader();
                    while (_reader.Read())
                    {
                        _iTableName.Add(_reader["name"].ToString());
                    }
                    break;
                case dbType.MYSQL:
                    break;
            }

            _conn.Close();
        }

        void CreateClass(dbType type)
        {
            for (int i = 0; i < _iTableName.Count; i++)
            {
                string _sqlStringAllTable = "";
                if (type == dbType.ORACLE)
                {
                    _sqlStringAllTable = "select * from " + _iTableName[i] + " WHERE ROWNUM < 1";
                    _adp = new OracleDataAdapter(_sqlStringAllTable, (OracleConnection)GetConenction(type));
                }
                else if (type == dbType.SQLSERVER)
                {
                    _sqlStringAllTable = "select top 1 * from " + _iTableName[i];
                    _adp = new SqlDataAdapter(_sqlStringAllTable, (SqlConnection)GetConenction(type));
                }
                DataSet ds = new System.Data.DataSet();
                _adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                IList<model> name = GetColumnsByDataTable(dt);
                CreateClassFile(name, _iTableName[i]);
                CreateXml(name, _iTableName[i]);
            }
            MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK);
        }

        public static IList<model> GetColumnsByDataTable(DataTable dt)
        {
            IList<model> imodel = new List<model>();

            if (dt.Columns.Count > 0)
            {
                int columnNum = 0;
                columnNum = dt.Columns.Count;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    model m = new model() { t = dt.Columns[i].DataType, name = dt.Columns[i].ColumnName };
                    imodel.Add(m);
                }
            }

            return imodel;
        }

        void CreateClassFile(IList<model> imodel, string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("");
            sb.AppendLine("namespace " + tbx_nameSpaces.Text);
            sb.AppendLine("{");
            sb.AppendLine("    [Serializable]");
            sb.AppendLine("    public class " + name);
            sb.AppendLine("    {");
            foreach (var item in imodel)
            {
                sb.AppendLine("        public virtual " + item.t.Name + " " + item.name + " { get; set; }");
            }
            sb.AppendLine("    }");
            sb.AppendLine("}");

            Directory.CreateDirectory(path);
            StreamWriter sw = new StreamWriter(path + "\\" + name + ".cs");
            sw.WriteLine(sb.ToString());
            sw.Close();
        }

        void CreateXml(IList<model> imodel, string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<hibernate-mapping xmlns=\"urn:nhibernate-mapping-2.2\" assembly=\"" + tbx_appLoaction.Text + "\" namespace=\"" + tbx_nameSpaces.Text + "\">");
            sb.AppendLine("  <class name=\"" + name + "\" table=\"" + name + "\" lazy=\"true\" >");
            sb.AppendLine("    <id name=\"" + imodel[0].name + "\" column=\"" + imodel[0].name + "\" type=\"" + imodel[0].t.Name + "\">");
            sb.AppendLine("      <generator class=\"assigned\" />");
            sb.AppendLine("    </id>");

            for (int i = 1; i < imodel.Count; i++)
            {
                sb.AppendLine("    <property name=\"" + imodel[i].name + "\" column=\"" + imodel[i].name + "\" type=\"" + imodel[i].t.Name + "\"></property>");
            }
            sb.AppendLine("  </class>");
            sb.AppendLine("</hibernate-mapping>");
            Directory.CreateDirectory(path);
            StreamWriter sw = new StreamWriter(path + "\\" + name + ".hbm.xml");
            sw.WriteLine(sb.ToString());
            sw.Close();
        }
    }

    public class model
    {
        public Type t { get; set; }
        public string name { get; set; }
    }
}
