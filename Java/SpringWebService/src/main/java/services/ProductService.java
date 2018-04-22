package services;

import java.util.Arrays;
import java.util.List;

import org.springframework.http.ResponseEntity;
import org.springframework.web.client.RestTemplate;

import model.Product;

public class ProductService {
	public List<Product> getAllProducts(){
		RestTemplate restTemplate = new RestTemplate();
        ResponseEntity<Product[]> responseEntity = restTemplate.getForEntity("https://sheetsu.com/apis/v1.0su/4b5f913a1f97/", Product[].class);
        Product[] products = responseEntity.getBody();
        return Arrays.asList(products);
	}
}