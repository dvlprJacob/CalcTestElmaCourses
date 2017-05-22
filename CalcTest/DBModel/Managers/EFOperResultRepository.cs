﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel.Helpers;
using WebCalc.Managers;
using System.Data.Entity;
using DBModel.Models;
using DBModel.Helpers;

namespace DBModel.Managers
{
    public class EFOperResultRepository : BaseRepository<OperationResult>, IOperationResultRepository
    {
        private DbSet<OperationResult> OperationResults { get; set; }

        public EFOperResultRepository(DbContext context) : base(context)
        {
            OperationResults = context.Set<OperationResult>();
        }

        public override IEnumerable<OperationResult> GetAll()
        {
            return OperationResults.ToList();
        }

        public override IEnumerable<OperationResult> GetAll(bool flag)
        {
            return flag ? OperationResults.Include(item => item.Iniciator).ToList() : GetAll();
        }

        public override void Save(OperationResult entity)
        {
            OperationResults.Add(entity);
            _db.SaveChanges();
        }
    }
}