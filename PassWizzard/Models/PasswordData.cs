using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWizzard
{
    /// <summary>
    /// Данные для входа на внешний ресурс и информация о нём
    /// </summary>
    public class PasswordData
    {

        /// <summary>
        /// Создание пароля
        /// </summary>
        /// <param name="Password">Пароль</param>
        /// <param name="Purpose">Зачем нужнен пароль</param>
        public PasswordData(string Password, string Purpose)
        {
            this.Password = Password;
            this.Purpose = Purpose;
        }

        /// <summary>
        /// Логин для входа на внешний ресурс
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Созданный пароль для входа на внешний ресурс
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// От чего пароль. Зачем он нужен
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Надёжность пароля
        /// </summary>
        public string LevelOfSafety { get; set; }

        /// <summary>
        /// Логин пользователя, которому принадлжат данные для входа на внешний ресурс
        /// </summary>
        public string UsersLogin { get; set; }

    }
}
