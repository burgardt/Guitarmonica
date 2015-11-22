using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmonicaAGuitarra
{
    public partial class frmPrincipal : Form
    {

        string cancionArmonica;
        string[] tabs;
        int[] posCuerdas;
        int posNota;

        /////////////////////////////////////////////////////////////////////////////////////////////////////        
        public frmPrincipal()
        {
            InitializeComponent();
            iniciarTab();
        }

        private void iniciarTab()
        {
            // Inicio los valores
            tabs = new string[] { "e-", "B-", "G-", "D-", "A-", "E-" };
            posCuerdas = new int[] { 2, 2, 2, 2, 2, 2 };
            lblTab.Text = "e-\nB-\nG-\nD-\nA-\nE-";
            posNota = 2;
            
        }

        // Escribe en una cuerda una nota, poniendo guiones y eso automáticamente.
        private void escribirNota(int nroCuerda, int nota)
        {

            tabs[nroCuerda] = tabs[nroCuerda] + nota;
            
            if (posNota != 2) // CON ESTE IF SE ARREGLA UN ERROR DE ESTÉTICA, SI SURGE ALGÚN PROBLEMA PUEDE QUE ESTÉ EN ESTA PARTE (PROBAR DEJARLO COMO ANTES).
            {
                if (nota < 10)
                {
                    tabs[nroCuerda] = tabs[nroCuerda] + "-";
                    posCuerdas[nroCuerda] = posCuerdas[nroCuerda] + 2; //+2 porque pone nota y un guion
                    posNota = posNota + 2;
                }
                else
                {
                    tabs[nroCuerda] = tabs[nroCuerda] + "-";
                    posCuerdas[nroCuerda] = posCuerdas[nroCuerda] + 3; //+3 porque pone nota (q vale 2) y un guion
                    posNota = posNota + 3;
                }
            }
            else 
            {
                posCuerdas[nroCuerda] = posCuerdas[nroCuerda] + 1;
                posNota = posNota + 1;
            }
            

            // Acá se ponen los guiones
            for (int i = 0; i<=5; i++)
            {
                while (posCuerdas[i] <= posNota)
                { 
                    tabs[i] = tabs[i] + "-";
                    posCuerdas[i] = posCuerdas[i] + 1;
                }
            }
          
        }


        private void traducir(int nivel)
        {
            // Reinicio los valores
            iniciarTab();

            // Separadores de la cadena
            string[] separadores = new string[] {" "};
            // Quito los espacios de mas
            string auxCad = cancionArmonica.Trim(); 

            for (int i = 1; i <= 10; i++)
            { 
                // Cambio los menos por parentesis
                auxCad = auxCad.Replace("-"+i, "("+i+")");

                // Agrego un espacio separador        
                auxCad = auxCad.Replace(i + ")", i+") ");
                auxCad = auxCad.Replace(i + "(", i + " (");

                auxCad = auxCad.Replace(i + "" + i, i + " " + i);
                for (int j = 1; j <= 10; j++)
                {
                    // Aca pongo un espacio entre medio de dos nros
                    auxCad = auxCad.Replace(i + "" + j, i + " " + j);
                    //auxCad = auxCad.Replace(j + "" + i, j + " " + i);
                    
                }


            }

            // En los nros > a 19 se desincroniza todo!
            // HACER MULTILINEA FUNCIONAL Y ARREGLAR ERROR DE LOS GUIONES



            foreach (string e in (auxCad.Split(separadores, System.StringSplitOptions.RemoveEmptyEntries)))
            {
                
                switch (e)
                {
                    case "10":
                        if (nivel==1)
                            escribirNota(0, 8);
                        if (nivel==2)
                            escribirNota(0, 20);
                        break;
                    case "(10)":
                        if (nivel==1)
                            escribirNota(0, 5);
                        if (nivel == 2)
                            escribirNota(0, 17);
                        break;
                    case "9":
                        if (nivel==1)
                            escribirNota(0, 3);
                        if (nivel == 2)
                            escribirNota(0, 15);
                        break;
                    case "(9)":
                        if (nivel==1)
                            escribirNota(0, 1);
                        if (nivel == 2)
                            escribirNota(0, 13);
                        break;
                    case "8":
                        if (nivel==1)
                            escribirNota(0, 0);
                        if (nivel == 2)
                            escribirNota(0, 12);
                        break;
                    case "(8)":
                        if (nivel==1)
                            escribirNota(1, 3);
                        if (nivel == 2)
                            escribirNota(0, 10);
                        break;
                    case "7":
                        if (nivel==1)
                            escribirNota(1, 1);
                        if (nivel == 2)
                            escribirNota(0, 8);
                        break;
                    case "(7)":
                        if (nivel==1)
                            escribirNota(1, 0);
                        if (nivel == 2)
                            escribirNota(0, 7);
                        break;
                    case "6":
                        if (nivel==1)
                            escribirNota(2, 0);
                        if (nivel == 2)
                            escribirNota(0, 3);
                        break;
                    case "(6)":
                        if (nivel==1)
                            escribirNota(2, 2);
                        if (nivel == 2)
                            escribirNota(0, 5);
                        break;
                    case "5":
                        if (nivel==1)
                            escribirNota(3, 2);
                        if (nivel == 2)
                            escribirNota(0, 0);
                        break;
                    case "(5)":
                        if (nivel==1)
                            escribirNota(3, 3);
                        if (nivel == 2)
                            escribirNota(0, 1);
                        break;
                    case "4":
                        if (nivel==1)
                            escribirNota(4, 3);
                        if (nivel == 2)
                            escribirNota(1, 1);
                        break;
                    case "(4)":
                        if (nivel==1)
                            escribirNota(4, 5);
                        if (nivel == 2)
                            escribirNota(1, 3);
                        break;
                    case "3":
                        if (nivel==1)
                            escribirNota(5, 3);
                        if (nivel == 2)
                            escribirNota(2, 0);
                        break;
                    case "(3)":
                        if (nivel==1)
                            escribirNota(5, 7);
                        if (nivel == 2)
                            escribirNota(1, 0);
                        break;
                    case "2":
                        if (nivel == 2)
                            escribirNota(3, 2);
                        break;
                    case "(2)":
                        if (nivel == 2)
                            escribirNota(3, 5);
                        break;
                    case "1":
                        if (nivel == 2)
                            escribirNota(4, 3);
                        break;
                    case "(1)":
                        if (nivel == 2)
                            escribirNota(4, 5);
                        break;
                    default:
                        if (e != "")
                            MessageBox.Show("Esta parte esta mal escrita: " + e);
                        break;
                }
            }

            // Transpaso el array de la tab al label
            lblTab.Text = tabs[0] + "\n" + tabs[1] + "\n" + tabs[2] + "\n" + tabs[3] + "\n" + tabs[4] + "\n" + tabs[5];

            
        }

       
        private void btnNivel2_Click(object sender, EventArgs e)
        {
            cancionArmonica = txtArmoAcord.Text;
            traducir(2);//Lo llamo a nivel 2, mas agudo
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            cancionArmonica = txtArmoAcord.Text;
            traducir(1);//Lo llamo a nivel 1, mas grave
        }

    }
}
