using ApiDDD.Application.Contracts;
using ApiDDD.Application.Services;
using ApiDDD.Domain.Contracts.Repositories;
using ApiDDD.Domain.Contracts.Services;
using ApiDDD.Domain.Services;
using ApiDDD.Infra.Data.Context;
using ApiDDD.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ApiDDD.Presentation.Configurations
{
    public class DependencyInjectionConfigurartion
    {
        public static void ConfigurationServices(IServiceCollection services)
        {
            #region Camada de InfraEstrutura (repositorio)
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IAlunoRepository, AlunoRepository>();
            services.AddTransient<IProfessorRepository, ProfessorRepository>();
            services.AddTransient<ITurmaRepository, TurmaRepository>();
            services.AddTransient<ITurmaAlunoRepository, TurmaAlunoRepository>();
            #endregion

            #region Camada de Dominio (domain)
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient<IAlunoDomainService, AlunoDomainService>();
            services.AddTransient<IProfessorDomainService, ProfessorDomainService>();
            services.AddTransient<ITurmaDomainService, TurmaDomainService>();
            services.AddTransient<ITurmaAlunoDomainService, TurmaAlunoDomainService>();
            #endregion

            #region Camada de Aplicacao (application)
            services.AddTransient<IUsuarioApplicationServices, UsuarioApplicationService>();
            services.AddTransient<IAlunoApplicationServices, AlunoApplicationService>();
            services.AddTransient<IProfessorApplicationServices, ProfessorApplicationService>();
            services.AddTransient<ITurmaApplicationServices, TurmaApplicationService>();
            
            #endregion
        }
    }
}
