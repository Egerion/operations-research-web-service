using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ORMonll.Enum;

namespace ORMonll.Entity
{
    [Table("OR_USER")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private long id;
        
        [Column(name:"NAME")]
        private string name;
        
        [Column(name:"SURNAME")]
        private string surname;
        
        [Column(name:"DISPLAY_NAME")]
        private string displayName;
        
        [Column(name:"E_MAIL")]
        private string email;
        
        [Column(name:"PASSWORD")]
        private string password;
        
        [Column(name:"AGE")]
        private int age;
        
        [Column(name:"GENDER")]
        private Gender gender;
        
        [Column(name:"INS_DATE")]
        private DateTime insDate;
        
        [Column(name:"IS_REGISTERED")]
        private Boolean isRegistered;

        public long Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string DisplayName
        {
            get => displayName;
            set => displayName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        public DateTime InsDate
        {
            get => insDate;
            set => insDate = value;
        }

        public bool IsRegistered
        {
            get => isRegistered;
            set => isRegistered = value;
        }
    }
}