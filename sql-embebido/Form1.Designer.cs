
namespace sql_embebido
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.panelControlVentana = new System.Windows.Forms.Panel();
            this.pbMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.pbMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.pbClose = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDashboard = new FontAwesome.Sharp.IconPictureBox();
            this.pbRestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelContenidoSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.curvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transitionSidebarOpen = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionSidebarClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.controlVentana = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelControlVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelContenidoSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlVentana
            // 
            this.panelControlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.panelControlVentana.Controls.Add(this.pbMinimizar);
            this.panelControlVentana.Controls.Add(this.pbMaximizar);
            this.panelControlVentana.Controls.Add(this.pbClose);
            this.panelControlVentana.Controls.Add(this.label1);
            this.panelControlVentana.Controls.Add(this.pbDashboard);
            this.panelControlVentana.Controls.Add(this.pbRestaurar);
            this.transitionSidebarClose.SetDecoration(this.panelControlVentana, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.panelControlVentana, BunifuAnimatorNS.DecorationType.None);
            this.panelControlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlVentana.Location = new System.Drawing.Point(0, 0);
            this.panelControlVentana.Name = "panelControlVentana";
            this.panelControlVentana.Size = new System.Drawing.Size(1080, 50);
            this.panelControlVentana.TabIndex = 0;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.transitionSidebarClose.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.pbMinimizar.IconColor = System.Drawing.Color.White;
            this.pbMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbMinimizar.IconSize = 30;
            this.pbMinimizar.Location = new System.Drawing.Point(966, 14);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pbMinimizar.TabIndex = 5;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.transitionSidebarClose.SetDecoration(this.pbMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.pbMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.pbMaximizar.IconColor = System.Drawing.Color.White;
            this.pbMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbMaximizar.IconSize = 30;
            this.pbMaximizar.Location = new System.Drawing.Point(1002, 14);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(30, 30);
            this.pbMaximizar.TabIndex = 3;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.transitionSidebarClose.SetDecoration(this.pbClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.pbClose, BunifuAnimatorNS.DecorationType.None);
            this.pbClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.pbClose.IconColor = System.Drawing.Color.White;
            this.pbClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbClose.IconSize = 30;
            this.pbClose.Location = new System.Drawing.Point(1038, 14);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transitionSidebarOpen.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // pbDashboard
            // 
            this.pbDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.transitionSidebarClose.SetDecoration(this.pbDashboard, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.pbDashboard, BunifuAnimatorNS.DecorationType.None);
            this.pbDashboard.IconChar = FontAwesome.Sharp.IconChar.List;
            this.pbDashboard.IconColor = System.Drawing.Color.White;
            this.pbDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbDashboard.IconSize = 30;
            this.pbDashboard.Location = new System.Drawing.Point(20, 14);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(30, 30);
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.pbDashboard_Click);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.transitionSidebarClose.SetDecoration(this.pbRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.pbRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.pbRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.pbRestaurar.IconColor = System.Drawing.Color.White;
            this.pbRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbRestaurar.IconSize = 30;
            this.pbRestaurar.Location = new System.Drawing.Point(1002, 14);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(30, 30);
            this.pbRestaurar.TabIndex = 4;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.panelSidebar.Controls.Add(this.panelContenidoSidebar);
            this.transitionSidebarClose.SetDecoration(this.panelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.panelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 50);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 670);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelContenidoSidebar
            // 
            this.panelContenidoSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContenidoSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenidoSidebar.BackgroundImage")));
            this.panelContenidoSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenidoSidebar.Controls.Add(this.btnEliminar);
            this.panelContenidoSidebar.Controls.Add(this.btnActualizar);
            this.panelContenidoSidebar.Controls.Add(this.btnBuscar);
            this.panelContenidoSidebar.Controls.Add(this.btnAgregar);
            this.panelContenidoSidebar.Controls.Add(this.lineaSidebar);
            this.panelContenidoSidebar.Controls.Add(this.label2);
            this.panelContenidoSidebar.Controls.Add(this.pictureBox1);
            this.transitionSidebarClose.SetDecoration(this.panelContenidoSidebar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.panelContenidoSidebar, BunifuAnimatorNS.DecorationType.None);
            this.panelContenidoSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(190)))), ((int)(((byte)(31)))));
            this.panelContenidoSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(190)))), ((int)(((byte)(31)))));
            this.panelContenidoSidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(190)))), ((int)(((byte)(31)))));
            this.panelContenidoSidebar.GradientTopRight = System.Drawing.Color.DarkGreen;
            this.panelContenidoSidebar.Location = new System.Drawing.Point(10, 15);
            this.panelContenidoSidebar.Name = "panelContenidoSidebar";
            this.panelContenidoSidebar.Quality = 10;
            this.panelContenidoSidebar.Size = new System.Drawing.Size(220, 640);
            this.panelContenidoSidebar.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "      Eliminar registro";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionSidebarOpen.SetDecoration(this.btnEliminar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.btnEliminar, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::sql_embebido.Properties.Resources.remove;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 50D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(0, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(220, 50);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "      Eliminar registro";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderRadius = 0;
            this.btnActualizar.ButtonText = "      Actualizar registro";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionSidebarOpen.SetDecoration(this.btnActualizar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.btnActualizar, BunifuAnimatorNS.DecorationType.None);
            this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.Iconimage = global::sql_embebido.Properties.Resources.edit;
            this.btnActualizar.Iconimage_right = null;
            this.btnActualizar.Iconimage_right_Selected = null;
            this.btnActualizar.Iconimage_Selected = null;
            this.btnActualizar.IconMarginLeft = 0;
            this.btnActualizar.IconMarginRight = 0;
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconRightZoom = 0D;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.IconZoom = 50D;
            this.btnActualizar.IsTab = false;
            this.btnActualizar.Location = new System.Drawing.Point(0, 179);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(220, 50);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "      Actualizar registro";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Textcolor = System.Drawing.Color.White;
            this.btnActualizar.TextFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "      Agregar registro";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionSidebarOpen.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::sql_embebido.Properties.Resources.add;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 50D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(0, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(220, 50);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "      Agregar registro";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lineaSidebar
            // 
            this.lineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.transitionSidebarClose.SetDecoration(this.lineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.lineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.lineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineaSidebar.LineThickness = 1;
            this.lineaSidebar.Location = new System.Drawing.Point(10, 60);
            this.lineaSidebar.Name = "lineaSidebar";
            this.lineaSidebar.Size = new System.Drawing.Size(200, 1);
            this.lineaSidebar.TabIndex = 7;
            this.lineaSidebar.Transparency = 255;
            this.lineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.transitionSidebarOpen.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "R-CODE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.transitionSidebarOpen.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::sql_embebido.Properties.Resources.icon_raccoon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelContenido.Controls.Add(this.label3);
            this.transitionSidebarClose.SetDecoration(this.panelContenido, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this.panelContenido, BunifuAnimatorNS.DecorationType.None);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContenido.Location = new System.Drawing.Point(240, 50);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(840, 670);
            this.panelContenido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.transitionSidebarOpen.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(316, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 115);
            this.label3.TabIndex = 6;
            this.label3.Text = "CRUD";
            // 
            // curvaSidebar
            // 
            this.curvaSidebar.ElipseRadius = 7;
            this.curvaSidebar.TargetControl = this.panelContenidoSidebar;
            // 
            // transitionSidebarOpen
            // 
            this.transitionSidebarOpen.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transitionSidebarOpen.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transitionSidebarOpen.DefaultAnimation = animation3;
            // 
            // transitionSidebarClose
            // 
            this.transitionSidebarClose.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transitionSidebarClose.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.transitionSidebarClose.DefaultAnimation = animation4;
            // 
            // controlVentana
            // 
            this.controlVentana.Fixed = true;
            this.controlVentana.Horizontal = true;
            this.controlVentana.TargetControl = this.panelControlVentana;
            this.controlVentana.Vertical = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.ButtonText = "      Buscar registro";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionSidebarOpen.SetDecoration(this.btnBuscar, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarClose.SetDecoration(this.btnBuscar, BunifuAnimatorNS.DecorationType.None);
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = global::sql_embebido.Properties.Resources.search;
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 50D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(0, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(220, 50);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "      Buscar registro";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelControlVentana);
            this.transitionSidebarClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionSidebarOpen.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelControlVentana.ResumeLayout(false);
            this.panelControlVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelContenidoSidebar.ResumeLayout(false);
            this.panelContenidoSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlVentana;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContenido;
        private FontAwesome.Sharp.IconPictureBox pbDashboard;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox pbMinimizar;
        private FontAwesome.Sharp.IconPictureBox pbRestaurar;
        private FontAwesome.Sharp.IconPictureBox pbMaximizar;
        private FontAwesome.Sharp.IconPictureBox pbClose;
        private Bunifu.Framework.UI.BunifuGradientPanel panelContenidoSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator lineaSidebar;
        private Bunifu.Framework.UI.BunifuElipse curvaSidebar;
        private BunifuAnimatorNS.BunifuTransition transitionSidebarClose;
        private BunifuAnimatorNS.BunifuTransition transitionSidebarOpen;
        private Bunifu.Framework.UI.BunifuDragControl controlVentana;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
    }
}

