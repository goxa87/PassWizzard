using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWizzard
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="Name">Имя пользователя</param>
        /// <param name="Login">Логин для входа</param>
        /// <param name="Password">Пароль для входа</param>
        public User (string Name, string Login, string Password)
        {
            this.Name = Name;
            this.Login = Login;
            this.Password = Password;
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Логин для входа в приложение
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль для входа в приложение
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Ключ шифрования
        /// </summary>
        public string Key { get; set; }
    }
}
