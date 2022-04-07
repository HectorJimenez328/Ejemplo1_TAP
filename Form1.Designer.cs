
namespace TAPU2_Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCrearControl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCrearCajas = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TrackBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearControl
            // 
            this.btnCrearControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearControl.Location = new System.Drawing.Point(12, 12);
            this.btnCrearControl.Name = "btnCrearControl";
            this.btnCrearControl.Size = new System.Drawing.Size(159, 95);
            this.btnCrearControl.TabIndex = 0;
            this.btnCrearControl.Text = "Crear control";
            this.btnCrearControl.UseVisualStyleBackColor = true;
            this.btnCrearControl.Click += new System.EventHandler(this.btnCrearControl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCrearCajas
            // 
            this.btnCrearCajas.Location = new System.Drawing.Point(12, 317);
            this.btnCrearCajas.Name = "btnCrearCajas";
            this.btnCrearCajas.Size = new System.Drawing.Size(159, 95);
            this.btnCrearCajas.TabIndex = 2;
            this.btnCrearCajas.Tag = "hola";
            this.btnCrearCajas.Text = "Crear cajas";
            this.btnCrearCajas.UseVisualStyleBackColor = true;
            this.btnCrearCajas.Click += new System.EventHandler(this.btnCrearCajas_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(12, 418);
            this.tbCantidad.Maximum = 15;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(159, 56);
            this.tbCantidad.TabIndex = 3;
            this.tbCantidad.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbCantidad.Scroll += new System.EventHandler(this.tbCantidad_Scroll);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("IBM Plex Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(166, 436);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 20);
            this.lblCantidad.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(324, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnCrearCajas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecución.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCrearCajas;
        private System.Windows.Forms.TrackBar tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

