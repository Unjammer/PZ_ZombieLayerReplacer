namespace PZ_ZombieLayerReplacer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadMap = new System.Windows.Forms.Button();
            this.dgv_Cells = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MapPath = new System.Windows.Forms.Label();
            this.grpBx_Main = new System.Windows.Forms.GroupBox();
            this.btn_ImportZombie = new System.Windows.Forms.Button();
            this.pbx_Zombies = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_cell = new System.Windows.Forms.TextBox();
            this.btn_EditCell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cells)).BeginInit();
            this.grpBx_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Zombies)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadMap
            // 
            this.btn_LoadMap.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadMap.Name = "btn_LoadMap";
            this.btn_LoadMap.Size = new System.Drawing.Size(41, 23);
            this.btn_LoadMap.TabIndex = 9;
            this.btn_LoadMap.Text = "...";
            this.btn_LoadMap.UseVisualStyleBackColor = true;
            this.btn_LoadMap.Click += new System.EventHandler(this.btn_LoadMap_Click);
            // 
            // dgv_Cells
            // 
            this.dgv_Cells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Cells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Cells.Location = new System.Drawing.Point(12, 42);
            this.dgv_Cells.MultiSelect = false;
            this.dgv_Cells.Name = "dgv_Cells";
            this.dgv_Cells.ReadOnly = true;
            this.dgv_Cells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cells.Size = new System.Drawing.Size(226, 396);
            this.dgv_Cells.TabIndex = 10;
            this.dgv_Cells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cells_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "File";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            // 
            // lbl_MapPath
            // 
            this.lbl_MapPath.Location = new System.Drawing.Point(59, 17);
            this.lbl_MapPath.Name = "lbl_MapPath";
            this.lbl_MapPath.Size = new System.Drawing.Size(384, 13);
            this.lbl_MapPath.TabIndex = 11;
            this.lbl_MapPath.Text = "...";
            // 
            // grpBx_Main
            // 
            this.grpBx_Main.Controls.Add(this.btn_ImportZombie);
            this.grpBx_Main.Controls.Add(this.pbx_Zombies);
            this.grpBx_Main.Controls.Add(this.label12);
            this.grpBx_Main.Controls.Add(this.tbx_cell);
            this.grpBx_Main.Controls.Add(this.btn_EditCell);
            this.grpBx_Main.Enabled = false;
            this.grpBx_Main.Location = new System.Drawing.Point(244, 42);
            this.grpBx_Main.Name = "grpBx_Main";
            this.grpBx_Main.Size = new System.Drawing.Size(199, 396);
            this.grpBx_Main.TabIndex = 26;
            this.grpBx_Main.TabStop = false;
            this.grpBx_Main.Text = "Render Cell";
            // 
            // btn_ImportZombie
            // 
            this.btn_ImportZombie.Location = new System.Drawing.Point(6, 344);
            this.btn_ImportZombie.Name = "btn_ImportZombie";
            this.btn_ImportZombie.Size = new System.Drawing.Size(187, 46);
            this.btn_ImportZombie.TabIndex = 34;
            this.btn_ImportZombie.Text = "Import/Replace  Zombies Layer";
            this.btn_ImportZombie.UseVisualStyleBackColor = true;
            this.btn_ImportZombie.Click += new System.EventHandler(this.btn_ImportZombie_Click);
            // 
            // pbx_Zombies
            // 
            this.pbx_Zombies.Location = new System.Drawing.Point(6, 96);
            this.pbx_Zombies.Name = "pbx_Zombies";
            this.pbx_Zombies.Size = new System.Drawing.Size(187, 187);
            this.pbx_Zombies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Zombies.TabIndex = 33;
            this.pbx_Zombies.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Cell:";
            // 
            // tbx_cell
            // 
            this.tbx_cell.Location = new System.Drawing.Point(43, 19);
            this.tbx_cell.Name = "tbx_cell";
            this.tbx_cell.ReadOnly = true;
            this.tbx_cell.Size = new System.Drawing.Size(150, 20);
            this.tbx_cell.TabIndex = 13;
            // 
            // btn_EditCell
            // 
            this.btn_EditCell.Location = new System.Drawing.Point(6, 45);
            this.btn_EditCell.Name = "btn_EditCell";
            this.btn_EditCell.Size = new System.Drawing.Size(187, 45);
            this.btn_EditCell.TabIndex = 14;
            this.btn_EditCell.Text = "Show Selected Cell";
            this.btn_EditCell.UseVisualStyleBackColor = true;
            this.btn_EditCell.Click += new System.EventHandler(this.btn_EditCell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.grpBx_Main);
            this.Controls.Add(this.btn_LoadMap);
            this.Controls.Add(this.dgv_Cells);
            this.Controls.Add(this.lbl_MapPath);
            this.MaximumSize = new System.Drawing.Size(469, 600);
            this.MinimumSize = new System.Drawing.Size(469, 489);
            this.Name = "Form1";
            this.Text = "ZombieLayerReplacer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cells)).EndInit();
            this.grpBx_Main.ResumeLayout(false);
            this.grpBx_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Zombies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadMap;
        private System.Windows.Forms.DataGridView dgv_Cells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbl_MapPath;
        private System.Windows.Forms.GroupBox grpBx_Main;
        private System.Windows.Forms.Button btn_ImportZombie;
        private System.Windows.Forms.PictureBox pbx_Zombies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_cell;
        private System.Windows.Forms.Button btn_EditCell;
    }
}

