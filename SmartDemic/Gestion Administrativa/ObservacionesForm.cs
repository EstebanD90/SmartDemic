using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDemic
{
    public partial class ObservacionesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ObservacionesForm instancia = null;
        public static ObservacionesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ObservacionesForm();
                return instancia;
            }
            return instancia;
        }

        public ObservacionesForm()
        {
            InitializeComponent();
        }

        #endregion

        private void ObservacionesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
