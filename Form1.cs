using SqlToModel;
using System.Text;

namespace TableToModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strConn;
        string strTableName;
        string strclassName;
        StringBuilder stringBuilder = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                strConn = txtConn.Text.Trim();
                strTableName = txtTableName.Text.Trim();
                strclassName = txtClassName.Text.Trim();
                if (String.IsNullOrEmpty(strConn) || String.IsNullOrEmpty(strTableName) || String.IsNullOrEmpty(strclassName))
                {
                    MessageBox.Show("����д���ã�");
                    return;
                }
                var dicTableStruct = SqlHelper.SetSqlConnection(strConn, strTableName);
                stringBuilder.Clear();
                txtResult.Clear();
                stringBuilder.Append("using System;\r\n");
                stringBuilder.Append("using System.ComponentModel.DataAnnotations.Schema;\r\n\n");
                stringBuilder.Append("public class " + strclassName + "\r\n");
                stringBuilder.Append("{\r\n");
                foreach (var item in dicTableStruct)
                {

                    stringBuilder.Append("    [Column(\"" + item.Key + "\")]\r\n");
                    stringBuilder.Append("    public " + item.Value + " " + ConvertToCamelCase(item.Key) + " { get; set; }\r\n");
                }
                stringBuilder.Append("}\r\n");
                txtResult.Text = stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //�����cs�ļ�
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (String.IsNullOrEmpty(txtResult.Text))
                {
                    MessageBox.Show("����begin��");
                    return;
                }
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = System.IO.Path.Combine(folderBrowserDialog.SelectedPath, strclassName + ".cs");
                    System.IO.File.WriteAllText(path, stringBuilder.ToString());
                    MessageBox.Show("���ɳɹ���");
                }
                else
                {
                    MessageBox.Show("δѡ���ļ��У�");
                }
            }
        }
        private string ConvertToCamelCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            bool capitalizeNext = false;

            foreach (char c in input)
            {
                if (c == '_')
                {
                    capitalizeNext = true;
                }
                else
                {
                    result.Append(capitalizeNext ? char.ToUpper(c) : c);
                    capitalizeNext = false;
                }
            }

            // ����ĸ��д
            if (result.Length > 0)
            {
                result[0] = char.ToUpper(result[0]);
            }

            return result.ToString();
        }

    }
}
