using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace listaOrdenado
{
    class Inventario
    {
        //bool aviso;
        private Producto Primero;
        private Producto Ultimo;

        public Inventario()
        {
            Primero = null;
            Ultimo = null;
        }
        

        /// <summary>
        /// Permite agregar productos y los ordena de forma ascendente
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarOrdenado(Producto nuevo)
        {
            Producto guardar = Primero;

            if (buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {
                if (Primero == null)
                {
                    Primero = nuevo;
                }
                else
                {
                    if (nuevo.codigo < Primero.codigo)
                    {
                        nuevo.Siguiente = Primero;
                        Primero = nuevo;
                    }
                    else if (nuevo.codigo > Primero.codigo)
                    {
                        while (guardar.Siguiente != null && nuevo.codigo > guardar.Siguiente.codigo)   //este sirve para indicarnos cuando dos numeros estan
                        {                                                                             //enseguida uno con el otro, cuando se cumple se sale del
                            guardar = guardar.Siguiente;                                             //while para entrar a lo de abajo donde se cambian las direcciones del siguiente de cada uno
                        }
                        nuevo.Siguiente = guardar.Siguiente;
                        guardar.Siguiente = nuevo;
                    }
                }
            }
        }


        /// <summary>
        /// Permite saber si un código ya existe en la lista
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool buscarInicio(int codigo)
        {
            bool mostrar = false;
            Producto Actual = Primero;
            bool encontrado = false;

            while (Actual != null && encontrado != true)
            {
                if (Actual.codigo == codigo)
                {
                    mostrar = true;
                    encontrado = true;
                }
                Actual = Actual.Siguiente;
            }

            return mostrar;
        }

        /// <summary>
        /// Busca un producto mediante su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Producto buscarProducto(int codigo)
        {
            Producto mostrar = null;
            Producto Actual = Primero;    //aqui indico que el el producto actual empieza con el primer elemento que tengo, me sirve para recorrer la lista
            bool encontrado = false;            //sirve para indicarme cuando el codigo coincida con el que busco

            if (Primero != null)   //con este me dice que la lista si contiene algo dentro
            {
                while (Actual != null && encontrado != true)
                {
                    if (Actual.codigo == codigo)
                    {
                        mostrar = Actual;
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }

                if (encontrado == false)
                {
                    mostrar = null;
                }
            }
            else
                MessageBox.Show("Error, lista vacia");

            return mostrar;
        }

        /// <summary>
        /// Elimina un producto por su código
        /// </summary>
        /// <param name="codigo"></param>
        public void eliminarProducto(int codigo)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            bool encontrado = false;

            // primero=100          ultimo=89           Actual=89           anterior=47         codigo=100      encontrado=false

            //  listaSimple         56 -> 100 -> 47 -> 89 -> null

            if (Primero != null)
            {
                while (Actual != null && encontrado != true)
                {
                    if (Actual.codigo == codigo)
                    {
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            temporal.Siguiente = null;
                            Ultimo = temporal;
                        }
                        else
                        {
                            temporal.Siguiente = Actual.Siguiente;
                        }

                        encontrado = true;
                    }
                    temporal = Actual;
                    Actual = Actual.Siguiente;
                }

            }
            else
                MessageBox.Show("Error, lista vacia");

        }

        public void agregarEnInicio(Producto nuevo)
        {
            Producto Actual = Primero;
            Primero = nuevo;
            Primero.Siguiente = Actual;
        }


        public void insertarPosicion(Producto nuevo, int posicion)
        {
            Producto Actual = Primero;
            Producto temporal = null;

            if (buscarInicio(nuevo.codigo) == false)     //cuando es false quiere decir que no hay aun ese codigo y lo deja agregar a la lista
            {

                if (Primero != null)
                {
                    if (posicion == 1)
                    {
                        agregarEnInicio(nuevo);
                    }
                    else
                    {
                        for (int i = 1; i < (posicion - 1); i++)
                        {
                            Actual = Actual.Siguiente;
                        }
                        temporal = Actual.Siguiente;
                        Actual.Siguiente = nuevo;
                        nuevo.Siguiente = temporal;
                    }
                }
                else
                    MessageBox.Show("Error, lista vacia");
            }
        }

        /// <summary>
        /// Nos genera un reporte inverso del original mediante recursividad 
        /// </summary>
        /// <returns></returns>
        public string reporteVolteado()
        {
            string mostrar = "";

            if (Primero.Siguiente == null)
                mostrar += Primero.ToString();
            else
                mostrar = reporteVolteado(Primero.Siguiente) + "\r\n" + Primero.ToString();
            return mostrar;

        }


        private string reporteVolteado(Producto nuevo)
        {
            string mostrar = "";
            if (nuevo.Siguiente != null)
                mostrar += reporteVolteado(nuevo.Siguiente) + "\r\n" + nuevo.ToString();
            else
                mostrar += nuevo.ToString();
            return mostrar;
        }


        public string reporte()
        {
            string mostrar = "";
            Producto Actual = Primero;

            if (Actual != null)
            {
                while (Actual != null)
                {
                    mostrar += Actual.ToString() + "\r\n";
                    Actual = Actual.Siguiente;
                }
            }
            else
                mostrar = "La lista no contiene elementos disponibles";

            return mostrar;
        }



    }

}