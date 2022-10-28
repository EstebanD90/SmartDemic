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
    public partial class CalificacionesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static CalificacionesForm instancia = null;
        public static CalificacionesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new CalificacionesForm();
                return instancia;
            }
            return instancia;
        }
        public CalificacionesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void CalificacionesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
