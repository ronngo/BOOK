using BOOK.DAL.Interface;
using BOOK.Domian.Request;
using BOOK.Domian.Response;
using Dapper;
using PXUK16.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BOOK.DAL
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@NameBook", request.NameBook);
                parameters.Add("@NameAuthor", request.NameAuthor);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Date", request.Date);
                parameters.Add("@Amount", request.Amount);


                return await SqlMapper.QueryFirstOrDefaultAsync<CreateBookResult>(cnn: connect,
                                                    sql: "sp_CreateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
               

                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteBookResult>(cnn: connect,
                                                    sql: "sp_DeleteBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Book>> Gets()
        {
            return await SqlMapper.QueryAsync<Book>(cnn: connect,
                                                sql: "sp_GetBook",
                                                commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                parameters.Add("@NameBook", request.NameBook);
                parameters.Add("@NameAuthor", request.NameAuthor);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Date", request.Date);
                parameters.Add("@Amount", request.Amount);


                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateBookResult>(cnn: connect,
                                                    sql: "sp_UpdateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
