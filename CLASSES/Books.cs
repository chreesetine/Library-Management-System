using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibrarySystem.CLASSES
{
    class Books
    {

        DATABASE.DB db = new DATABASE.DB();

        // create a function to add a new book
        // `book_id`, `title`, `isbn`, `author`, `genre`, `quantity`, `date_received`, `cover`
        public Boolean addBook(int book_id, string title, string isbn, string author, string genre, int quantity, string date_received, byte cover)
        {
            string query = "INSERT INTO `books`(`book_id`, `title`, `isbn`, `author`, `genre`, `quantity`, `date_received`, `cover`) VALUES (@book_id,@title,@isbn,@author,@genre,@quantity,@date_received,@cover)";

            MySqlParameter[] parameters = new MySqlParameter[8];
            // @book_id,@title,@isbn,@author,@genre,@quantity,@date_received,@cover

            parameters[0] = new MySqlParameter("@book_id", MySqlDbType.Int32);
            parameters[0].Value = book_id;

            parameters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[2].Value = isbn;

            parameters[3] = new MySqlParameter("@author", MySqlDbType.VarChar);
            parameters[3].Value = author;

            parameters[4] = new MySqlParameter("@genre", MySqlDbType.VarChar);
            parameters[4].Value = genre;

            parameters[5] = new MySqlParameter("@quantity", MySqlDbType.VarChar);
            parameters[5].Value = quantity;

            parameters[6] = new MySqlParameter("@date_received", MySqlDbType.VarChar);
            parameters[6].Value = date_received;

            parameters[7] = new MySqlParameter("@cover", MySqlDbType.Blob);
            parameters[7].Value = cover;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        // create a function to edit the selected book
        public Boolean editBook()
        {
            return true;
        }

        // create a function to remove a book
        public Boolean removeBook()
        {
            return true;
        }

        // create a function to return table of books
       /*public DataTable BooksList()
        {
            string query = "SELECT * FROM `books`";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }*/
       
        }
    }

