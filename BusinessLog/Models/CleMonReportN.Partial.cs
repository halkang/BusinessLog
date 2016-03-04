namespace BusinessLog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    [MetadataType(typeof(CleMonReportNMetaData))]
    public partial class CleMonReportN
    {


        public CleMonReportN()
        {
            RowStatus = "Y";
            廢棄物來源是否為事業單位 = "0";
            委託單位證號 = string.Empty;
        }
    }

    public partial class CleMonReportNMetaData
    {
        [Required]
        public int RowIndex { get; set; }

        [StringLength(1, ErrorMessage = "欄位長度不得大於 1 個字元")]
        [Required]
        public string 廢棄物來源是否為事業單位 { get; set; }

        [StringLength(70, ErrorMessage = "欄位長度不得大於 70 個字元")]
        [Required]
        public string 委託單位名稱 { get; set; }

        [StringLength(60, ErrorMessage = "欄位長度不得大於 60 個字元")]
        [Required(AllowEmptyStrings = true)]
        public string 委託單位證號 { get; set; }

        [StringLength(120, ErrorMessage = "欄位長度不得大於 120 個字元")]
        [Required]
        public string 委託單位地址 { get; set; }

        [StringLength(255, ErrorMessage = "欄位長度不得大於 255 個字元")]
        [Required]
        public string 縣市別代碼 { get; set; }

        [StringLength(4, ErrorMessage = "欄位長度不得大於 4 個字元")]
        [Required]
        public string 行業別代碼 { get; set; }

        [StringLength(15, ErrorMessage = "欄位長度不得大於 15 個字元")]
        [Required]
        public string 六聯單單號 { get; set; }
        [Required]
        public int 廢棄物編號 { get; set; }
        [Required]
        public float 清除量 { get; set; }
        [Required]
        public System.DateTime 清除日期 { get; set; }

        [StringLength(70, ErrorMessage = "欄位長度不得大於 70 個字元")]
        [Required]
        public string 清除方法 { get; set; }

        [StringLength(70, ErrorMessage = "欄位長度不得大於 70 個字元")]
        [Required]
        public string 貯存地點 { get; set; }

        [StringLength(255, ErrorMessage = "欄位長度不得大於 255 個字元")]
        [Required]
        public string 中間或最終處置地點代碼 { get; set; }
        [Required]
        public System.DateTime 中間或最終處置到達日期 { get; set; }

        [StringLength(8, ErrorMessage = "欄位長度不得大於 8 個字元")]
        [Required]
        public string 清運_x0028_除_x0029_機具車號 { get; set; }

        [StringLength(8, ErrorMessage = "欄位長度不得大於 8 個字元")]
        [Required]
        public string 清運_x0028_除_x0029_機具拖車車尾車號 { get; set; }

        [StringLength(1, ErrorMessage = "欄位長度不得大於 1 個字元")]
        [Required]
        public string RowStatus { get; set; }
    }
}
