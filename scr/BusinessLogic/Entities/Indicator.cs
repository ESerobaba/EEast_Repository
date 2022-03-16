using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    /// <summary>
    /// Структура данных показаний счетчиков
    /// </summary>
    [Serializable]
    public class Indicator
    {
        [Key]
        public int Id { get; set; }
        
        public int Indicators { get; set; }
        /// <summary>
        /// Заводской номер счетчика
        /// </summary> 
        public string FactoryNumberr { get; set; }
        /// <summary>
        /// Тип счетчика
        /// </summary>
        public string CounterType { get; set; }
        /// <summary>
        /// Время снятия показаний
        /// </summary>
        public DateTime TimeOfRead { get; set; }
        /// <summary>
        /// Общая сумма показаний по всем тарифам счетчика
        /// </summary>
        public Double CounterAmount { get; set; }
        /// <summary>
        /// Тариф 1
        /// </summary>
        public Double CounterRate1 { get; set; }
        /// <summary>
        /// Тариф 2
        /// </summary>
        public Double CounterRate2 { get; set; }
        /// <summary>
        /// Тариф 3
        /// </summary>
        public Double CounterRate3 { get; set; }
        /// <summary>
        /// Тариф 4
        /// </summary>
        public Double CounterRate4 { get; set; }
        /// <summary>
        /// Статус работоспособности (Ok - true)
        /// </summary>
        public String CounterStatus { get; set; }
        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        [ForeignKey("Customers")]
        public Customer? CustomerId { get; set; }
    }
}
