using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Ploom.Models;

namespace Ploom.Db
{
    public class CRUDOperation
    {
        readonly SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Busket>();
            db.CreateTable<Furniture>();
            db.CreateTable<Client>();
            db.CreateTable<Order>();
            db.CreateTable<Courier>();
            db.CreateTable<Delivery>();
        }
        public IEnumerable<Furniture> GetFurnituress()
        {
            return db.Table<Furniture>();
        }
        public IEnumerable<Client> GetClients()
        {
            return db.Table<Client>();
        }
        public IEnumerable<Busket> GetBasket()
        {
            return db.Table<Busket>();
        }
        public Furniture GetProjectItem(int id)
        {
            return db.Get<Furniture>(id);
        }

        public int DeleteFurnitureInBusket(int id) { return db.Delete<Busket>(id); }
        public int DeleteFurniture(int id) { return db.Delete<Furniture>(id); }

        public int SaveFurniture(Furniture projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

        public int SaveBasket(Busket projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

        public int SaveClient(Client projectModel)
        {
            return db.Insert(projectModel);
        }
    }
}
