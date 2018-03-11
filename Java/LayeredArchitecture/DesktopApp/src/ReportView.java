import java.awt.Container;

import javax.swing.JFrame;
import javax.swing.JLabel;

public class ReportView {
	public JFrame GetReportFrame() {
		TicketService ticketService = new TicketService();
		int total = ticketService.GetTotalRevenue();
		
		JFrame frame = new JFrame("Report");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Container contentPane = frame.getContentPane();
        //Add the ubiquitous "Hello World" label.
        JLabel label = new JLabel("Total Cost: " + total);
        contentPane.add(label);
        
        return frame;
	}
}
