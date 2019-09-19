namespace PresentationLayerWinform
{
    partial class CrearEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.practico_EntregableDataSet1 = new PresentationLayerWinform.Practico_EntregableDataSet1();
            this.employeesTPHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTPHTableAdapter = new PresentationLayerWinform.Practico_EntregableDataSet1TableAdapters.EmployeesTPHTableAdapter();
            this.Rate = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.practico_EntregableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTPHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(239, 98);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(247, 22);
            this.Name.TabIndex = 1;
            this.Name.Text = "Insert Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hourly Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // practico_EntregableDataSet1
            // 
            this.practico_EntregableDataSet1.DataSetName = "Practico_EntregableDataSet1";
            this.practico_EntregableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTPHBindingSource
            // 
            this.employeesTPHBindingSource.DataMember = "EmployeesTPH";
            this.employeesTPHBindingSource.DataSource = this.practico_EntregableDataSet1;
            // 
            // employeesTPHTableAdapter
            // 
            this.employeesTPHTableAdapter.ClearBeforeFill = true;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(239, 268);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 22);
            this.Rate.TabIndex = 13;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(239, 316);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(100, 22);
            this.Salary.TabIndex = 14;
            // 
            // CrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Text = "CrearEmpleado";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CrearEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.practico_EntregableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTPHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Practico_EntregableDataSet1 practico_EntregableDataSet1;
        private System.Windows.Forms.BindingSource employeesTPHBindingSource;
        private Practico_EntregableDataSet1TableAdapters.EmployeesTPHTableAdapter employeesTPHTableAdapter;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.TextBox Salary;
    }
}