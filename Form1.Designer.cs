namespace CopyXOR
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnInput = new System.Windows.Forms.Button();
      this.btnOutput = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.rbEncrypt = new System.Windows.Forms.RadioButton();
      this.rbDecrypt = new System.Windows.Forms.RadioButton();
      this.pbStatus = new System.Windows.Forms.ProgressBar();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnPause = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnInput
      // 
      this.btnInput.Location = new System.Drawing.Point(466, 19);
      this.btnInput.Name = "btnInput";
      this.btnInput.Size = new System.Drawing.Size(75, 23);
      this.btnInput.TabIndex = 0;
      this.btnInput.Text = "Выбрать";
      this.btnInput.UseVisualStyleBackColor = true;
      this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
      // 
      // btnOutput
      // 
      this.btnOutput.Location = new System.Drawing.Point(466, 54);
      this.btnOutput.Name = "btnOutput";
      this.btnOutput.Size = new System.Drawing.Size(75, 23);
      this.btnOutput.TabIndex = 1;
      this.btnOutput.Text = "Выбрать";
      this.btnOutput.UseVisualStyleBackColor = true;
      this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Исходный файл: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(40, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Результат: ";
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(111, 21);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(343, 20);
      this.txtInput.TabIndex = 4;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(111, 57);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(343, 20);
      this.txtOutput.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(54, 94);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Пароль: ";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(111, 90);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(135, 20);
      this.txtPassword.TabIndex = 7;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // rbEncrypt
      // 
      this.rbEncrypt.AutoSize = true;
      this.rbEncrypt.Checked = true;
      this.rbEncrypt.Location = new System.Drawing.Point(256, 92);
      this.rbEncrypt.Name = "rbEncrypt";
      this.rbEncrypt.Size = new System.Drawing.Size(95, 17);
      this.rbEncrypt.TabIndex = 8;
      this.rbEncrypt.TabStop = true;
      this.rbEncrypt.Text = "Зашифровать";
      this.rbEncrypt.UseVisualStyleBackColor = true;
      // 
      // rbDecrypt
      // 
      this.rbDecrypt.AutoSize = true;
      this.rbDecrypt.Location = new System.Drawing.Point(366, 92);
      this.rbDecrypt.Name = "rbDecrypt";
      this.rbDecrypt.Size = new System.Drawing.Size(101, 17);
      this.rbDecrypt.TabIndex = 9;
      this.rbDecrypt.Text = "Расшифровать";
      this.rbDecrypt.UseVisualStyleBackColor = true;
      // 
      // pbStatus
      // 
      this.pbStatus.Location = new System.Drawing.Point(15, 140);
      this.pbStatus.Name = "pbStatus";
      this.pbStatus.Size = new System.Drawing.Size(526, 23);
      this.pbStatus.TabIndex = 10;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(146, 183);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 11;
      this.btnStart.Text = "Старт";
      this.btnStart.UseVisualStyleBackColor = true;
      // 
      // btnPause
      // 
      this.btnPause.Location = new System.Drawing.Point(243, 183);
      this.btnPause.Name = "btnPause";
      this.btnPause.Size = new System.Drawing.Size(75, 23);
      this.btnPause.TabIndex = 12;
      this.btnPause.Text = "Пауза";
      this.btnPause.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(345, 183);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 232);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnPause);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.pbStatus);
      this.Controls.Add(this.rbDecrypt);
      this.Controls.Add(this.rbEncrypt);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOutput);
      this.Controls.Add(this.btnInput);
      this.Name = "Form1";
      this.Text = "Программа для шифрования файлов";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnInput;
    private System.Windows.Forms.Button btnOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.RadioButton rbEncrypt;
    private System.Windows.Forms.RadioButton rbDecrypt;
    private System.Windows.Forms.ProgressBar pbStatus;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnPause;
    private System.Windows.Forms.Button btnCancel;
  }
}

