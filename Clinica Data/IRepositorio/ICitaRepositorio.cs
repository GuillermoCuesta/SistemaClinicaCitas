﻿
using ClinicaEntidades;

namespace ClinicaData.IRepositorio
{
    public interface ICitaRepositorio
    {
        Task<string> Guardar(Cita objeto);
        Task<string> Cancelar(int Id);
        Task<List<Cita>> ListaCitasPendiente(int IdUsuario);
        Task<List<Cita>> ListaHistorialCitas(int IdUsuario);
        Task<string> CambiarEstado(int IdCita,int IdEstado,string Indicaciones);
    }
}
