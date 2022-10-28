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
    public partial class ExamenesForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ExamenesForm instancia = null;
        public static ExamenesForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ExamenesForm();
                return instancia;
            }
            return instancia;
        }
        public ExamenesForm()
        {
            InitializeComponent();
        }
        #endregion

        private void ExamenesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
