using System.Text;

namespace Assets.Scripts.PorojdayoushiePatterns.Builder
{
    abstract class Builder
    {
        public class Flour
        {            
            public string Sort { get; set; }
        }
       
        public class Salt
        { }
        
        public class Additives
        {
            public string Name { get; set; }
        }

        public class Bread
        {
            
            public Flour Flour { get; set; }
            
            public Salt Salt { get; set; }
            
            public Additives Additives { get; set; }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (Flour != null)
                    sb.Append(Flour.Sort + "\n");
                if (Salt != null)
                    sb.Append("���� \n");
                if (Additives != null)
                    sb.Append("�������: " + Additives.Name + " \n");
                return sb.ToString();
            }
        }
    }
}
