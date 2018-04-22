package app;
import java.util.List;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import model.Product;
import services.ProductService;

@RestController
public class ProductController {
	private ProductService service;
	
	public ProductController() {
		this.service = new ProductService();
	}
		
    @GetMapping("api/products")
    public List<Product> listProducts() {
    	return service.getAllProducts();
    }
}
