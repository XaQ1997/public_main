namespace KsaweryWawrzyniakLab3Zadanie
{
    partial class FormRecords
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new KsaweryWawrzyniakLab3Zadanie.masterDataSet();
            this.chessRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chessRecordsTableAdapter = new KsaweryWawrzyniakLab3Zadanie.masterDataSetTableAdapters.ChessRecordsTableAdapter();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whitePlayerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackPlayerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.whitePlayerNameDataGridViewTextBoxColumn,
            this.blackPlayerNameDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn,
            this.movesCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chessRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chessRecordsBindingSource
            // 
            this.chessRecordsBindingSource.DataMember = "ChessRecords";
            this.chessRecordsBindingSource.DataSource = this.masterDataSet;
            // 
            // chessRecordsTableAdapter
            // 
            this.chessRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // whitePlayerNameDataGridViewTextBoxColumn
            // 
            this.whitePlayerNameDataGridViewTextBoxColumn.DataPropertyName = "WhitePlayerName";
            this.whitePlayerNameDataGridViewTextBoxColumn.HeaderText = "WhitePlayerName";
            this.whitePlayerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whitePlayerNameDataGridViewTextBoxColumn.Name = "whitePlayerNameDataGridViewTextBoxColumn";
            this.whitePlayerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // blackPlayerNameDataGridViewTextBoxColumn
            // 
            this.blackPlayerNameDataGridViewTextBoxColumn.DataPropertyName = "BlackPlayerName";
            this.blackPlayerNameDataGridViewTextBoxColumn.HeaderText = "BlackPlayerName";
            this.blackPlayerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blackPlayerNameDataGridViewTextBoxColumn.Name = "blackPlayerNameDataGridViewTextBoxColumn";
            this.blackPlayerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            this.winnerDataGridViewTextBoxColumn.Width = 125;
            // 
            // movesCountDataGridViewTextBoxColumn
            // 
            this.movesCountDataGridViewTextBoxColumn.DataPropertyName = "MovesCount";
            this.movesCountDataGridViewTextBoxColumn.HeaderText = "MovesCount";
            this.movesCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movesCountDataGridViewTextBoxColumn.Name = "movesCountDataGridViewTextBoxColumn";
            this.movesCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRecords";
            this.Text = "FormRecords";
            this.Load += new System.EventHandler(this.FormRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource chessRecordsBindingSource;
        private masterDataSetTableAdapters.ChessRecordsTableAdapter chessRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whitePlayerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blackPlayerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movesCountDataGridViewTextBoxColumn;
    }
}