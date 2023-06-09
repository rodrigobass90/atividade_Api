using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositories
{
public class ProjetoRepository
{

private readonly ExecutionContext _context;
public ProjetoRepository(ExecutionContext context)
{
 _context = context;
}
public List<Projeto> Listar()
{
return _context.Projetos.ToList();
}
}
}