package com.mhl.moduls;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.util.Hashtable;
import java.util.Vector;

import com.mhl.models.DataTable;


public class DbSession {

	PreparedStatement ps = null;
	ResultSet rs = null;
	Connection ct = null;
	String driverName = "com.mysql.jdbc.Driver";
	String url = "jdbc:mysql://127.0.0.1:3306/mhl";
	String user = "root";
	String pwd = "root";
	
	/**
	 * ������
	 */
	private void openConnenction()
	{
		try{
			Class.forName(driverName);
			ct = DriverManager.getConnection(url,user,pwd);
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
	}
	
	/**
	 * ִ����ɾ�Ĳ���
	 * @param cmdText ����SQL���
	 * @param params ��ֹSQLע�룬����
	 * @return ��Ӱ�������
	 */
	public int executeNonQuery(String cmdText,String[] params)
	{
		openConnenction();
		int result = 0;
		try{
			ps = ct.prepareStatement(cmdText);
			for(int i = 0;i<params.length;i++){
				ps.setString(i+1, params[i]);
			}
			result = ps.executeUpdate();
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
			System.out.println("executeNonQuery Error.");
		}finally{
			this.close();
		}
		return result;
	}
	
	/**
	 * ִ�в�ѯ����
	 * @param cmdText SQL���
	 * @param params ��ֹSQLע�룬����
	 * @return ��ѯ���
	 */
	public DataTable executeNonTable(String cmdText,String[] params){
		
		openConnenction();
		DataTable dt = null;
		try{
			ps = ct.prepareStatement(cmdText);
			
			for(int i = 0;i<params.length;i++){
				ps.setString(i+1, params[i]);
			}
			rs = ps.executeQuery();
			dt = fillDataTable(rs);
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
			System.out.println("executeNonResult error.");
		}finally{
			this.close();
		}
		return dt;
	}
	
	private DataTable fillDataTable(ResultSet rs){
		DataTable dt = new DataTable();
		try{
			ResultSetMetaData rsmd = rs.getMetaData();
			for(int i = 0;i<rsmd.getColumnCount();i++){
				dt.getColumns().add(rsmd.getColumnName(i+1));
			}
			
			while(rs.next()){
				Vector<String> temp = new Vector<String>();
				for(int i =0;i<rsmd.getColumnCount();i++){
					temp.add(rs.getString(i+1));
				}
				dt.getRows().add(temp);
			}
			
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		return dt;
	}
	
	/**
	 * ���ݿ�رղ���
	 */
	private void close(){
		try{
			
			if(rs!=null)
			{
				rs.close();
			}
			if(ps!=null){
				ps.close();
			}
			if(!ct.isClosed())
			{
				ct.close();
			}
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
			System.out.println("close error.");
		}
	}
	
}
