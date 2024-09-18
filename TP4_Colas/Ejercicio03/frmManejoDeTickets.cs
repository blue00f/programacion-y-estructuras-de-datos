using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace Ejercicio03
{
    public partial class frmManejoDeTickets : Form
    {
        Cola colaInicial, colaConTickets, colaSinTickets, colaFinal;
        Cola colaInicialAux, colaConTicketsAux, colaSinTicketsAux, colaFinalAux;
        public frmManejoDeTickets()
        {
            InitializeComponent();
        }

        private void Mostrar(Cola colaO, Cola colaA, ListBox pList)
        {
            pList.Items.Clear();
            if (colaO.Ver() != null)
            {
                MostrarNombreRecursiva(colaO.Desencolar(), colaO, colaA, pList);
                RearmarColaOriginalRecursiva(colaA.Desencolar(), colaO, colaA);
            }
        }

        private void RearmarColaOriginalRecursiva(Cliente pCliente, Cola colaO, Cola colaA)
        {
            if (pCliente != null)
            {
                colaO.Encolar(pCliente.Nombre, pCliente.TicketDelCliente);
                RearmarColaOriginalRecursiva(colaA.Desencolar(), colaO, colaA);
            }
        }
        private void MostrarNombreRecursiva(Cliente? pCliente, Cola colaO, Cola colaA, ListBox pList)
        {
            if (pCliente != null)
            {
                pList.Items.Add($"{pCliente.Nombre} - {pCliente.TicketDelCliente} ticket");
                colaA.Encolar(pCliente.Nombre, pCliente.TicketDelCliente);
                MostrarNombreRecursiva(colaO.Desencolar(), colaO, colaA, pList);
            }
        }


        private void frmManejoDeTickets_Load(object sender, EventArgs e)
        {
            lstColaInicial.Items.Clear();
            colaInicial = new Cola();
            colaConTickets = new Cola();
            colaSinTickets = new Cola();
            colaFinal = new Cola();

            colaInicialAux = new Cola();
            colaConTicketsAux = new Cola();
            colaSinTicketsAux = new Cola();
            colaFinalAux = new Cola();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            colaInicial.Encolar(
                Interaction.InputBox("Nombre: "),
                MessageBox.Show("Tiene ticket?", "Pregunta importante!", MessageBoxButtons.YesNo) == DialogResult.Yes ? Cliente.Ticket.Tiene : Cliente.Ticket.NoTiene
            );
            Mostrar(colaInicial, colaInicialAux, lstColaInicial);
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                if (colaInicial.Ver() == null) throw new Exception("No hay clientes para desencolar!");
                Cliente clienteEliminado = colaInicial.Desencolar();

                if (clienteEliminado.TicketDelCliente == Cliente.Ticket.Tiene)
                {
                    colaConTickets.Encolar(clienteEliminado.Nombre, clienteEliminado.TicketDelCliente);
                    Mostrar(colaConTickets, colaConTicketsAux, lstTienenTickets);
                }
                else
                {
                    colaSinTickets.Encolar(clienteEliminado.Nombre, clienteEliminado.TicketDelCliente);
                    Mostrar(colaSinTickets, colaSinTicketsAux, lstNoTienenTickets);
                }
                Mostrar(colaInicial, colaInicialAux, lstColaInicial);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarNuevaCola_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (colaSinTickets.Ver() == null && colaConTickets.Ver() == null) throw new Exception("No hay más clientes!");

                if (colaConTickets.Ver() != null)
                {
                    Cliente clienteAMoverConTicket = colaConTickets.Desencolar();
                    colaFinal.Encolar(clienteAMoverConTicket.Nombre, clienteAMoverConTicket.TicketDelCliente);
                    Mostrar(colaConTickets, colaConTicketsAux, lstTienenTickets);
                }
                
                else if(colaConTickets.Ver() == null && colaSinTickets.Ver() != null)
                {
                    Cliente clienteAMoverSinTicket = colaSinTickets.Desencolar();
                    colaFinal.Encolar(clienteAMoverSinTicket.Nombre, clienteAMoverSinTicket.TicketDelCliente);
                    Mostrar(colaSinTickets, colaSinTicketsAux, lstNoTienenTickets);
                }
                Mostrar(colaFinal, colaFinalAux, lstColaFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
