using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Enums.PageModelEnum;

namespace Core.Model.Query
{
    public class DataGridModel
    {
        public DataGridModel()
        {

            PageInfo = new PageModel();
            OrderInfo = new OrderModel();
            SearchInfo = new SearchModel();
            FilterInfo = new FilterModel();
        }

        public PageModel PageInfo { get; set; }

        public OrderModel OrderInfo { get; set; }

        public SearchModel SearchInfo { get; set; }

        public FilterModel FilterInfo { get; set; }

    }
    public class OrderModel
    {
        public string? ColumnName { get; set; }

        public OrderType? OrderType { get; set; }
    }
    public class FilterModel
    {
        public FilterModel()
        {
            FilterOperator = FilterLogicalOperator.And;
            FilterCondition = new List<FilterConditionModel>();
        }
        public FilterLogicalOperator? FilterOperator { get; set; }

        public List<FilterConditionModel>? FilterCondition { get; set; }
    }
    public class FilterConditionModel
    {
        public string? ColumnName { get; set; }

        public FilterConditionOperator Operator { get; set; }
        public List<object>? Values { get; set; }

    }
    public class SearchModel
    {
        public SearchModel()
        {
            SearchOperator = FilterLogicalOperator.And;
            SearchRule = new List<SearchRule>();
        }

        public FilterLogicalOperator SearchOperator { get; set; }

        public List<SearchRule> SearchRule { get; set; }
    }
    public class SearchRule
    {
        public string? KeyWord { get; set; }
        public List<string>? SearchColumns { get; set; }

    }
}


