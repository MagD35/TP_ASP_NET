using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP4.Models;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Utils
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());
        public static FakeDb Instance { get { return lazy.Value; } }

        private void InitialiserDatas()
        {
            pizzas.Add(new Pizza(1, "La Reine"));
            pizzas.Add(new Pizza(2, "La Calzone"));
        }

        private FakeDb()
        {            
            this.InitialiserDatas();
        }

        public List<Pizza> pizzas { get; } = new List<Pizza>();

        public List<Ingredient> ingredients = Pizza.IngredientsDisponibles;
        public List<Pate> pates = Pizza.PatesDisponibles;


    }
}