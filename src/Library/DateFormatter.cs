﻿namespace TestDateFormat;
using System.Collections;
/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
   
        if (String.IsNullOrEmpty(date))
        {
            return ("Debe ingresar una fecha").ToString();
        }
        else
        {
            if(date.Length>10 || date.Length<10)
            {
                return ("Formato de fecha invalido").ToString(); 
            }
            else
            {
                int index1Slash= date.IndexOf("/",2);
                int index2Slash= date.IndexOf("/",3);
                if(index1Slash != 2 || index2Slash !=5 || date.Any(letter=> char.IsLetter(letter))==true)
                {
                    return ("Formato de fecha invalido").ToString(); 
                }
                else
                {
                    string dayStr = date.Substring(0,2);
            
                    string monthStr= date.Substring(3,2);

                    int monthNumber= Int32.Parse(monthStr);
            
                    int dayNumber = Int32.Parse(dayStr);
                    
                    if(dayNumber>31 || dayNumber<1 ||monthNumber>12 || monthNumber<1)
                    {
                        return ("Formato de fecha invalido").ToString();
                    }
                    else
                    {
                        string dateOutput = date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
                        return dateOutput;
                    }
                }
            }
        }
    }
}
