using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic.Configuracion
{
    public partial class adminFamiliasPatentesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static adminFamiliasPatentesForm instancia = null;
        public static adminFamiliasPatentesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new adminFamiliasPatentesForm();
                return instancia;
            }
            return instancia;
        }
        public adminFamiliasPatentesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void adminFamiliasPatentesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
