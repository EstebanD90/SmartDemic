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
    public partial class ReunionesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ReunionesForm instancia = null;
        public static ReunionesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ReunionesForm();
                return instancia;
            }
            return instancia;
        }
        public ReunionesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void ReunionesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
