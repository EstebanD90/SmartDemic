using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic.Gestion_Reportes
{
    public partial class ReportesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ReportesForm instancia = null;
        public static ReportesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ReportesForm();
                return instancia;
            }
            return instancia;
        }
        public ReportesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void ReportesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
