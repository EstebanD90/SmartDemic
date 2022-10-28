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
    public partial class ActividadesExternasForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static ActividadesExternasForm instancia = null;
        public static ActividadesExternasForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new ActividadesExternasForm();
                return instancia;
            }
            return instancia;
        }

        public ActividadesExternasForm()
        {
            InitializeComponent();
        }
        #endregion



        private void ActividadesExternasForm_Load(object sender, EventArgs e)
        {

        }

        private void ActividadesExternasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
