using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic.Gestion_Modulos
{
    public partial class ModulosForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ModulosForm instancia = null;
        public static ModulosForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ModulosForm();
                return instancia;
            }
            return instancia;
        }
        public ModulosForm()
        {
            InitializeComponent();
        }
        #endregion

        private void ModulosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
