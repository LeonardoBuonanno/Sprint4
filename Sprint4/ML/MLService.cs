using Microsoft.ML;
using Sprint4.Models;

namespace Sprint4.ML
{
    public class MLService
    {
        private readonly MLContext _mlContext;

        public MLService()
        {
            _mlContext = new MLContext();
        }

        public RecommendationModel GerarRecomendacao(Product produto)
        {
            // Lógica de recomendação (exemplo simplificado)
            return new RecommendationModel
            {
                ProductId = produto.Id,
                Recomendacao = $"Recomendamos o produto {produto.Nome} com base em suas preferências."
            };
        }
    }
}
