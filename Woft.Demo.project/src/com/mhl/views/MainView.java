package com.mhl.views;

import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Cursor;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridLayout;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.File;
import java.io.IOException;
import java.util.Calendar;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JSplitPane;
import javax.swing.JToolBar;
import javax.swing.Timer;

import com.mhl.utils.FontUtil;

public class MainView extends JFrame implements ActionListener,MouseListener{

	Image titleIco;// ����ͼ��
	Image timebackground; // ʱ�䱳��ͼ
	
	JMenuBar menuBar;//�˵���
	
	JMenu menu_system; //ϵͳ�˵�
	JMenu menu_human; // ���²˵�
	JMenu menu_menu; // ��Ͳ˵�
	JMenu menu_statistic; // ͳ�Ʋ˵�
	JMenu menu_store; // ���˵�
	JMenu menu_help; //�����˵�
	
	JMenuItem menuItem_changeUser,menuItem_bill,menuItem_login,menuItem_calendar,menuItem_exit;
	
	ImageIcon icon_bill,icon_calender,icon_changeUser,icon_exit,icon_userLogin;
	
	JToolBar toolBar;
	
	JButton btn_sys,btn_human,btn_menu,btn_staic,btn_store,btn_help;
	
	JPanel leftPanel,panel2,operatePanel,rightPanel,mainPanel;
	
	JLabel currentTimeLabel;
	
	JLabel lb1,lb2,lb3,lb4,lb5,lb6,lb7,lb8;
	
	JLabel p2_label,p2_Label2;
	
	javax.swing.Timer timer;
	
	Cursor myCursor = null;
	
	JSplitPane splitPane;
	
	CardLayout cardLayout,cardLayout2;
	
	ImagePanel imagePanel;
	
	Image p1_backImage,main_backImage;
	
	public static void main(String[] args){
		MainView view = new MainView();
	}
	
	
	private void initialMenu()
	{
		icon_bill = new ImageIcon("Resources\\images\\menuBar\\bill.png");
		icon_calender = new ImageIcon("Resources\\images\\menuBar\\calendar.png");
		icon_changeUser = new ImageIcon("Resources\\images\\menuBar\\changeUser.png");
		icon_exit = new ImageIcon("Resources\\images\\menuBar\\exit.png");
		icon_userLogin = new ImageIcon("Resources\\images\\menuBar\\userLogin.png");
		
		menu_system = new JMenu("ϵͳ����");
		menu_system.setFont(FontUtil.f1);
		
		menuItem_changeUser = new JMenuItem("�л��û�",icon_changeUser);
		menuItem_changeUser.setFont(FontUtil.f2);
		menu_system.add(menuItem_changeUser);
		
		menuItem_bill = new JMenuItem("�տ����",icon_bill);
		menuItem_bill.setFont(FontUtil.f2);
		menu_system.add(menuItem_bill);
		
		menuItem_login = new JMenuItem("��¼����",icon_userLogin);
		menuItem_login.setFont(FontUtil.f2);
		menu_system.add(menuItem_login);
		
		menuItem_calendar = new JMenuItem("��������",icon_calender);
		menuItem_calendar.setFont(FontUtil.f2);
		menu_system.add(menuItem_calendar);
		
		menuItem_exit = new JMenuItem("�˳�ϵͳ",icon_exit);
		menuItem_exit.setFont(FontUtil.f2);
		menu_system.add(menuItem_exit);
		
		
		menu_human = new JMenu("���¹���");
		menu_human.setFont(FontUtil.f1);
		menu_menu = new JMenu("�˵�����");
		menu_menu.setFont(FontUtil.f1);
		menu_statistic = new JMenu("�������");
		menu_statistic.setFont(FontUtil.f1);
		menu_store = new JMenu("�ɱ��ⷿ");
		menu_store.setFont(FontUtil.f1);
		menu_help = new JMenu("ϵͳ����");
		menu_help.setFont(FontUtil.f1);
		
		menuBar = new JMenuBar();
		menuBar.add(menu_system);
		menuBar.add(menu_human);
		menuBar.add(menu_menu);
		menuBar.add(menu_statistic);
		menuBar.add(menu_store);
		menuBar.add(menu_help);
		
		this.setJMenuBar(menuBar);
		
	}

	private void initialToolBar(){
		toolBar = new JToolBar();
		// �Ƿ���Ը���
		toolBar.setFloatable(false);
		
		btn_sys = new JButton(new ImageIcon("Resources\\images\\toolBars\\system.png"));
		btn_help = new JButton(new ImageIcon("Resources\\images\\toolBars\\help.png"));
		btn_human = new JButton(new ImageIcon("Resources\\images\\toolBars\\user.png"));
		btn_menu = new JButton(new ImageIcon("Resources\\images\\toolBars\\menu.png"));
		btn_staic = new JButton(new ImageIcon("Resources\\images\\toolBars\\statistics.png"));
		btn_store = new JButton(new ImageIcon("Resources\\images\\toolBars\\store.png"));
	
		toolBar.add(btn_sys);
		toolBar.add(btn_human);
		toolBar.add(btn_menu);
		toolBar.add(btn_staic);
		toolBar.add(btn_store);
		toolBar.add(btn_help);
	}

	private void allPanels(){
		leftPanel = new JPanel(new BorderLayout());
		
		try{
			p1_backImage = ImageIO.read(new File("Resources\\images\\center\\jp1_bg.jpg"));
		}catch (IOException e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		myCursor = new Cursor(Cursor.HAND_CURSOR);
		
		this.imagePanel = new ImagePanel(p1_backImage);
		this.imagePanel.setLayout(new GridLayout(8,1));
		
		this.lb1 = new JLabel(new ImageIcon("Resources\\images\\center\\label_1.gif"));
		this.lb1.setFont(FontUtil.f3);
		this.lb1.setCursor(myCursor);
		this.lb1.addMouseListener(this);
		this.imagePanel.add(this.lb1);
		
		this.lb2 = new JLabel("���¹���",new ImageIcon("Resources\\images\\center\\hr.png"),0);
		this.lb2.setFont(FontUtil.f3);
		this.lb2.setEnabled(false);
		this.lb2.addMouseListener(this);
		this.lb2.setCursor(myCursor);
		this.imagePanel.add(this.lb2);
		
		this.lb3 = new JLabel("��¼����",new ImageIcon("Resources\\images\\center\\user.png"),0);
		this.lb3.setFont(FontUtil.f3);
		this.lb3.setEnabled(false);
		this.lb3.addMouseListener(this);
		this.lb3.setCursor(myCursor);
		this.imagePanel.add(this.lb3);
		
		this.lb4 = new JLabel("���׼۸�",new ImageIcon("Resources\\images\\center\\archives.png"),0);
		this.lb4.setFont(FontUtil.f3);
		this.lb4.setEnabled(false);
		this.lb4.addMouseListener(this);
		this.lb4.setCursor(myCursor);
		this.imagePanel.add(this.lb4);
		
		this.lb5 = new JLabel("����ͳ��",new ImageIcon("Resources\\images\\center\\pie_statistic.png"),0);
		this.lb5.setFont(FontUtil.f3);
		this.lb5.setEnabled(false);
		this.lb5.addMouseListener(this);
		this.lb5.setCursor(myCursor);
		this.imagePanel.add(this.lb5);
		
		this.lb6 = new JLabel("�ɱ����",new ImageIcon("Resources\\images\\center\\database.png"),0);
		this.lb6.setFont(FontUtil.f3);
		this.lb6.setEnabled(false);
		this.lb6.addMouseListener(this);
		this.lb6.setCursor(myCursor);
		this.imagePanel.add(this.lb6);
		
		this.lb7 = new JLabel("ϵͳ����",new ImageIcon("Resources\\images\\center\\settings.png"),0);
		this.lb7.setFont(FontUtil.f3);
		this.lb7.setEnabled(false);
		this.lb7.addMouseListener(this);
		this.lb7.setCursor(myCursor);
		this.imagePanel.add(this.lb7);
		
		this.lb8 = new JLabel("��������",new ImageIcon("Resources\\images\\center\\lamp_active.png"),0);
		this.lb8.setFont(FontUtil.f3);
		this.lb8.setEnabled(false);
		this.lb8.addMouseListener(this);
		this.lb8.setCursor(myCursor);
		this.imagePanel.add(this.lb8);
		
		this.leftPanel.add(this.imagePanel);
		
		this.rightPanel = new JPanel(new BorderLayout());
		cardLayout = new CardLayout();
		panel2 = new JPanel(this.cardLayout);
		p2_label = new JLabel(new ImageIcon("Resources\\images\\center\\jp2_left.jpg"));
		p2_label.addMouseListener(this);
		
		p2_Label2 = new JLabel(new ImageIcon("Resources\\images\\center\\jp2_right.jpg"));
		p2_Label2.addMouseListener(this);
		panel2.add(p2_label,"0");
		panel2.add(p2_Label2,"1");
		
		this.cardLayout2 = new CardLayout();
		operatePanel = new JPanel(this.cardLayout2);
		try{
			main_backImage = ImageIO.read(new File("Resources\\images\\bg\\bg1.jpg"));
		}catch (IOException e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
		ImagePanel imagePanel1 = new ImagePanel(main_backImage);
		operatePanel.add(imagePanel1,"0");
		
		//panel3.add(,"1");
		
		JLabel dLabel = new JLabel(new ImageIcon("esources\\images\\center\\denglu_img.jpg"));
		
		operatePanel.add(dLabel,"2");
		rightPanel.add(panel2,"West");
		rightPanel.add(operatePanel,"Center");
		
		// ��ַ�ʽ
		this.splitPane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT,leftPanel,rightPanel);
		
		//ָ����������
		this.splitPane.setDividerLocation(160);
		// ���÷ָ��߿��
		this.splitPane.setDividerSize(0);
	}
	
	private void initialStatusBar(){
		mainPanel = new JPanel(new BorderLayout());
		
		timer = new Timer(1000,this);
		timer.start();
		
		currentTimeLabel = new JLabel("��ǰʱ��: "+Calendar.getInstance().getTime().toString());
		
		try{
			timebackground = ImageIO.read(new File("Resources\\images\\center\\time_bg.jpg"));
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
		ImagePanel imagePanel = new ImagePanel(timebackground);
		imagePanel.setLayout(new BorderLayout());
		imagePanel.add(currentTimeLabel,"East");
		mainPanel.add(imagePanel);
	}
	
	public MainView()
	{
		try{
			titleIco = ImageIO.read(new File("Resources/images/title.png"));
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
		this.initialMenu();
		
		this.initialToolBar();
		
		this.allPanels();
		
		this.initialStatusBar();
		
		java.awt.Container container = this.getContentPane();
		container.add(toolBar,"North");
		container.add(splitPane,"Center");
		container.add(mainPanel,"South");
		
		Dimension dimension = Toolkit.getDefaultToolkit().getScreenSize();
		
		this.setTitle("����¥��������ϵͳ");
		this.setIconImage(titleIco);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setSize(dimension.width,dimension.height-30);
		this.setVisible(true);
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		this.currentTimeLabel.setText("��ǰʱ��: "+Calendar.getInstance().getTime().toString());
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		// TODO Auto-generated method stub
		
		Object object = e.getSource();
		
		if(object == this.lb1){
			this.cardLayout2.show(this.operatePanel, "0");
		}else if(object == this.lb2){
			this.cardLayout2.show(this.operatePanel, "1");
		}else if(object == this.lb3){
			this.cardLayout2.show(this.operatePanel, "2");
		}else if(object == p2_label){
			this.cardLayout.show(this.panel2, "1");
			this.splitPane.setDividerLocation(0);
		}else if(object == this.p2_Label2){
			this.cardLayout.show(this.panel2, "0");
			this.splitPane.setDividerLocation(160);
		}
		
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		// TODO Auto-generated method stub
		Object object = e.getSource();
		// ����û�ѡ��ĳ��Jlabel,�����
		JLabel[] labels = {lb2,lb3,lb4,lb5,lb6,lb7,lb8};
		for(int i =0;i<labels.length;i++)
		{
			JLabel label = labels[i];
			if(object == labels[i])
			{
				label.setEnabled(true);
			}else{
				label.setEnabled(false);
			}
		}
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mousePressed(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		// TODO Auto-generated method stub
		
	}

}
