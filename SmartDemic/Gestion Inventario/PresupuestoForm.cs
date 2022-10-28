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
    public partial class PresupuestoForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static PresupuestoForm instancia = null;
        public static PresupuestoForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new PresupuestoForm();
                return instancia;
            }
            return instancia;
        }

        public PresupuestoForm()
        {
            InitializeComponent();
        }
        #endregion

        private void PresupuestoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
