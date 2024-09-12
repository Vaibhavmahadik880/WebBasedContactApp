import axios from 'axios';
import { toast } from "react-toastify";
import { createAsyncThunk } from '@reduxjs/toolkit';
const BASE_URL = 'https://localhost:44368/api/Contacts'; 

export const fetchContacts = createAsyncThunk(
  "contacts/fetchContacts",
  async ({ pageNumber, pageSize, sortBy, sortOrder, searchQuery=""}, { rejectWithValue }) => {
    try {
      const response = await axios.get(`${BASE_URL}`, {
        params: { pageNumber, pageSize, sortBy, sortOrder, searchQuery },
      });
      console.log(response)
      return response.data;
    } catch (error) {
      console.error("Error fetching contacts:", error);
      return rejectWithValue(error.response.data);
    }
  }
);
export const addContact = createAsyncThunk(
  "contacts/addContact",
  async (contact, { rejectWithValue }) => {
    try {
      const response = await axios.post(`${BASE_URL}`, contact);
      toast.success("Contact Added successfully!");
      return response.data;
    } catch (error) {
      console.error("Error adding contact:", error);
      return rejectWithValue(error.response.data);
    }
  }
);

export const editContact = createAsyncThunk(
  "contacts/editContact",
  async (contact, { rejectWithValue }) => {
    try {
      const response = await axios.put(`${BASE_URL}/${contact.id}`, contact);
      await toast.success("Contact Edited successfully!");
      return response.data;
    } catch (error) {
      console.error("Error editing contact:", error);
      return rejectWithValue(error.response.data);
    }
  }
);

export const deleteContact = createAsyncThunk(
  "contacts/deleteContact",
  async (contactId, { rejectWithValue }) => {
    try {
      await axios.delete(`${BASE_URL}/${contactId}`);
      toast.success("Contact deleted successfully!");
      return contactId;
    } catch (error) {
      console.error("Error deleting contact:", error);
      return rejectWithValue(error.response.data);
    }
  }
);
