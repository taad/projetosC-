using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_ValterTadeuCostaSouza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text != "" && txtAltura.Text != "" && txtPeso.Text !="")
            {
                listBox1.Items.Add(txtIdade.Text);
                listBox2.Items.Add(txtAltura.Text);
                listBox3.Items.Add(txtPeso.Text);
                txtAltura.Clear();
                txtPeso.Clear();
                txtIdade.Clear();
            }
            else
            {
                MessageBox.Show("Insira os dados");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIdade.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            lbMaiorAltura.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double maior_altura = 0;
            double menor_altura = 0;
            int peso = 0;
            int mediapeso = 0;
            int somaidade = 0;
            int idade = 0;

            int somaidade2 = 0;
            int idade2 = 0;
            int idade3 = 0;
            maior_altura = Convert.ToDouble(listBox2.Items[0]);
            menor_altura = Convert.ToDouble(listBox2.Items[0]);
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                double aux = 0;

                aux = Convert.ToDouble(listBox2.Items[i]);
                if (aux > maior_altura)
                {
                    maior_altura = aux;



                }
                else if (aux < maior_altura)
                {
                    menor_altura = aux;
                }


            }


            lbMaiorAltura.Text = " A maior altura é de : " + maior_altura;



            

            for (int i = 0; i < listBox1.Items.Count; i++)

            {
                
                idade = Convert.ToInt32(listBox1.Items[i]);
                if (idade < 35)
                {
                    somaidade = somaidade + 1;
                }
            }

            lbIdade.Text = " A quantidade de alunos com idade inferior a 35 é de : " + somaidade;

           
            idade3 = Convert.ToInt32(listBox1.Items[0]);

            for (int i = 0; i < listBox1.Items.Count; i++)

            {
                
                idade2 = Convert.ToInt32(listBox1.Items[i]);
                
                if ((idade2 >= 20)&&(idade2 <=30)) 
                {
                    somaidade2 = somaidade2 + 1;
                }
            }

            lbIdade2.Text = "Numero de aluno entre 20 e 30 anos é de " + somaidade2;

           
            
            for (int i = 0; i < listBox3.Items.Count; i++)

            {
                peso = Convert.ToInt32(listBox3.Items[i]);
               
                if ((idade2 >= 20) && (idade2 <= 30)) 
                {
                    
                    peso = peso + peso;
                }

            }

            if(somaidade2!= 0)
            {
                mediapeso = peso / somaidade2;
            }
            




            lbMedia.Text = "Media de Peso com idade entre 20 e 30 anos é de  " + mediapeso;


        }
    }
    }

