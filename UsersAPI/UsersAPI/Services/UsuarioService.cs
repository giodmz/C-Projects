﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Data.Dtos;
using UsersAPI.Models;

namespace UsersAPI.Services
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService (IMapper mapper, 
            UserManager<Usuario> userManager, 
            SignInManager<Usuario> signInManager,
            TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task CadastraUsuario(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

         if (!resultado.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário.");
            }

        }

        public async Task Login(LoginUsuarioDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado");
            }

            _tokenService.GenerateToken(usuario);
        }

    
    }

}