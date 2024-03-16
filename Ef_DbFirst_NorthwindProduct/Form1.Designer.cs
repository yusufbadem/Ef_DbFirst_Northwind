namespace Ef_DbFirst_NorthwindProduct;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        btnFilter = new Button();
        txtMin = new TextBox();
        txtMax = new TextBox();
        dgvProducts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(64, 57);
        label1.Name = "label1";
        label1.Size = new Size(46, 28);
        label1.TabIndex = 0;
        label1.Text = "Min";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(273, 58);
        label2.Name = "label2";
        label2.Size = new Size(49, 28);
        label2.TabIndex = 1;
        label2.Text = "Max";
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(448, 58);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(94, 29);
        btnFilter.TabIndex = 2;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // txtMin
        // 
        txtMin.Location = new Point(116, 59);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(92, 27);
        txtMin.TabIndex = 3;
        // 
        // txtMax
        // 
        txtMax.Location = new Point(328, 57);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(92, 27);
        txtMax.TabIndex = 4;
        // 
        // dgvProducts
        // 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Location = new Point(12, 132);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.RowHeadersWidth = 51;
        dgvProducts.Size = new Size(776, 297);
        dgvProducts.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dgvProducts);
        Controls.Add(txtMax);
        Controls.Add(txtMin);
        Controls.Add(btnFilter);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Button btnFilter;
    private TextBox txtMin;
    private TextBox txtMax;
    private DataGridView dgvProducts;
}
