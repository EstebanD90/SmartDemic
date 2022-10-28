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
    public partial class DocentesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static DocentesForm instancia = null;
        public static DocentesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new DocentesForm();
                return instancia;
            }
            return instancia;
        }
        public DocentesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void DocentesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
