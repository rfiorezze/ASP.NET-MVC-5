using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullTreino.Models
{
    public class Usuarios
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuarios()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Jose Carlos",
                sobrenome = "Macoratti",
                endereco = "Rua Projetada , 100",
                email = "macoratti@yahoo.com",
                nascimento = Convert.ToDateTime("05/09/1975")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Jefferson Andre",
                sobrenome = "Ribeiro",
                endereco = "Rua Mirassol , 50",
                email = "jeffbol@bol.com.br",
                nascimento = Convert.ToDateTime("13/08/1992")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Janice Lima",
                sobrenome = "Morais",
                endereco = "Rua Peru , 10",
                email = "janielima@hotmail.com",
                nascimento = Convert.ToDateTime("15/07/1990")
            });
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.email == usuarioModelo.email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;
                
            foreach (UsuarioModel _usuario in listaUsuarios)
                if (_usuario.email == Email)
                    _usuarioModel = _usuario;

            return _usuarioModel;
        }

        public void DeletarUsuario(String Email)
        {
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.email == Email)
                {
                    listaUsuarios.Remove(_usuario);

                    break;
                }
            }
        }
    }
}

