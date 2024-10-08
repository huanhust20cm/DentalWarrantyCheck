import axiosInstance from '../axios-instance/index';

export const dental = {
  async createDental(Dental: Dental.IDentalModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.post('dental/createDental', Dental);
      return response.data;
    } catch (error) {
      console.error('An error occurred while adding the account:', error);
      throw error;
    }
  },

  async updateDental(Dental: Dental.IDentalModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.post('dental/updateDental', Dental);
      return response.data;
    } catch (error) {
      console.error('An error occurred while adding the account:', error);
      throw error;
    }
  },

  async getAllDental(model: Common.DataGridModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.post(`dental/getlistDental`, model);
      return response.data;
    } catch (error) {
      console.error('An error occurred while retrieving the customer:', error);
      throw error;
    }
  },
  async getAllDentalById(model: Dental.IDentalModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.post(`dental/getDentalbyid`, model);
      return response.data;
    } catch (error) {
      console.error('An error occurred while retrieving the customer:', error);
      throw error;
    }
  },
  async getDentalbytitle(model: Dental.IDentalModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.get(`dental/getDentalbytitle/${model.title}`);
      return response.data;
    } catch (error) {
      console.error('An error occurred while retrieving the customer:', error);
      throw error;
    }
  },
  async deleteDental(model: Dental.IDentalModel): Promise<Response.IDefaultResponse> {
    try {
      const response = await axiosInstance.post(`dental/deleteDental`, model);
      return response.data;
    } catch (error) {
      console.error('An error occurred while retrieving the customer:', error);
      throw error;
    }
  }
};
