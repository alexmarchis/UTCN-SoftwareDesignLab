import javax.swing.JFrame;

public class App {
    private static void createAndShowGUI() {
        ReportView reportView = new ReportView();
        JFrame frame = reportView.GetReportFrame();

        //Display the window.
        frame.pack();
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        //Schedule a job for the event-dispatching thread:
        //creating and showing this application's GUI.
        javax.swing.SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });
    }
}