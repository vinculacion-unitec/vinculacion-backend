using VinculacionBackend.Data.Database;
using VinculacionBackend.Data.Entities;
using VinculacionBackend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace VinculacionBackend.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VinculacionContext>
    {

        public Configuration()
        {

            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(VinculacionContext context)
        {
            //var encryption = new Encryption();
            //var period = new Period { Number = 1, Year = 2016, ToDate = "18 de Febrero", FromDate = "05 de Abril", IsCurrent = false };
            //var clas = new Class { Name = "ANAL. Y DIS. DE SISTEMAS I" };
            //var majorsId = new List<string>();
            //var sectionsId = new List<long>();
            //sectionsId.Add(1);
            //var fac1 = new Faculty { Name = "Facultad de Ingenieria y Architectura" };
            //var fac2 = new Faculty { Name = "Facultad de Ciencias Aministrativas y Sociales" };
            //majorsId.Add("I - 01");
            //var user = new User
            //{
            //    AccountId = "21111111",
            //    Email = "carlos.castroy@unitec.edu",
            //    Name = "Carlos Castro",
            //    Status = Status.Verified,
            //    Major = null,
            //    Campus = "San Pedro Sula",
            //    CreationDate = DateTime.Now,
            //    ModificationDate = DateTime.Now,
            //    Password = encryption.Encrypt("1234")
            //};
            //var admin = new User
            //{
            //    AccountId = "21212121",
            //    Email = "admin@unitec.edu",
            //    Name = "admin",
            //    Status = Status.Verified,
            //    Major = null,
            //    Campus = "San Pedro Sula",
            //    CreationDate = DateTime.Now,
            //    ModificationDate = DateTime.Now,
            //    Password = encryption.Encrypt("admin")
            //};
            //var professorRole = new Role { Name = "Professor" };
            //var studentRole = new Role { Name = "Student" };
            //var adminRole = new Role { Name = "Admin" };
            //var major1 = new Major { MajorId = "I - 01", Name = "INGENIER�A EN SISTEMAS COMPUTACIONALES" };
            //var user2 = new User
            //{
            //    AccountId = "21241095",
            //    Campus = "SPS",
            //    CreationDate = DateTime.Now,
            //    Email = "efherreram@unitec.edu",
            //    Name = "Edwin Herrear",
            //    ModificationDate = DateTime.Now,
            //    Password = encryption.Encrypt("holis"),
            //    Status = Status.Inactive,
            //    Major = major1
            //};
            //var section = new Section { Code = "INF405", Period = period, Class = clas, User = user };
            //var project = new Project
            //{
            //    ProjectId = "CSPS-I-2013-test",
            //    Name = "Proyecto de Vinculacion Unitec",
            //    Description = "Programa para el registro de horas de vinculacion a estudiantes de Unitec sps",
            //    Cost = 10000000000,
            //    SectionIds = sectionsId,
            //    MajorIds = majorsId,
            //    IsDeleted = false,
            //    BeneficiarieOrganization = "UNITEC",
            //};

            //var projectMajor = new ProjectMajor { Major = major1, Project = project };

            //var sectionProject = new SectionProject { Section = section, Project = project };
            //context.Users.AddOrUpdate(
            //    x => x.Id,
            //    user
            //    );
            //context.Majors.AddOrUpdate(
            //    x => x.Id,
            //    major1,
            //    new Major { MajorId = "I - 02", Name = "INGENIER�A INDUSTRIAL Y DE SISTEMAS", Faculty = fac1 },
            //    new Major { MajorId = "I - 03", Name = "INGENIER�A CIVIL", Faculty = fac1 },
            //    new Major { MajorId = "I - 04", Name = "INGENIER�A EN TELECOMUNICACIONES", Faculty = fac1 },
            //    new Major { MajorId = "I - 05", Name = "INGENIER�A EN MECATR�NICANICA", Faculty = fac1 },
            //    new Major { MajorId = "I - 06", Name = "INGENIER�A EN INFORM�TICA", Faculty = fac1 },
            //    new Major { MajorId = "I - 07", Name = "INGENIER�A EN SISTEMAS ELECTR�NICOS", Faculty = fac1 },
            //    new Major { MajorId = "I - 09", Name = "INGENIER�A EN GESTI�N LOG�STICA", Faculty = fac1 },
            //    new Major { MajorId = "I - 10", Name = "INGENIER�A EN BIOM�DICA", Faculty = fac1 },
            //    new Major { MajorId = "I - 11", Name = "ARQUITECTURA", Faculty = fac1 },
            //    new Major { MajorId = "I - 12", Name = "INGENIER�A EN ENERG�A", Faculty = fac1 },
            //    new Major { MajorId = "L - 02", Name = "LICENCIATURA EN ADMINISTRACI�N INDUSTRIAL Y DE NEGOCIOS", Faculty = fac2 },
            //    new Major { MajorId = "L - 04", Name = "LICENCIATURA EN FINANZAS", Faculty = fac2 },
            //    new Major { MajorId = "L - 06", Name = "LICENCIATURA EN MERCADOTECNIA(PROMOCI�N Y PUBLICIDAD)", Faculty = fac2 },
            //    new Major { MajorId = "L - 07", Name = "LICENCIATURA EN COMUNICACI�N Y PUBLICIDAD", Faculty = fac2 },
            //    new Major { MajorId = "L - 08", Name = "LICENCIATURA EN MERCADOTECNIA Y NEGOCIOS INTERNACIONALES", Faculty = fac2 },
            //    new Major { MajorId = "L - 09", Name = "LICENCIATURA EN ADMINISTRACI�N DE EMPRESAS TUR�STICAS", Faculty = fac2 },
            //    new Major { MajorId = "L - 10", Name = "LICENCIATURA EN DERECHO", Faculty = fac2 },
            //    new Major { MajorId = "L - 12", Name = "LICENCIATURA EN DISE�O GRAFICO", Faculty = fac2 },
            //    new Major { MajorId = "L - 13", Name = "LICENCIATURA EN RELACIONES INTERNACIONALES", Faculty = fac2 },
            //    new Major { MajorId = "L - 14", Name = "LICENCIATURA EN PSICOLOG�A CON ORIENTACI�N EMPRESARIAL", Faculty = fac2 },
            //    new Major { MajorId = "L - 15", Name = "LICENCIATURA EN CONTADUR�A P�BLICA", Faculty = fac2 },
            //    new Major { MajorId = "L - 16", Name = "LICENCIATURA EN ADMINISTRACI�N DE EMPRESAS(CEUTEC)", Faculty = fac2 },
            //    new Major { MajorId = "T - 03", Name = "T�CNICO UNIVERSITARIO EN MERCADOTECNIA Y VENTAS(CEUTEC)" },
            //    new Major { MajorId = "T - 05", Name = "T�CNICO UNIVERSITARIO EN ADMINISTRACI�N(CEUTEC)" },
            //    new Major { MajorId = "T - 07", Name = "T�CNICO EN DESARROLLO DE SISTEMAS DE INFORMACI�N(CEUTEC)" },
            //    new Major { MajorId = "T - 08", Name = "T�CNICO UNIVERSITARIO EN DISE�O GR�FICO(CEUTEC)" }
            //    );

            //context.MajorUsersRels.AddOrUpdate(
            //    x => x.Id,
            //    new MajorUser { User = user, Major = null }
            //    );

            //context.Roles.AddOrUpdate(
            //    x => x.Id,
            //    studentRole,
            //    professorRole,
            //    adminRole
            //    );
            //context.UserRoleRels.AddOrUpdate(
            //    x => x.Id,
            //    new UserRole { User = user, Role = professorRole },
            //    new UserRole { User = user2, Role = studentRole },
            //    new UserRole { User = admin, Role = adminRole }

            //    );


            //context.Classes.AddOrUpdate(
            //    x => x.Id,
            //    clas
            //    );

            //context.Periods.AddOrUpdate(
            //    x => x.Id,
            //    period,
            //    new Period { Number = 2, Year = 2016, ToDate = "18 de Abril", FromDate = "28 de Junio", IsCurrent = true },
            //    new Period { Number = 2, Year = 2016, ToDate = "18 de Julio", FromDate = "27 de Septiembre", IsCurrent = false },
            //    new Period { Number = 2, Year = 2016, ToDate = "10 de Octubre", FromDate = "20 de Dicembre", IsCurrent = false }
            //    );

            //context.Projects.AddOrUpdate(
            //    x => x.Id,
            //    project
            //    );

            //context.ProjectMajorRels.AddOrUpdate(
            //    x => x.Id,
            //    projectMajor
            //    );

            //context.Sections.AddOrUpdate(
            //    x => x.Id,
            //    section
            //    );

            //context.SectionUserRels.AddOrUpdate(
            //    x => x.Id,
            //    new SectionUser { User = user, Section = section }
            //    );
            //context.SectionProjectsRels.AddOrUpdate(
            //    x => x.Id,
            //    sectionProject
            //    );

            //context.Hours.AddOrUpdate(
            //    x => x.Id,
            //    new Hour { Amount = 5, SectionProject = sectionProject, User = user2 }
            //    );
            //context.Faculties.AddOrUpdate(
            //    fac1, fac2
            //    );
        }
    }
}

