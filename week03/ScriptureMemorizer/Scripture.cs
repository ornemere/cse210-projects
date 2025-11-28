using System.Collections.Generic;

using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        // TODO: dividir texto, crear Word por cada palabra
    }

    public string GetDisplayText()
    {
        // TODO: unir referencia + palabras
        return "";
    }

    public void HideRandomWords(int number)
    {
        // TODO: elegir palabras al azar y ocultarlas
    }

    public bool IsCompletelyHidden()
    {
        // TODO: revisar si todas están ocultas
        return false;
    }
}
