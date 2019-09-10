using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
   public class Geral
    {
        public static bool Resposta;

        /// <summary>
        /// Função para exibir mensagem personalizada de erro na tela
        /// </summary>
        /// <param name="Msg"></param>
        public static void Erro(string Msg)
        {
            Formularios.FrmErro erro = new Formularios.FrmErro();
            erro.LblMensagem.Text = Msg;
            erro.ShowDialog();
        }

        public static void Ok(string Msg)
        {
            Formularios.FrmOk ok = new Formularios.FrmOk();
            ok.LblMensagem.Text = Msg;
            ok.ShowDialog();
        }

        public static void Pergunta(string Msg)
        {
            Resposta = false;

            Formularios.FrmPergunta pergunta = new Formularios.FrmPergunta();
            pergunta.LblMensagem.Text = Msg;
            pergunta.ShowDialog();
        }

        public static bool ValidaCampos(Panel Grupo, ErrorProvider erro)
        {
            erro.Clear();

            foreach (Control item in Grupo.Controls)
            {
                if(item.Tag!=null && item.Tag.ToString() != "")
                {
                    if(item.Text.Trim() == "")
                    { 
                    Erro("O campo " + item.Tag.ToString() + " é obrigatório!");
                    item.Focus();
                    erro.SetError(item, "Obrigatório");
                    return true;
                    }
                    
                    //Validar tamanho do CPF
                    if(item.Tag.ToString().ToUpper().Contains("CPF") && item.Text.Length != 14)
                    {
                        Erro("CPF incompleto!");
                        item.Focus();
                        erro.SetError(item, "O CPF deve conter 11 dígitos!");
                        return true;
                    }

                    //Validar tamanho do CNPJ
                    if (item.Tag.ToString().ToUpper().Contains("CNPJ") && item.Text.Length != 18)
                    {
                        Erro("CNPJ incompleto!");
                        item.Focus();
                        erro.SetError(item, "O CNPJ deve conter 14 dígitos!");
                        return true;
                    }

                    //Validar tamanho do CEP
                    if (item.Tag.ToString().ToUpper().Contains("CEP") && item.Text.Length != 10)
                    {
                        Erro("CEP incompleto!");
                        item.Focus();
                        erro.SetError(item, "O CEP deve conter 8 dígitos!");
                        return true;
                    }

                    //Validar tamanho do TELEFONE CELULAR
                    if (item.Tag.ToString().ToUpper().Contains("CELULAR") && item.Text.Length != 16)
                    {
                        Erro("Número de celular incompleto!");
                        item.Focus();
                        erro.SetError(item, "O númro do celular deve conter 11 dígitos!");
                        return true;
                    }

                    //Validar tamanho do TELEFONE FIXO
                    if (item.Tag.ToString().ToUpper().Contains("FONEFIXO") && item.Text.Length != 16)
                    {
                        Erro("Número do telefone incompleto!");
                        item.Focus();
                        erro.SetError(item, "O número do telefone fixo deve conter 10 dígitos!");
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
