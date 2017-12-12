namespace LiteDB_Merger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DbView = new System.Windows.Forms.ListView();
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButt = new System.Windows.Forms.Button();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.ResetButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputLab = new System.Windows.Forms.Label();
            this.ChangeButt = new System.Windows.Forms.Button();
            this.MergeButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MergeButt);
            this.splitContainer1.Panel1.Controls.Add(this.ChangeButt);
            this.splitContainer1.Panel1.Controls.Add(this.OutputLab);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResetButt);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveButt);
            this.splitContainer1.Panel2.Controls.Add(this.AddButt);
            this.splitContainer1.Panel2.Controls.Add(this.DbView);
            this.splitContainer1.Size = new System.Drawing.Size(686, 563);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // DbView
            // 
            this.DbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PathColumn});
            this.DbView.FullRowSelect = true;
            this.DbView.Location = new System.Drawing.Point(3, 12);
            this.DbView.Name = "DbView";
            this.DbView.Size = new System.Drawing.Size(325, 510);
            this.DbView.TabIndex = 0;
            this.DbView.UseCompatibleStateImageBehavior = false;
            this.DbView.View = System.Windows.Forms.View.Details;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 319;
            // 
            // AddButt
            // 
            this.AddButt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButt.Location = new System.Drawing.Point(84, 528);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(163, 23);
            this.AddButt.TabIndex = 1;
            this.AddButt.Text = "Add";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // RemoveButt
            // 
            this.RemoveButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButt.Location = new System.Drawing.Point(3, 528);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(75, 23);
            this.RemoveButt.TabIndex = 2;
            this.RemoveButt.Text = "Remove";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.RemoveButt_Click);
            // 
            // ResetButt
            // 
            this.ResetButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButt.Location = new System.Drawing.Point(253, 528);
            this.ResetButt.Name = "ResetButt";
            this.ResetButt.Size = new System.Drawing.Size(75, 23);
            this.ResetButt.TabIndex = 3;
            this.ResetButt.Text = "Reset";
            this.ResetButt.UseVisualStyleBackColor = true;
            this.ResetButt.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output:";
            // 
            // OutputLab
            // 
            this.OutputLab.AutoSize = true;
            this.OutputLab.Location = new System.Drawing.Point(13, 26);
            this.OutputLab.Name = "OutputLab";
            this.OutputLab.Size = new System.Drawing.Size(10, 13);
            this.OutputLab.TabIndex = 1;
            this.OutputLab.Text = "-";
            // 
            // ChangeButt
            // 
            this.ChangeButt.Location = new System.Drawing.Point(16, 43);
            this.ChangeButt.Name = "ChangeButt";
            this.ChangeButt.Size = new System.Drawing.Size(75, 23);
            this.ChangeButt.TabIndex = 2;
            this.ChangeButt.Text = "Change";
            this.ChangeButt.UseVisualStyleBackColor = true;
            this.ChangeButt.Click += new System.EventHandler(this.ChangeButt_Click);
            // 
            // MergeButt
            // 
            this.MergeButt.Location = new System.Drawing.Point(16, 88);
            this.MergeButt.Name = "MergeButt";
            this.MergeButt.Size = new System.Drawing.Size(75, 23);
            this.MergeButt.TabIndex = 3;
            this.MergeButt.Text = "Merge";
            this.MergeButt.UseVisualStyleBackColor = true;
            this.MergeButt.Click += new System.EventHandler(this.MergeButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 563);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "LiteDb Merger";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView DbView;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.Button ResetButt;
        private System.Windows.Forms.Button RemoveButt;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button MergeButt;
        private System.Windows.Forms.Button ChangeButt;
        private System.Windows.Forms.Label OutputLab;
        private System.Windows.Forms.Label label1;
    }
}

