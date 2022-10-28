using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic.Gestion_Inventario
{
    public partial class InventarioForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static InventarioForm instancia = null;
        public static InventarioForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new InventarioForm();
                return instancia;
            }
            return instancia;
        }

        public InventarioForm()
        {
            InitializeComponent();
        }
        #endregion

        private void InventarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
