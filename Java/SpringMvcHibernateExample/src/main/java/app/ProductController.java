package app;

import java.util.List;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import dataaccess.ProductRepo;
import model.Product;

@Controller
public class ProductController {

	private ProductRepo productRepo;
	
	public ProductController() {
		productRepo = new ProductRepo();
	}
	
    @GetMapping("/products")
    public String listProducts(Model model) {
    	List<Product> products = productRepo.getAll();
        model.addAttribute("products", products);
        return "products";
    }
}
