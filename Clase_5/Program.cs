namespace Clase_5
{
    internal class Program
    {

        //////////////////////ARRAYS UNIDIMENSIONALES: VECTORES///////////////
        static void Main(string[] args)
        {
            //int[] edades = { 1, 2, 3, }; //Vector por extension
            //int[] edadesDos = new int[] { 22, 33, 21 };

            //for (int i = 0; i < edades.Length; i++)
            //{
            //    Console.WriteLine(edades[i]);
            //}

            //foreach(int numero in edades)
            //{
            //    Console.WriteLine(numero);
            //}


            //////////////////////VECTORES BIDIMENSIONAL: MATRIZ///////////////

            //int[,] matriz = new int[,] {{5,9},{8,8},{3,7}};

            //for(int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write($"{matriz[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0;i < matriz.GetLength(0); i++)
            //{
            //    Console.WriteLine(matriz[i, 1]);
            //}
            //////////////////////LISTAS///////////////

            //List<int> numeros = new List<int>();
            //numeros.Add(2);
            //numeros.Add(4);
            //numeros.Add(7);
            //numeros.Add(9);
            //numeros.Add(3);
            //numeros.Add(7);
            //numeros.Add(2);
            //numeros.Add(7);

            //Console.WriteLine(numeros[0]);

            //bool esta = numeros.Contains(2);
            //Console.WriteLine(esta);

            //int Indice = numeros.IndexOf(1);
            //Console.WriteLine(Indice);

            //numeros.Remove(3);



            //int cantidad = numeros.Count;
            //Console.WriteLine(cantidad);

            //numeros.Sort(); 
            
            //foreach(int numero in numeros)
            //{
            //    Console.WriteLine(numero);  
            //}

            //numeros.Clear();
            //int cantidad = numeros.Count;
            //Console.WriteLine(cantidad);

            /////////////////////////////////////////////////////PILAS O STACK ////////////////////////////////
            
            //Stack<int> pila = new Stack<int>();

            //pila.Push(1);
            //pila.Push(2);
            //pila.Push(3);
            //pila.Push(4);
            //pila.Push(5);
            //pila.Push(6);

            //Console.WriteLine();

            ////foreach(int numero in pila)
            ////{
            ////    Console.WriteLine(numero);
            ////}

            ////int ultimo = pila.Peek();
            ////Console.WriteLine(ultimo);

            ////bool contiene = pila.Contains(100);
            ////Console.WriteLine(contiene);

            ////int eliminado = pila.Pop();
            ////Console.WriteLine($"Elminado {0}",eliminado);

            //List<int> eliminados = new List<int>();

            //for(int i = 0; i < 3; i++)
            //{
            //    eliminados.Add(pila.Pop()); 
            //}

            //Stack <int> pilaEliminados = new Stack<int> (eliminados);

            //foreach (int numero in pilaEliminados)
            //{ 
            //    Console.WriteLine(numero); 
            //}

            ///Clear()
            ///Count

            //////////////////////////////////COLAS o QUEUE////////////////////
            
            //Queue<string> colaNombres = new Queue<string>();
            //colaNombres.Enqueue("Gonzalo");
            //colaNombres.Enqueue("Gabriel");
            //colaNombres.Enqueue("Lucas");
            //colaNombres.Enqueue("Dario");
            //colaNombres.Enqueue("Julian");
            //colaNombres.Enqueue("Manuel");

            //string primero = colaNombres.Peek();

            //Console.WriteLine(primero);

            //foreach(string nombres in colaNombres)
            //{
            //    Console.WriteLine($"Cola de nombre: {nombres}");
            //}

            //Console.WriteLine(colaNombres.Dequeue());

            /////////////////////////////////////DICCIONARIO////////////////////////////
            
            Dictionary<string, int> diccionarioPersonas = new Dictionary<string, int>();

            diccionarioPersonas["Gonzalo"] = 27;
            diccionarioPersonas["Katherine"] = 28;
            diccionarioPersonas["Julian"] = 28;
            diccionarioPersonas["Natasha"] = 29;

            //Console.WriteLine(diccionarioPersonas["Gonzalo"]);

            //Console.WriteLine(diccionarioPersonas.ContainsKey("pepe"));

            //Console.WriteLine(diccionarioPersonas.ContainsValue(29));

            //List<string> claves = new List<string>(diccionarioPersonas.Keys);

            //foreach(string c in diccionarioPersonas.Keys)
            //{
            //    Console.WriteLine(c);
            //}

            //foreach(int i in diccionarioPersonas.Values)
            //{
            //    Console.WriteLine(i);
            //}

            foreach(KeyValuePair<string, int> par in diccionarioPersonas) 
            {
                if(par.Value > 25)
                {
                    Console.WriteLine($"{par.Key}: {par.Value}");
                }
            }




        }





    }
}