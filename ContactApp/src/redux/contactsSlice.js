
import { createSlice } from "@reduxjs/toolkit";
import { fetchContacts,editContact,addContact,deleteContact } from "../api/contactApi";
const contactsSlice = createSlice({
  name: "contacts",
  initialState: {
    data: [],
    pageNumber: 1,
    pageSize: 6,
    totalPages: 0,
    loading: false,
    sortBy: 'name',
    sortOrder: 'asc',
    error: null,
  },
  reducers: {
    setPageSize(state, action) {
      state.pageSize = action.payload;
    },
    setSort(state, action) {
      state.sortBy = action.payload.sortBy;
      state.sortOrder = action.payload.sortOrder;
    },
    setPage(state, action) {
      state.pageNumber = action.payload;
    },
  },
  extraReducers: (builder) => {
    builder
      .addCase(fetchContacts.pending, (state) => {
        state.loading = true;
        state.error = null;
      })
      .addCase(fetchContacts.fulfilled, (state, action) => {
        state.data = action.payload.contacts;
        state.pageNumber = action.payload.pageNumber;
        state.pageSize = action.payload.pageSize;
        state.totalPages = action.payload.totalPages;
        state.loading = false;
        // state.sortBy = action.meta.arg.sortBy;
        // state.sortOrder = action.meta.arg.sortOrder;
      })
      .addCase(fetchContacts.rejected, (state, action) => {
        state.loading = false;
        state.error = action.payload;
      })
      .addCase(addContact.fulfilled, (state, action) => {
        state.data.push(action.payload);
      })
      .addCase(editContact.fulfilled, (state, action) => {
        const index = state.data.findIndex((contact) => contact.id === action.payload.id);
        if (index !== -1) {
          state.data[index] = action.payload;
        }
      })
      .addCase(deleteContact.fulfilled, (state, action) => {
        state.data = state.data.filter((contact) => contact.id !== action.payload);
      });
  },
});

export const {  setSort, setPage, setPageSize } = contactsSlice.actions;
export default contactsSlice.reducer;
