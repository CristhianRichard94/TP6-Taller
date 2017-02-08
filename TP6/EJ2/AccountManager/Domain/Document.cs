using System;

namespace AccountManager.Domain
{/// <summary>
/// Clase que representa el documento de un cliente
/// </summary>
    public class Document
    {

        public DocumentType Type { get; set; }

        public String Number { get; set; }

    }

    public enum DocumentType
    {

        DNI,

        CUIL,

        LC,

        LE

    }
}