namespace Midterm {
	public class Library {
		private List<IMaterial> allMaterials {get; set;}
		
		public Library() {
			allMaterials =  new ();
		}
		
		public void AddMaterial(IMaterial material) {
			if (!allMaterials.Contains(material)) {  
				allMaterials.Add(material);
			}
			else {
				Console.WriteLine("Material already in list");
			}
		}
		
		public void ShowMaterials() {
			foreach (var material in allMaterials) {
				material.GetInfo();
			}
		}
	}
}