﻿namespace ShoppingCart.Model.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public string Role { get; set; }
        public string Token { get; set; }
    }
}
