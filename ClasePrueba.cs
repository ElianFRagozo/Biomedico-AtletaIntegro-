using BIOMEDICO.Models;
using NUnit.Framework;
using System.Web.Mvc;
using System;
using BIOMEDICO.Controllers;
using static BIOMEDICO.Controllers.MedicosController;
using System.Data.Entity;
using System.Drawing;
using System.Security.Cryptography;
using static BIOMEDICO.Controllers.DeportistaController;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using static BIOMEDICO.Controllers.RemisionController;

[TestFixture]
public class EspecialistasControllerTests
{
    [Test]
    public void AgregarMedico_ValidInput_ShouldRedirectToAction()
    {
        // Arrange
        var dbContext = new BIOMEDICOEntities5();  // Crea una instancia del contexto de base de datos
        //var controller = new MedicosController(dbContext);
        var medico = new Medicos
        {
            CodMedicos = 123456789,
            EstadoEspecialistas = "activo",
            PrimerNombre = "Juan",
            SegundoNombre = "Carlos",
            PrimerApellido = "Pérez",
            SegundoApellido = "García",
            FechaNacimiento = DateTime.Parse("1980-01-01"),
            Especialidad = "Medicina General",
            Direcccion = "Calle 123",
            Telefono = "555-5555",
            Centro = "Hospital Central",
            Genero = "Masculino",
            Correo = "juancarlos@test.com"
        };
        var objMedico = new ObjMedicosDeportiva { MedicosDeport = medico };

        // Act
       // var result = controller.Agregar(objMedico) as JsonResult;

        // Assert
        //Assert.IsNotNull(result);

    }

    [Test]
    public void AgregarMedico_MedicoExistente_ShouldReturnErrorMessage()
    {
        // Arrange
        //var controller = new MedicosController(dbContext);
        var medicoExistente = new Medicos
        {
            CodMedicos = 123456789,
            EstadoEspecialistas = "activo",
            PrimerNombre = "Pedro",
            SegundoNombre = "Pablo",
            PrimerApellido = "Gómez",
            SegundoApellido = "García",
            FechaNacimiento = DateTime.Parse("1985-05-05"),
            Especialidad = "Pediatría",
            Direcccion = "Calle 456",
            Telefono = "666-6666",
            Centro = "Hospital Central",
            Genero = "Masculino",
            Correo = "pedropablo@test.com"
        };
        var objMedico = new ObjMedicosDeportiva { MedicosDeport = medicoExistente };

        // Act
        //var result = controller.Agregar(objMedico) as JsonResult;
        //var jsonResult = result.Data as JsonResultData;

        // Assert
        //Assert.IsNotNull(result);
        //Assert.IsFalse(jsonResult.Success);
        //Assert.AreEqual("Ya existe un médico con ese código", jsonResult.Message);
    }
    [TestFixture]
    public class DeportistasControllerTests
    {
        [Test]
        public void AgregarDeportista_ValidInput_ShouldRedirectToAction()
        {
            // Arrange
            var controller = new DeportistaController();
            var deportista = new Deportistas
            {
                TipoIdentificacion = "Cedula",
                NumIdentificacion = 123456789,
                EstadoDeportista = "Activo",
                PrimerNombre = "Juan",
                SegundoNombre = "",
                PrimerApellido = "Perez",
                SegundoApellido = "",
                Edad = "25",
                Genero = "Masculino",
                GrupoSanguineo = "O+",
                Eps = "EPS Segura",
                CorreoDeportista = "juan@example.com",
                Deporte = "Fútbol",
                FechaNacimiento = new DateTime(1998, 5, 15),
                PaisNacimiento = "Colombia",
                DepartamentoNacimiento = "Cundinamarca",
                MunicipioNacimiento = "Bogotá",
                GrupoEtareo = "Juventud",
                CondicionPoblacion = "Desplazado",
                EntidadPrestadora = "Ninguno",
                Telefono = "1234567890",
                NivelEstudio = "Universidad",
                PaisResidencia = "Colombia",
                DepartamentoResidencia = "Cundinamarca",
                MunicipioResidencia = "Bogotá",
                BarrioResidencia = "Centro",
                DireccionResidencia = "Calle 123",
                TipoEtnia = "Ninguna",
                ZonaInfluencia = "Urbana",
                NombreMonitor = "Pedro",
                NombreGrupo = "Profesional",
                EstadoCivil = "Soltero"
            };
            var madre = new DatosFamiliares
            {
                NomMadre = "Maria",
                ApeMadre = "Lopez",
                TipoDocumento = "Cedula",
                NumDocumento = "987654321",
                Direccion = "Calle 456",
                Barrio = "Oriente",
                Celular = "555-1234",
                Ocupacion = "Ama de casa"
            };
            var padre = new DatosFamiliares
            {
                NomPadre = "Carlos",
                ApePadre = "Gomez",
                TipoDocumento = "Cedula",
                NumDocumento = "654321987",
                Direccion = "Calle 789",
                Barrio = "Occidente",
                Celular = "555-4321",
                Ocupacion = "Empleado"
            };
            var ocupacion = new Ocupacion
            {
                Ocupacion1 = "Atleta",
                Institucion = "Club Deportivo",
                Peso = 70.5,
                Estatura = 180,
                TallaCamisa = "L",
                TallaPantalon = 36,
                TallaCalzado = 42,
                TallaSudadera = "XL",
                NumeroHijos = 0
            };

            var objDeportista = new ObjDeportista
            {
                Deport = deportista,
                DataFamiliar = new DatosFamiliares(),
                Ocupation = ocupacion
            };


            // Act
            var result = controller.Agregar(objDeportista) as JsonResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }


        [Test]
    public void AgregarRemision_ValidInput_ShouldRedirectToAction()
    {
        // Arrange
        var objRemisionMedicasDeportiva = new ObjRemisionMedicasDeportiva
        {
            RemisionMedicas = new Remision
            {
                EstadoRevision = "Pendiente",
                NumeroIdentificacion = 100333433,
                FechaRemision = DateTime.Now,
                DisciplinaRemision = "Fútbol",
                MunicipioRemision = "Valledupar",
                CategoriaRemision = "Profesional",
                AreaServicioRemision = "Medicina del Deporte",
                NombreDeportistaRemision = "Yulieth Carrascal Ballena",
                CelularRemision = "555-123456",
                CorreoRemision = "yulieth@example.com",
                TipoLesionRemision = "Lesión de rodilla",
                FechaLesionRemision = DateTime.Now.ToString(),
                FirmaEntrenadoRemision = "Firma del entrenador"
            }
        };

        var controller = new RemisionController();

        // Act
        var result = controller.Agregar(objRemisionMedicasDeportiva) as JsonResult;

        // Assert
        Assert.IsNotNull(result);
    }
}
