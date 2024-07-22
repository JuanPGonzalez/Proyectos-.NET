﻿using Lab2;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Lab2 { }

public class ManejadorArchivoXml : ManejadorArchivo
{

    protected DataSet ds;

    public override System.Data.DataTable getTabla()
    {
        this.ds = new DataSet();
        this.ds.ReadXml("agenda.xml");
        return this.ds.Tables["contactos"];
    }
    public override void aplicaCambios()
    {
        this.ds.WriteXml("agenda.xml");
        this.ds.WriteXml("agendaconschema.xml", XmlWriteMode.WriteSchema);
    }
}