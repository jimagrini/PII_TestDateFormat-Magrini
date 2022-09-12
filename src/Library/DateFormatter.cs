namespace TestDateFormat;
using System.Collections;
using System.Linq;
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
        ArrayList monthsWith31Days= new ArrayList(){01,03,05,07,08,10,12};

        ArrayList monthsWith30Days= new ArrayList(){04,06,09,11};
   
        if (String.IsNullOrEmpty(date))
        {
            return ("Debe ingresar una fecha").ToString();
        }
        else
        {
            if(date.Length>10 || date.Length<10 || !(date.Contains("/")))
            {
                return ("Formato de fecha invalido").ToString(); 
            }
            else
            {
                int index1Slash= date.IndexOf("/",2);
                int index2Slash= date.IndexOf("/",3);
                int amountOfSlashs=date.Count(character => character == '/');
                if(index1Slash != 2 || index2Slash !=5 || amountOfSlashs!=2 || date.Any(letter=> char.IsLetter(letter))==true)
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
                        if( (monthsWith30Days.Contains(monthNumber) && dayNumber>30) || (monthNumber==02 && dayNumber>29) )
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
}
