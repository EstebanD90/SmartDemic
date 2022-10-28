using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic.Gestion_Docente
{
    public partial class AsistenciasForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static AsistenciasForm instancia = null;
        public static AsistenciasForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new AsistenciasForm();
                return instancia;
            }
            return instancia;
        }
        public AsistenciasForm()
        {
            InitializeComponent();
        }
        #endregion

        private void AsistenciasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
