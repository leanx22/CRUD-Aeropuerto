public enum EPerfil
{
    //NA, //no asignado.
    vendedor,
    supervisor,
    administrador
}

public enum ENacional //Destinos nacionales.
{
    SantaRosa,Mendoza,SantiagoDelEstero,
    Bariloche,Neuquen,Trelew,
    Corrientes,Posadas,Tucuman,
    Cordoba,Iguazu,PuertoMadryn,
    Jujuy,Salta,Ushuaia
    //NA = no asignado
}

public enum EInternacional //Destinos internacionales.
{
    Recife,Roma,
    Acapulco,Miami
        //NA = no asignado
}

public enum EOperacion//sacar
{
    Alta,Baja,Modificacion
}

public enum EEntidad//sacar
{
    Usuario,Pasajero,Vuelo,Aeronave
}

public enum ETipoEquipaje
{
    Mano,Bodega
}

public enum EEstadoDeVuelo
{
    Pendiente,EnProgreso,Finalizado
}