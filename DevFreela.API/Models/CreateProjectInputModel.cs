namespace DevFreela.API.Models
{
    public class CreateProjectInputModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Idclient { get; set; }
        public int IdFreelancer { get; set; } 
        
        public decimal TotalCost { get; set; }  




    }
}
