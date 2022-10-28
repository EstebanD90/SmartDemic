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
    public partial class AyudaForm : Telerik.WinControls.UI.RadForm
    {
        #region Singleton
        public static AyudaForm instancia = null;
        public static AyudaForm instancia_unica()
        {
            if (instancia == null)
            {
                instancia = new AyudaForm();
                return instancia;
            }
            return instancia;
        }


        public AyudaForm()
        {
            InitializeComponent();
        }
        #endregion

        private void AyudaForm_Load(object sender, EventArgs e)
        {

        }

        private void AyudaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }


        //#region Singleton
        //private readonly static AyudaForm _instance = new AyudaForm();

        //public static AyudaForm Current
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}

        //public AyudaForm()
        //{
        //    //Implement here the initialization code
        //}
        //#endregion

    }
}
