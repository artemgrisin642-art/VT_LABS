namespace LAB05;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblNumber1 = new Label();
        txtNumber1 = new TextBox();
        lblNumber2 = new Label();
        txtNumber2 = new TextBox();
        btnAdd = new Button();
        btnSub = new Button();
        btnMul = new Button();
        btnDiv = new Button();
        btnClear = new Button();
        lblResult = new Label();
        lblResultValue = new Label();
        SuspendLayout();
        // 
        // lblNumber1
        // 
        lblNumber1.AutoSize = true;
        lblNumber1.Font = new Font("Segoe UI", 11F);
        lblNumber1.Location = new Point(44, 41);
        lblNumber1.Name = "lblNumber1";
        lblNumber1.Size = new Size(82, 25);
        lblNumber1.TabIndex = 0;
        lblNumber1.Text = "Число 1:";
        // 
        // txtNumber1
        // 
        txtNumber1.Font = new Font("Segoe UI", 11F);
        txtNumber1.Location = new Point(161, 38);
        txtNumber1.Name = "txtNumber1";
        txtNumber1.Size = new Size(237, 32);
        txtNumber1.TabIndex = 1;
        // 
        // lblNumber2
        // 
        lblNumber2.AutoSize = true;
        lblNumber2.Font = new Font("Segoe UI", 11F);
        lblNumber2.Location = new Point(44, 91);
        lblNumber2.Name = "lblNumber2";
        lblNumber2.Size = new Size(82, 25);
        lblNumber2.TabIndex = 2;
        lblNumber2.Text = "Число 2:";
        // 
        // txtNumber2
        // 
        txtNumber2.Font = new Font("Segoe UI", 11F);
        txtNumber2.Location = new Point(161, 88);
        txtNumber2.Name = "txtNumber2";
        txtNumber2.Size = new Size(237, 32);
        txtNumber2.TabIndex = 3;
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnAdd.Location = new Point(83, 147);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(66, 43);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnSub
        // 
        btnSub.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSub.Location = new Point(166, 147);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(66, 43);
        btnSub.TabIndex = 5;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = true;
        btnSub.Click += btnSub_Click;
        // 
        // btnMul
        // 
        btnMul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnMul.Location = new Point(249, 147);
        btnMul.Name = "btnMul";
        btnMul.Size = new Size(66, 43);
        btnMul.TabIndex = 6;
        btnMul.Text = "*";
        btnMul.UseVisualStyleBackColor = true;
        btnMul.Click += btnMul_Click;
        // 
        // btnDiv
        // 
        btnDiv.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnDiv.Location = new Point(332, 147);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(66, 43);
        btnDiv.TabIndex = 7;
        btnDiv.Text = "/";
        btnDiv.UseVisualStyleBackColor = true;
        btnDiv.Click += btnDiv_Click;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Segoe UI", 10F);
        btnClear.Location = new Point(143, 206);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(191, 41);
        btnClear.TabIndex = 8;
        btnClear.Text = "Очистить";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // lblResult
        // 
        lblResult.AutoSize = true;
        lblResult.Font = new Font("Segoe UI", 12F);
        lblResult.Location = new Point(44, 279);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(109, 28);
        lblResult.TabIndex = 9;
        lblResult.Text = "Результат:";
        // 
        // lblResultValue
        // 
        lblResultValue.AutoSize = true;
        lblResultValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblResultValue.Location = new Point(180, 276);
        lblResultValue.Name = "lblResultValue";
        lblResultValue.Size = new Size(0, 32);
        lblResultValue.TabIndex = 10;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(467, 353);
        Controls.Add(lblResultValue);
        Controls.Add(lblResult);
        Controls.Add(btnClear);
        Controls.Add(btnDiv);
        Controls.Add(btnMul);
        Controls.Add(btnSub);
        Controls.Add(btnAdd);
        Controls.Add(txtNumber2);
        Controls.Add(lblNumber2);
        Controls.Add(txtNumber1);
        Controls.Add(lblNumber1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Калькулятор V1.0";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNumber1;
    private TextBox txtNumber1;
    private Label lblNumber2;
    private TextBox txtNumber2;
    private Button btnAdd;
    private Button btnSub;
    private Button btnMul;
    private Button btnDiv;
    private Button btnClear;
    private Label lblResult;
    private Label lblResultValue;
}
