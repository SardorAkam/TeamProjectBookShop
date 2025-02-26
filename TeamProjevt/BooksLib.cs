using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop
{
    internal class BooksLib
    {
        public static string[,] Books { get; set; } = new string[100, 3];
        public void DefBooks()
        {
            Books[0, 0] = "Shaytanat 1 - kitob";
            Books[0, 1] = "Timur Malik";
            Books[0, 2] = "Mutolaa qilayotganingiz “Shaytanat” asarida " +
                "muallif Tohir Malik sobiq Sovet davlati parchalanishi arafasida " +
                "Oʻzbekiston SSRdagi ijtimoiy-siyosiy hayot, " +
                "tobora avj olib borayotgan mafiya, jinoyatchilik, " +
                "poraxoʻrlikni va ular natijasida oddiy xalq boshiga tushayotgan koʻrguliklarni ochiq-oydin tasvirlab beradi. " +
                "Aholi ustidan olib borilayotgan siyosat naqadar ogʻir va notoʻgʻri ekanligini isbotlashga urinadi. " +
                "Asar jami 5 kitobdan iborat bo'lib, ushbu kitob uning 1-qismidir.";
            Books[1, 0] = "Shaytanat 2 - kitob";
            Books[1, 1] = "Timur Malik";
            Books[1, 2] = "Mutolaa qilayotganingiz “Shaytanat” asarida " +
                "muallif Tohir Malik sobiq Sovet davlati parchalanishi arafasida " +
                "Oʻzbekiston SSRdagi ijtimoiy-siyosiy hayot, " +
                "tobora avj olib borayotgan mafiya, jinoyatchilik, " +
                "poraxoʻrlikni va ular natijasida oddiy xalq boshiga tushayotgan koʻrguliklarni ochiq-oydin tasvirlab beradi. " +
                "Aholi ustidan olib borilayotgan siyosat naqadar ogʻir va notoʻgʻri ekanligini isbotlashga urinadi. " +
                "Asar jami 5 kitobdan iborat bo'lib, ushbu kitob uning 2-qismidir.";
            Books[2, 0] = "Shaytanat 3 - kitob";
            Books[2, 1] = "Timur Malik";
            Books[2, 2] = "Mutolaa qilayotganingiz “Shaytanat” asarida " +
                "muallif Tohir Malik sobiq Sovet davlati parchalanishi arafasida " +
                "Oʻzbekiston SSRdagi ijtimoiy-siyosiy hayot, " +
                "tobora avj olib borayotgan mafiya, jinoyatchilik, " +
                "poraxoʻrlikni va ular natijasida oddiy xalq boshiga tushayotgan koʻrguliklarni ochiq-oydin tasvirlab beradi. " +
                "Aholi ustidan olib borilayotgan siyosat naqadar ogʻir va notoʻgʻri ekanligini isbotlashga urinadi. " +
                "Asar jami 5 kitobdan iborat bo'lib, ushbu kitob uning 3-qismidir.";
            Books[3, 0] = "Shaytanat 4 - kitob";
            Books[3, 1] = "Timur Malik";
            Books[3, 2] = "Mutolaa qilayotganingiz “Shaytanat” asarida " +
                "muallif Tohir Malik sobiq Sovet davlati parchalanishi arafasida " +
                "Oʻzbekiston SSRdagi ijtimoiy-siyosiy hayot, " +
                "tobora avj olib borayotgan mafiya, jinoyatchilik, " +
                "poraxoʻrlikni va ular natijasida oddiy xalq boshiga tushayotgan koʻrguliklarni ochiq-oydin tasvirlab beradi. " +
                "Aholi ustidan olib borilayotgan siyosat naqadar ogʻir va notoʻgʻri ekanligini isbotlashga urinadi. " +
                "Asar jami 5 kitobdan iborat bo'lib, ushbu kitob uning 4-qismidir.";
            Books[4, 0] = "Shaytanat 5 - kitob";
            Books[4, 1] = "Timur Malik";
            Books[4, 2] = "Mutolaa qilayotganingiz “Shaytanat” asarida " +
                "muallif Tohir Malik sobiq Sovet davlati parchalanishi arafasida " +
                "Oʻzbekiston SSRdagi ijtimoiy-siyosiy hayot, " +
                "tobora avj olib borayotgan mafiya, jinoyatchilik, " +
                "poraxoʻrlikni va ular natijasida oddiy xalq boshiga tushayotgan koʻrguliklarni ochiq-oydin tasvirlab beradi. " +
                "Aholi ustidan olib borilayotgan siyosat naqadar ogʻir va notoʻgʻri ekanligini isbotlashga urinadi. " +
                "Asar jami 5 kitobdan iborat bo'lib, ushbu kitob uning 5-qismidir.";
            Books[5, 0] = "Sariq Devni Minib";
            Books[5, 1] = "Xudoyberdi Toʻxtaboyev";
            Books[5, 2] = "Xudoyberdi To‘xtaboyevning ushbu asari " +

                "sarguzashtlarga boy bo‘lib, o‘zbek " +
                "bolalar adabiyotining noyob durdonalaridan biridir. " +
                "Unda bolalikning sodda va samimiy, quvnoq va zavqli " +
                "onlari teran nigoh bilan qalamga olinadi. Bu asarni, asardagi kulgiga boy " +
                "sarguzashtlarni bemalol zamonaviy Garri Potterga qiyoslasa bo‘ladi. " +
                "Asarni o‘qib chiqsangiz, bunga amin bo‘lasiz.";
        }
    }
}
