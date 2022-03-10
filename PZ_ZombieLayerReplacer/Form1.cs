using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PZ_ZombieLayerReplacer
{
    public partial class Form1 : Form
    {
        public static List<int> Pixel_ZombieLayer = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadMap_Click(object sender, EventArgs e)
        {
            var fbd = new FolderPicker();
            fbd.InputPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Zomboid\mods\");

            if (fbd.ShowDialog() == true && !string.IsNullOrWhiteSpace(fbd.ResultPath))
            {
                dgv_Cells.Rows.Clear();
                lbl_MapPath.Text = fbd.ResultPath + @"\";
                DirectoryInfo d = new DirectoryInfo(fbd.ResultPath);

                FileInfo[] Files = d.GetFiles("*.lotheader"); //Getting Text files

                foreach (FileInfo file in Files)
                {
                    string[] coord = Path.GetFileNameWithoutExtension(file.Name).Split(new Char[] { '_' });
                    this.dgv_Cells.Rows.Add(file.Name, int.Parse(coord[0]), int.Parse(coord[1]));
                }
                dgv_Cells.Sort(dgv_Cells.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                dgv_Cells.ClearSelection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Cells.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Cells.RowHeadersVisible = false;
        }

        private void btn_EditCell_Click(object sender, EventArgs e)
        {
            pbx_Zombies.Invalidate();
            ShowZombieLayer();
        }

        private void ShowZombieLayer()
        {

            var bitmap = new Bitmap(30, 30);
            string path = lbl_MapPath.Text + tbx_cell.Text;
            FileInfo fi = new FileInfo(path);
            try
            {

                using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    int End = unchecked((int)fi.Length);
                    int Begin = End - 0x384;
                    int x = 0;
                    int y = 0;
                    int i = Begin;


                    br.BaseStream.Position = i;
                    for (int k = 0; k < bitmap.Width; k++)
                    {
                        if (br.BaseStream.Position == End) break;
                        for (int j = 0; j < bitmap.Height; j++)
                        {
                            if (br.BaseStream.Position == End) break;

                            string Cellsnbr = br.ReadByte().ToString("x2");
                            Color color = System.Drawing.ColorTranslator.FromHtml("#" + Cellsnbr + "" + Cellsnbr + "" + Cellsnbr);
                            bitmap.SetPixel(k, j, color);
                        }
                    }



                }
                pbx_Zombies.Image = bitmap;
                bitmap.Save(lbl_MapPath.Text + tbx_cell.Text + "_ZL_Extracted.png");
                pbx_Zombies.Invalidate();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Cells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgv_Cells.CurrentCell != null)
            {
                foreach (DataGridViewRow row in dgv_Cells.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        tbx_cell.Text = row.Cells[0].Value.ToString();
                        grpBx_Main.Enabled = true;
                    }
                }
            }
            else
            {
                grpBx_Main.Enabled = false;
            }
        }

        private void btn_ImportZombie_Click(object sender, EventArgs e)
        {
            try
            {
                Pixel_ZombieLayer.Clear();
                OpenFileDialog res = new OpenFileDialog();
                res.Filter = "PNG Files|*.png";
                if (res.ShowDialog() == DialogResult.OK)
                {

                    Bitmap img = new Bitmap(res.FileName);
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            Color pixel = img.GetPixel(i, j);

                            Pixel_ZombieLayer.Add(HexStringToInt(pixel.R.ToString("X2")));
                        }
                    }
                }

                string path = lbl_MapPath.Text + tbx_cell.Text;
                System.IO.File.Copy(lbl_MapPath.Text + tbx_cell.Text, lbl_MapPath.Text + tbx_cell.Text + "_" + DateTime.Now.ToString("dd_MM_yyyy_hhmmss"), true);
                FileInfo fi = new FileInfo(path);
                using (BinaryWriter br = new BinaryWriter(File.Open(path, FileMode.Open)))
                {
                    int End = unchecked((int)fi.Length);
                    int Begin = End - 0x384;
                    int pix = 0;
                    for (int i = Begin; i <= End - 1; i++)
                    {

                        br.BaseStream.Position = i;
                        br.Write((byte)Pixel_ZombieLayer[pix]);
                        pix++;
                    }
                }
                MessageBox.Show(res.FileName + " Imported !");
                //btn_EditCell.PerformClick();
                Process.Start(lbl_MapPath.Text);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int HexStringToInt(string hex)
        {
            try
            {
                uint num = uint.Parse(hex, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] bytes = BitConverter.GetBytes(num);

                int myInt = BitConverter.ToInt32(bytes, 0);
                return myInt;
            }
            catch
            {
                return 0;
            }
        }
    }
}
