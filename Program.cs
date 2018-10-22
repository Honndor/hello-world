using System;
using System.IO; //Permite uso de archivos de texto 
using System.Collections.Generic;
using System.Text;


namespace Info_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo proyecto
            int opcion=0;
            do
            {
                //Inicio del menu 
                Console.WriteLine("Ingresa la opcion que deseas realizar");
                Console.WriteLine("Opcion 1: Iniciar sesion");
                Console.WriteLine("Opcion 2: Registro");
                opcion = int.Parse(Console.ReadLine());
                //Fin Menu

                switch(opcion)
                {
                    case 1: //inicio sesion
                        {
                            StreamReader lectura=File.OpenText(@"usuarios.txt");
                            string contenido= lectura.ReadToEnd();
                            lectura.Close();
                            string [] elementos= contenido.Split("\n");

                            Console.WriteLine("Bienvenido al inicio de sesion");
                            Console.WriteLine("Ingresa tu nombre de usuario: ");
                            string temporal =Console.ReadLine();
                            bool validacion=false;
                            
                            for(int x=0; x<elementos.Length;x++)
                            {
                                if (elementos[x].Trim().Equals(temporal))  //Trim limpiar formato
                                {
                                    Console.WriteLine("Ingresa tu contrasena");
                                    temporal= Console.ReadLine();
                                    if(elementos[x+1].Trim().Equals(temporal))
                                    {
                                        validacion=true;
                                        break;
                                    }
                                    else
                                    {
                                        validacion=false;
                                        break;
                                    }
                                }
                                else
                                {
                                    //Console.WriteLine("El usuario/contrasena no son correctos");
                                    validacion=false;
                                }
                            }
                            if(validacion==true)//if(validacion)
                            {
                                Console.WriteLine("Bienvenido");

                            }
                            else
                            {
                                Console.WriteLine("El usuario y la contrasena son incorrectos");
                                //Inicio menu de la aplicacion

                                int opcionMenu=0;
                                Console.WriteLine("Ingresa la opcion que deseas realizar");
                                Console.WriteLine("Opcion 1: Menu de usuarios");
                                Console.WriteLine("Opcion 2: Menu de productos");
                                Console.WriteLine("Opcion 3: Reportes");
                                opcionMenu= int.Parse(Console.ReadLine());
                                //Fin del Menu

                                switch(opcionMenu)
                                {
                                    case 1: //Menu Usuarios
                                        {   
                                            byte opcionusuarios=0;
                                            Console.WriteLine("Bienvenido a opciones de usuario");
                                            Console.WriteLine("Para dar de alta un producto presione 1");
                                            Console.WriteLine("Para dar de baja un usuario presione 2");
                                            Console.WriteLine("Para realizar cambios en la informacion de un usuario presione 3");
                                            opcionusuarios= byte.Parse(Console.ReadLine());

                                            switch (opcionusuarios)
                                            {
                                                case 1://Altas
                                                    {
                                                        
                                                        break;
                                                    }
                                                case 2:
                                                {
                                                    byte opcionproductos=0;
                                                    Console.WriteLine("Bienvenido a opciones de usuario");
                                                    Console.WriteLine("Para dar de alta un producto presione 1");
                                                    Console.WriteLine("Para dar de baja un producto presione 2");
                                                    Console.WriteLine("Para realizar cambios en la informacion de un usuario presione 3");
                                                    opcionusuarios= byte.Parse(Console.ReadLine());

                                                    switch (opcionproductos)
                                                    {
                                                        case 1://Altas
                                                            {

                                                                break;
                                                            }
                                                        case 2://Bajas
                                                            {
                                                                Console.WriteLine("Bienvenido a bajas");
                                                                Console.WriteLine("Ingresa el nombre del usuario a dar de baja");
                                                                string usuario=Console.ReadLine();
                                                                StreamReader lecturaBajas=File.OpenRead(@"");
                                                                string contenidoUsuarios = lecturaBajas.ReadToEnd();
                                                                lecturaBajas.Close();
                                                                string[] elementosUsuarios=contenidoUsuarios.Split('\n');
                                                                //Fin lectura archivo
                                                                for (int x =0; x <elementosUsuarios.Length; x++)
                                                                {
                                                                    if(elementosUsuarios[x].Trim().Equals(usuario))
                                                                    {
                                                                        Console.WriteLine("Ingresa la contrasena");
                                                                        usuario= Console.ReadLine();
                                                                        if(elementosUsuarios[x+1].Trim().Equals(usuario))
                                                                        {
                                                                            //Procedemos a la baja de usuario
                                                                            elementosUsuarios[x]="";
                                                                            elementosUsuarios[x+1]="";
                                                                            
                                                                            Console.WriteLine("Se elmino correctamente");

                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Contrasena incorrecta");
                                                                        }
                                                                    }
                                                                }
                                                                
                                                                break;
                                                            }
                                                        case 3://Cambios
                                                            {
                                                                break;
                                                            }

                                                
                                                        default:
                                                            {
                                                                 Console.WriteLine("La opcion no es valida");
                                                                 break;
                                                            }
                                                    }
                                                    break;
                                                }


                                                case 3://Cambios
                                                {
                                                    break;
                                                }

                                                
                                                default:
                                                {
                                                    Console.WriteLine("La opcion no es valida");
                                                    break;
                                                }
                                            }

                                            break;
                                        }
                                    case 2: //Menu productos
                                        {
                                            break;
                                        }
                                    case 3: //Reportes
                                        {
                                            break;
                                        }
                                    default:
                                    {
                                        Console.WriteLine("Opcion no valida");
                                        break;
                                    }
                                }

                            }
                            break;
                        }
                        case 2: //Registro
                        {
                            //Crear archivo TXT
                            StreamWriter escritura=File.AppendText(@"U_Detalle.txt");
                            string temporal= null; 
                            
                            Console.WriteLine("Registro de Usuarios");
                            Console.WriteLine("Ingresa el Nombre(s)"); 
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa el Apellido paterno");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa el Apellido materno");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa la fecha de Nacimiento: DD/MM/AAAA");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa tu direccion");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("numero telefonico");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Sexo");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Entidad de nacimiento");
                            temporal=Console.ReadLine();
                            escritura.WriteLine(temporal);
                            escritura.Close();
                            Console.Clear();
                            Console.WriteLine("Los datos se almacenaron correctamente");
                            //Fin del registro

                            //Creacion de usuario y contrase#a
                            Console.WriteLine("Elige un nombre de usuario");
                            temporal=Console.ReadLine();
                            
                            if(File.Exists(@"U_Detalle.txt"))
                            {
                                //Cuando el archivo existe

                                StreamReader  lectura= File.OpenText(@"U_Detalle.txt");
                                string contenido = lectura.ReadToEnd();
                                lectura.Close();

                                string [] datos= contenido.Split('\n');
                                bool validacion=true;

                                do
                                {
                                Console.WriteLine("Ingresa el nombre de usuario");
                                temporal= Console.ReadLine();

                                //Validacion de usuario

                                for(int x=0; x<datos.Length; x=x+2)
                                {
                                    if(datos[x].Trim().Equals(temporal))//Trim permite borrar el formato de la cadena 
                                    {
                                        Console.WriteLine("El usuario ya existe...");
                                        validacion=false;

                                    }     
                                    else
                                    {
                                        StreamWriter creacion = File.AppendText(@"U_Detalle.txt");
                                        creacion.WriteLine(temporal);
                                        Console.WriteLine("Ingrese la contrase%a");
                                        temporal= Console.ReadLine();
                                        creacion.WriteLine(temporal);
                                        creacion.Close();
                                        validacion=true;
                                    } 
                                }
                                //Fin Validacionde usuario
                                }
                                while(validacion!=true);
                                {
                                    
                                } 
                            }
                            else
                            {
                                //Cuando el archivo no existe
                                StreamWriter creacion=File.CreateText(@"U_Detalle.txt");
                                Console.WriteLine("Ingresa el nombre de usuario");
                                temporal= Console.ReadLine();
                                creacion.WriteLine(temporal);
                                Console.WriteLine("Ingresa la contrasena");
                                temporal= Console.ReadLine();
                                creacion.WriteLine(temporal);
                                Console.WriteLine("Usuario y contrase#a creados correctamente");
                                creacion.Close();
                                
                            }
                            //Fin de crear usuaio y contrase#a
                            break;
                        }
                        default: //Otra opcion
                        {
                            break;
                        }
                }
            Console.WriteLine("Deseas continuar en el programa?\n Ingresa 1 para si, cualquier otro numero para no");
            opcion=int.Parse(Console.ReadLine());


            }
            while(opcion==1);
        }
    }
}
