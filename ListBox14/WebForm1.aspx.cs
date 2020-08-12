﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Seleccionar sencilla
            //Verificamos que se tenga seleccionado un elemento
            //if(lbFrutas.SelectedItem != null)
            //{
            //    int indice      = lbFrutas.SelectedIndex;
            //    string elemento = lbFrutas.SelectedItem.Text;
            //    string valor    = lbFrutas.SelectedItem.Value;

            //    Response.Write("Seleccionaste: " + elemento + " que tiene el valor " + valor + " en el indice " + indice);
            //}



            //Selección Multiple
            //Recorremos la  lista de elementos
            foreach (ListItem fruta in lbFrutas.Items)
            {
                //Verificamos si el elemnto esta seleccionado
                if (fruta.Selected)
                {
                    int indice      = lbFrutas.Items.IndexOf(fruta);
                    string elemento = fruta.Text;
                    string valor    = fruta.Value;

                    Response.Write("Seleccionaste: " + elemento + " que tiene el valor " + valor + " en el indice " + indice);
                    Response.Write("<br>");

                }
            }
        }
    }
} 