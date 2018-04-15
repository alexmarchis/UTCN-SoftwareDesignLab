package dataaccess;

import model.*;
import java.util.List;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.boot.MetadataSources;
import org.hibernate.boot.registry.StandardServiceRegistry;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;

public class ProductRepo {
	private static SessionFactory sessionFactory;
	
    public List<Product> getAll()
    {   
        setupHibernateSession();
       
		Session session = sessionFactory.openSession();
		session.beginTransaction();
		List<Product> result = session.createQuery( "from Product", Product.class)
				.getResultList();
		
		session.getTransaction().commit();
		session.close();
		
		return result;
    }
    
    private static void setupHibernateSession() {
    	final StandardServiceRegistry registry = new StandardServiceRegistryBuilder()
				.configure()
				.build();
		
        try {
        	sessionFactory = new MetadataSources( registry ).buildMetadata().buildSessionFactory();
		}
		catch (Exception e) {
			System.out.println(e.getMessage());
			StandardServiceRegistryBuilder.destroy( registry );
		}
    }
}
