using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace binay_trees
{
    ///8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.BringToFront();


        }
        Node root = new Node();
        string currentpath = "";
        string currentfile = "";

        Node Insert_array(int[] array)
        {
            Node root = new Node();
            for (int i = 0; i < array.Length; i++)
            {
                root.Insert(array[i]);
            }


            return root;
        }

        private void btn_Creator_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtbx_array.Text;                
                int[] ints = text.Split(',')
                                 .Select(n => int.Parse(n.Trim()))
                                 .ToArray();
               
                if (ints.Length != ints.Distinct().Count())
                {
                    ints = ints.Distinct().ToArray();                    
                }
                root = Insert_array(ints);
                
                txtbx_array.Text = "";
            }
            catch 
            {
                txtbx_array.Text = "";
                return;
            }
        }



        private async void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (root.value != null)
            {
                switch (cbOrder.SelectedIndex)
                {
                    case 0:
                        txtboxOrder.Text = "";
                        await In_Order(root);
                        break;
                    case 1:
                        txtboxOrder.Text = "";
                        await Pre_Order(root);
                        break;
                    case 2:
                        txtboxOrder.Text = "";
                        await  Post_Order(root);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                cbOrder.SelectedIndex = -1;
                return;
            }           
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            try
            {
                Node? node = root.Search(Convert.ToInt32(txtbx_array.Text));
                if (node != null)
                {
                    string action = "Sought";
                    MessageBox.Show(root.GetNodeInfo(node, action));
                }
                else if (root.value == null)
                {
                    MessageBox.Show("Create a tree first");
                    txtbx_array.Text = "";
                }
                else
                {
                    MessageBox.Show(" Value Not Found");
                }
            }
            catch 
            {
                txtbx_array.Text = "";
                return;
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string action = "Deleted";
                Node? node = root.Search(Convert.ToInt32(txtbx_array.Text));
                if (node != null)
                {
                    MessageBox.Show(root.GetNodeInfo(node, action));

                    root.Delete(root, Convert.ToInt32(txtbx_array.Text));

                    GenerateTree();

                }
                else if (root.value == null)
                {
                    MessageBox.Show("Create a tree first");
                    txtbx_array.Text = "";
                }
                else
                {
                    MessageBox.Show(" Value Not Found");
                }
            }
            catch 
            {
                txtbx_array.Text = "";
                return;
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Node? node = root.Search(Convert.ToInt32(txtbx_array.Text));
                if (node != null)
                {
                    MessageBox.Show("Value already exists");
                    txtbx_array.Text = "";
                }
                else if (root.value == null)
                {
                    MessageBox.Show("Create a tree first");
                    txtbx_array.Text = "";
                }
                else
                {
                    int number = Convert.ToInt32(txtbx_array.Text);
                    root.Insert(number);
                    txtbx_array.Text = "";
                    GenerateTree();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GenerateTree()
        {
            string userDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(userDocuments, "Trees");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (string.IsNullOrWhiteSpace(currentfile) && string.IsNullOrWhiteSpace(currentpath))
            {
                string file = RandomPNGName();

                string filePath = Path.Combine(directoryPath, file + ".dot");
                currentfile = file + ".png";
                currentpath = filePath;
            }
            if (File.Exists(directoryPath + currentfile))
            {
                File.Delete(directoryPath + currentfile);
            }
            using (StreamWriter writer = new StreamWriter(currentpath))
            {
                writer.WriteLine("digraph G {");
                if (root != null)
                {
                    root.ExportarGraphviz(root, writer);
                }
                writer.WriteLine("}");
            }
            GeneratePngFromDot(currentpath, directoryPath + "\\" + currentfile);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (root.value != null)
            {
                GenerateTree();
                root.TreeInfo();
            }
            else 
            {
                MessageBox.Show("Create a tree first");
                return;
            }
        }
        public string RandomPNGName()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
            StringBuilder sb = new StringBuilder("Tree");
            sb.Append(randomString);
            return sb.ToString();
        }

        public void GeneratePngFromDot(string dotFilePath, string outputImagePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\Graphviz\bin\dot.exe";
            startInfo.Arguments = $"-Tpng \"{dotFilePath}\" -o \"{outputImagePath}\"";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            
            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }
            using (FileStream fs = new FileStream(outputImagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms); 
                    ms.Position = 0; 

                    using (Image image = Image.FromStream(ms))
                    {
                        pbTree.Image = (Image)image.Clone(); 
                    }
                }
            }

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {           
            root = new Node();
            pbTree.Image = null;      
        }


        public async Task In_Order(Node? root)
        {
            List<string> values = new List<string>();
            await In_Order_Helper(root, values);
            txtboxOrder.Text = string.Join(", ", values);
        }

        private async Task In_Order_Helper(Node? root, List<string> values)
        {
            if (root == null)
                return;

            await In_Order_Helper(root.left, values);

            label1.Invoke((Action)(() => label1.Text = root.value.ToString()));
            values.Add(root.value.ToString());
            await Task.Delay(1000);

            await In_Order_Helper(root.right, values);
        }

        public async Task Pre_Order(Node? root)
        {
            List<string> values = new List<string>();
            await Pre_Order_Helper(root, values);
            txtboxOrder.Text = string.Join(", ", values);
        }

        private async Task Pre_Order_Helper(Node? node, List<string> values)
        {
            if (node == null) return;

            label1.Invoke((Action)(() => label1.Text = node.value.ToString()));
            values.Add(node.value.ToString());
            await Task.Delay(1000);

            await Pre_Order_Helper(node.left, values);
            await Pre_Order_Helper(node.right, values);
        }

        public async Task Post_Order(Node? root)
        {
            List<string> values = new List<string>();
            await Post_Order_Helper(root, values);
            txtboxOrder.Text = string.Join(", ", values);
        }

        private async Task Post_Order_Helper(Node? root, List<string> values)
        {
            if (root == null) return;

            await Post_Order_Helper(root.left, values);
            await Post_Order_Helper(root.right, values);

            label1.Invoke((Action)(() => label1.Text = root.value.ToString()));
            values.Add(root.value.ToString());
            await Task.Delay(1000);
        }
    }
    
}
