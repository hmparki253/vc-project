﻿using BizOneShot.Light.Dao.Infrastructure;
using BizOneShot.Light.Dao.Repositories;
using BizOneShot.Light.Models.WebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizOneShot.Light.Services
{
    public interface ITcmsIfLastReportService : IBaseService
    {
        Task<IList<TcmsIfLastReport>> getTcmsIfSurvey();
        Task<TcmsIfLastReport> getTcmsIfSurveyByInfId(string infId);
        void Insert(TcmsIfLastReport tcmsIfLastReport);

        Task<TcmsIfLastReport> getTcmsIfLastReportInfo(int compKey, int baKey, int mentorKey, string conCode);
    }


    public class TcmsIfLastReportService : ITcmsIfLastReportService
    {
        private readonly ITcmsIfLastReportRepository tcmsIfLastReportRepository;
        private readonly IUnitOfWork unitOfWork;

        public TcmsIfLastReportService(ITcmsIfLastReportRepository tcmsIfLastReportRepository, IUnitOfWork unitOfWork)
        {
            this.tcmsIfLastReportRepository = tcmsIfLastReportRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<TcmsIfLastReport>> getTcmsIfSurvey()
        {
            return await tcmsIfLastReportRepository.getTcmsIfSurvey();
        }

        public async Task<TcmsIfLastReport> getTcmsIfSurveyByInfId(string infId)
        {
            return await tcmsIfLastReportRepository.getTcmsIfSurveyByInfId(infId);
        }

        public void Insert(TcmsIfLastReport tcmsIfLastReport)
        {
            tcmsIfLastReportRepository.Insert(tcmsIfLastReport);
        }

        public async Task<TcmsIfLastReport> getTcmsIfLastReportInfo(int compKey, int baKey, int mentorKey, string conCode)
        {

            return await tcmsIfLastReportRepository.getTcmsIfLastReportInfo(compKey, baKey, mentorKey, conCode);

        }

        public void SaveDbContext()
        {
            unitOfWork.Commit();
        }

        public async Task<int> SaveDbContextAsync()
        {
            return await unitOfWork.CommitAsync();
        }
    }
}