namespace Ejercicio04
{
    public partial class frmCajero : Form
    {
        int cantCaja1 = 0, cantCaja2 = 0, cantCaja3 = 0;
        double monto1 = 0, monto2 = 0, monto3 = 0;
        Cola cola1, cola2, cola3;

        public frmCajero()
        {
            InitializeComponent();
        }

        private void frmCajero_Load(object sender, EventArgs e)
        {
            cola1 = new Cola();
            cola2 = new Cola();
            cola3 = new Cola();
        }

        private void MostrarEstadoDeLaCaja(ref int pCantCaja, Label pLblCantClientes)
        {
            pCantCaja = pCantCaja + 1;
            pLblCantClientes.Text = $"Clientes en cola {pCantCaja}";
        }

        private void BalancearClientesCuandoCierranDosCajas(Cola pColaCerrada, Cola pColaAComparar1, Cola pColaAComparar2)
        {
            BalancearClientesCuandoCierranDosCajasRecursiva(pColaCerrada, pColaAComparar1, pColaAComparar2);
        }

        private void BalancearClientesCuandoCierranDosCajasRecursiva(Cola pSegundaColaACerrar, Cola pColaCerrada, Cola pColaAComparar2)
        {
            if (pColaCerrada.Ver() != null)
            {
                Cliente clienteEliminado = pColaCerrada.Desencolar();
                if (btnAbrir1.Enabled == false)
                {
                    cola1.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja1, lblCantClientes1);
                }
                else if (btnAbrir2.Enabled == false)
                {
                    cola2.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja2, lblCantClientes2);
                }
                else if (btnAbrir3.Enabled == false)
                {
                    cola3.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja3, lblCantClientes3);
                }
                BalancearClientesCuandoCierranDosCajasRecursiva(pSegundaColaACerrar, pColaCerrada, pColaAComparar2);
            }
        }

        private void BalancearClientesCuandoCierraUnaCaja(Cola pColaCerrada)
        {
            BalancearClientesCuandoCierraUnaCajaRecursiva(pColaCerrada, ref cantCaja1, ref cantCaja2, ref cantCaja3);

        }
        private void BalancearClientesCuandoCierraUnaCajaRecursiva(Cola pColaCerrada, ref int pCantCaja1, ref int pCantCaja2, ref int pCantCaja3)
        {
            if (pColaCerrada.Ver() != null)
            {
                Cliente clienteEliminado = pColaCerrada.Desencolar();

                if (btnAbrir1.Enabled == false && (cantCaja1 <= cantCaja2 && cantCaja1 <= cantCaja3))
                {
                    cola1.Encolar();
                    MostrarEstadoDeLaCaja(ref pCantCaja1, lblCantClientes1);
                }
                else if (btnAbrir2.Enabled == false && (cantCaja2 <= cantCaja1 && cantCaja2 <= cantCaja3))
                {
                    cola2.Encolar();
                    MostrarEstadoDeLaCaja(ref pCantCaja2, lblCantClientes2);
                }
                else if (btnAbrir3.Enabled == false && (cantCaja3 <= cantCaja1 && cantCaja3 <= cantCaja2))
                {
                    cola3.Encolar();
                    MostrarEstadoDeLaCaja(ref pCantCaja3, lblCantClientes3);
                }

                BalancearClientesCuandoCierraUnaCajaRecursiva(pColaCerrada, ref pCantCaja1, ref pCantCaja2, ref pCantCaja3);
            }
        }


        // Funciones de servicio para encolar clientes teniendo en cuenta si las cajas estan cerradas
        private void BalancearCajas()
        {
            if ((cantCaja1 == cantCaja2) && (cantCaja1 == cantCaja3))
            {
                cola1.Encolar();
                MostrarEstadoDeLaCaja(ref cantCaja1, lblCantClientes1);
            }


            // PRIMERA COMBINACION: CUANDO CAJA 1 ES MAYOR
            else if ((cantCaja1 >= cantCaja2) && (cantCaja1 >= cantCaja3))
            {
                if (cantCaja3 >= cantCaja2)
                {
                    cola2.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja2, lblCantClientes2);
                }
                else
                {
                    cola3.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja3, lblCantClientes3);
                }
            }

            // SEGUNDA COMBINACION: CUANDO CAJA 2 ES MAYOR
            else if ((cantCaja2 >= cantCaja1) && (cantCaja2 >= cantCaja3))
            {
                if (cantCaja3 >= cantCaja1)
                {
                    cola1.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja1, lblCantClientes1);
                }
                else
                {
                    cola3.Encolar();
                    cantCaja3 = cantCaja3 + 1;
                    MostrarEstadoDeLaCaja(ref cantCaja3, lblCantClientes3);
                }
            }

            // TERCERA COMBINACION: CUANDO CAJA 3 ES MAYOR
            else if ((cantCaja3 >= cantCaja1) && (cantCaja3 >= cantCaja2))
            {
                if (cantCaja2 >= cantCaja1)
                {
                    cola1.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja1, lblCantClientes1);
                }
                else
                {
                    cola2.Encolar();
                    MostrarEstadoDeLaCaja(ref cantCaja2, lblCantClientes2);
                }
            }
        }
        private void BalancearEntreDosCajas(ref int pCajaInicial, ref int pCajaFinal, Cola pColaInicial, Cola pColaFinal, Label pCantClientesInicial, Label pCantClientesFinal)
        {
            if (pCajaFinal >= pCajaInicial)
            {
                pColaInicial.Encolar();
                pCajaInicial = pCajaInicial + 1;
                pCantClientesInicial.Text = $"Clientes en cola: {pCajaInicial}";

            }
            else
            {
                pColaFinal.Encolar();
                pCajaFinal = pCajaFinal + 1;
                pCantClientesFinal.Text = $"Clientes en cola: {pCajaFinal}";
            }
        }
        private void BalancearEntreUnaCaja(ref int pCajaInicial, Cola pColaInicial, Label pCantClientesInicial)
        {
            pColaInicial.Encolar();
            pCajaInicial = pCajaInicial + 1;
            pCantClientesInicial.Text = $"Clientes en cola: {pCajaInicial}";
        }

        // Boton para encolar clientes a una de las 3 cajas
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (btnAbrir1.Enabled == false && btnAbrir2.Enabled == false && btnAbrir3.Enabled == false) // TODAS ABIERTAS
            {
                BalancearCajas();
            }

            else if (btnAbrir1.Enabled == false && btnAbrir2.Enabled == false && btnAbrir3.Enabled == true) // CAJA 3 CERRADA
            {
                BalancearEntreDosCajas(ref cantCaja1, ref cantCaja2, cola1, cola2, lblCantClientes1, lblCantClientes2);
            }

            else if (btnAbrir1.Enabled == false && btnAbrir2.Enabled == true && btnAbrir3.Enabled == false) // CAJA 2 CERRADA
            {
                BalancearEntreDosCajas(ref cantCaja1, ref cantCaja3, cola1, cola3, lblCantClientes1, lblCantClientes3);
            }

            else if (btnAbrir1.Enabled == false && btnAbrir2.Enabled == true && btnAbrir3.Enabled == true) // CAJA 2 Y 3 CERRADA
            {
                BalancearEntreUnaCaja(ref cantCaja1, cola1, lblCantClientes1);
            }

            else if (btnAbrir1.Enabled == true && btnAbrir2.Enabled == false && btnAbrir3.Enabled == false) // CAJA 1 CERRADA
            {
                BalancearEntreDosCajas(ref cantCaja2, ref cantCaja3, cola2, cola3, lblCantClientes2, lblCantClientes3);
            }

            else if (btnAbrir1.Enabled == true && btnAbrir2.Enabled == false && btnAbrir3.Enabled == true) // CAJA 1 Y 3 CERRADA
            {
                BalancearEntreUnaCaja(ref cantCaja2, cola2, lblCantClientes2);
            }

            else if (btnAbrir1.Enabled == true && btnAbrir2.Enabled == true && btnAbrir3.Enabled == false) // CAJA 1 Y 2 CERRADA
            {
                BalancearEntreUnaCaja(ref cantCaja3, cola3, lblCantClientes3);
            }

            else if (btnAbrir1.Enabled == true && btnAbrir2.Enabled == true && btnAbrir3.Enabled == true) // TODAS CERRADAS
            {
                MessageBox.Show("Todas las cajas están cerradas");
            }
        }



        // Funcion de servicio para cobrar monto
        private void CobrarMonto(TextBox pTxtMonto, ref double pMonto, ref int pCantCaja, Cola pCola, Label pLblTotalCaja, Label pLblCantClientes)
        {
            if (pTxtMonto.Text.Length == 0) throw new Exception("Ingrese el monto");
            if (Convert.ToDouble(pTxtMonto.Text) <= 0) throw new Exception("Ingrese un monto válido");
            pMonto = pMonto + Convert.ToDouble(pTxtMonto.Text);


            if (pCantCaja == 0) throw new Exception("Ya no hay clientes en la caja");
            Cliente clienteEliminado = pCola.Desencolar();
            pCantCaja = pCantCaja - 1;
            pLblCantClientes.Text = $"Clientes en cola: {pCantCaja}";
        }

        // Botones para cobrar a un cliente
        private void btnCobrar1_Click(object sender, EventArgs e)
        {
            try
            {
                CobrarMonto(txtMonto1, ref monto1, ref cantCaja1, cola1, lblTotalCaja1, lblCantClientes1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCobrar2_Click(object sender, EventArgs e)
        {

            try
            {
                CobrarMonto(txtMonto2, ref monto2, ref cantCaja2, cola2, lblTotalCaja2, lblCantClientes2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCobrar3_Click(object sender, EventArgs e)
        {
            try
            {
                CobrarMonto(txtMonto3, ref monto3, ref cantCaja3, cola3, lblTotalCaja3, lblCantClientes3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        // Funciones de servicio para abrir y cerrar cajas
        private void AbrirCaja(Button pBtnAbrir, Button pBtnCerrar, Label pLblEstado, Button pBtnCobrar)
        {
            pBtnAbrir.Enabled = false;
            pBtnCerrar.Enabled = true;
            pLblEstado.Text = "Abierta";
            pBtnCobrar.Enabled = true;
        }


        bool bandera = true;
        private void CerrarCaja(Button pBtnAbrir, Button pBtnCerrar, Label pLblEstado, Button pBtnCobrar, Cola pColaACerrar, Cola pSegundaColaACerrar, Cola pColaAComparar2)
        {
            pBtnAbrir.Enabled = true;
            pBtnCerrar.Enabled = false;
            pLblEstado.Text = "Cerrada";
            pBtnCobrar.Enabled = false;


            if (pBtnCobrar.Enabled != true && bandera == true)
            {
                BalancearClientesCuandoCierraUnaCaja(pColaACerrar);
                bandera = false;
            }
            else
            {
                BalancearClientesCuandoCierranDosCajas(pSegundaColaACerrar, pColaACerrar, pColaAComparar2);
            }

        }

        private void ActualizarCantidadClientesAlCerrarCaja(ref int pCantCaja, Label pLblCantClientes)
        {
            pCantCaja = 0;
            pLblCantClientes.Text = $"Clientes en cola: {pCantCaja}";
        }

        // Botones de abrir y cerrar cajas
        private void btnAbrir1_Click(object sender, EventArgs e)
        {
            AbrirCaja(btnAbrir1, btnCerrar1, lblEstado1, btnCobrar1);
        }
        private void btnAbrir2_Click(object sender, EventArgs e)
        {
            AbrirCaja(btnAbrir2, btnCerrar2, lblEstado2, btnCobrar2);
        }
        private void btnAbrir3_Click(object sender, EventArgs e)
        {
            AbrirCaja(btnAbrir3, btnCerrar3, lblEstado3, btnCobrar3);
        }
        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            CerrarCaja(btnAbrir1, btnCerrar1, lblEstado1, btnCobrar1, cola1, cola2, cola3);
            ActualizarCantidadClientesAlCerrarCaja(ref cantCaja1, lblCantClientes1);
        }
        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            CerrarCaja(btnAbrir2, btnCerrar2, lblEstado2, btnCobrar2, cola2, cola1, cola3);
            ActualizarCantidadClientesAlCerrarCaja(ref cantCaja2, lblCantClientes2);
        }
        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            CerrarCaja(btnAbrir3, btnCerrar3, lblEstado3, btnCobrar3, cola3, cola1, cola2);
            ActualizarCantidadClientesAlCerrarCaja(ref cantCaja3, lblCantClientes3);
        }


        // Boton para finalizar la jornada y mostrar los montos finales
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lblTotalCaja1.Text = $"${monto1}";
            lblTotalCaja2.Text = $"${monto2}";
            lblTotalCaja3.Text = $"${monto3}";
        }
    }
}
