package com.mhl.moduls;

import java.util.*;

public interface IDao<T> {

	/**
	 * ���һ������
	 * @param entity ����ʵ��
	 * @return ��Ӱ�������
	 */
	int add(T entity);
	
	/**
	 * ͨ��idɾ��һ������
	 * @param id ����ID
	 * @return ��Ӱ�������
	 */
	int delete(int id);
	
	/**
	 * ͨ��idɾ��һ������
	 * @param id ����ID
	 * @return ��Ӱ�������
	 */
	int delete(String id);
	
	/**
	 * ͨ��ʵ�����ɾ��һ������
	 * @param id ����ID
	 * @return ��Ӱ�������
	 */
	int delete(T entity);
	
	/**
	 * ��������
	 * @param entity
	 * @return ��Ӱ������
	 */
	int update(T entity);
	
	/**
	 * ͨ��ID��ȡһ������
	 * @param id
	 * @return
	 */
	T getEntity(int id);
	
	/**
	 * ͨ��ID��ȡһ������
	 * @param id
	 * @return
	 */
	T getEntity(String id);
	
	/**
	 * ��ȡ��������
	 * @return
	 */
	List<T> getAll();
	
	/**
	 * ͨ��������ȡ����
	 * @param condition
	 * @return
	 */
	List<T> getAll(String condition);
}
