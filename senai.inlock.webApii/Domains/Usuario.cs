﻿namespace senai.inlock.webApi.Domains
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public int IdTipoUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
