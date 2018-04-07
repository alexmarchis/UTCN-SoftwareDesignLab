package app;

import java.util.ArrayList;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import model.Product;

@Controller
public class ProductController {

    @GetMapping("/products")
    public String listProducts(Model model) {
    	ArrayList<Product> products = new ArrayList<Product>();
    	Product x = new Product();
    	x.setName("Cana");
    	products.add(x);
    	x = new Product();
    	x.setName("Tricou");
    	products.add(x);
    	x = new Product();
    	x.setName("Ghiozdan");
    	products.add(x);
    	
        model.addAttribute("products", products);
        return "products";
    }

}
