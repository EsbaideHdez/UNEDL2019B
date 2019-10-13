package test_operaciones;

import java.awt.GridLayout;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

public class Test_Operaciones extends JFrame {

    private JLabel lblNumero1;
    private JLabel lblNumero2;
    private JLabel lblVacio;
    private JLabel lblOperador;
    static private JTextField txtNumero1;
    static private JTextField txtNumero2;
    private JComboBox cbxOperador;
    private JButton btnOpercion;
    private Operacion o;

    public Test_Operaciones() {
        //operacion = new Operacion();
        setVisible(true);
        setLayout(new GridLayout(4, 2, 10, 10));
        setLocation(500, 500);
        setTitle("Operadores");

        lblNumero1 = new JLabel("Numero 1");
        lblNumero2 = new JLabel("Numero 2");
        lblVacio = new JLabel("");
        lblOperador = new JLabel("Operadores");

        txtNumero1 = new JTextField();
        txtNumero2 = new JTextField();

        cbxOperador = new JComboBox();
        //operadores aritmeticos
        cbxOperador.addItem("+");
        cbxOperador.addItem("-");
        cbxOperador.addItem("*");
        cbxOperador.addItem("/");
        cbxOperador.addItem("%");

        //operadores relacionales
        cbxOperador.addItem("<");
        cbxOperador.addItem("<=");
        cbxOperador.addItem(">");
        cbxOperador.addItem(">=");
        //operadores de equidad
        cbxOperador.addItem("!=");
        cbxOperador.addItem("==");

        //operadores logicos
        cbxOperador.addItem("&&");
        cbxOperador.addItem("||");
        //boton
        btnOpercion = new JButton("Operacion");

        add(lblNumero1);
        add(txtNumero1);
        add(lblNumero2);
        add(txtNumero2);
        add(lblOperador);
        add(cbxOperador);
        add(lblVacio);
        add(btnOpercion);

        btnOpercion.addActionListener(new ActionListener() {
            Operacion ref = new Operacion();

            @Override
            public void actionPerformed(ActionEvent e) {

                if (txtNumero1.getText().equals("")) {
                    JOptionPane.showMessageDialog(null, "Ingresa un numero");
                } else if (txtNumero2.getText().equals("")) {
                    JOptionPane.showMessageDialog(null, "Ingresa el segundo numero");
                } else {
                    String nu1 = txtNumero1.getText();
                    String nu2 = txtNumero2.getText();
                    String Operacioness = (String) cbxOperador.getSelectedItem();
                    
                    ref.Operacion(txtNumero1.getText(), txtNumero2.getText(), (String) cbxOperador.getSelectedItem());
                    ref.setOperacion2(txtNumero1.getText(), txtNumero2.getText(), (String) cbxOperador.getSelectedItem());

                }
               /// ref.setOperacion2(txtNumero1.getText(), txtNumero2.getText(), (String) cbxOperador.getSelectedItem());
            }

        });

        pack();
    }

    private void validarLetrasYEspacios(JTextField campo) {
        campo.addKeyListener(new KeyAdapter() {
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                if (Character.isLetter(c) || Character.isSpaceChar(c)) {
                    e.consume();
                }
            }
        });
    }

    public static void main(String[] args) {
        Test_Operaciones mi = new Test_Operaciones();
        mi.validarLetrasYEspacios(txtNumero1);
        mi.validarLetrasYEspacios(txtNumero2);

    }

}
