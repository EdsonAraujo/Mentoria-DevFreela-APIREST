﻿namespace DevFreela.API.Models
{
    public class UpdateProjectInputModel
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public int Idclient { get; set; }
        
        public decimal TotalCost { get; set; }

    }
}
