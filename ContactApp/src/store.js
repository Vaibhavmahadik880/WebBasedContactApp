import { configureStore } from '@reduxjs/toolkit';
//import contactsReducer from '../features/contacts/contactsSlice';
import contactsReducer from './redux/contactsSlice'
import searchReducer from './redux/searchSlice'
export const store = configureStore({
  reducer: {
    contacts: contactsReducer,
    search: searchReducer,
  },
});
