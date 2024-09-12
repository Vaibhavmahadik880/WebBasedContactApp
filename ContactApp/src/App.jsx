
import React, { useState } from 'react';
import './styles/contactList.css';
import './styles/searchBar.css';
import ContactList from './components/ContactList';
import ContactForm from './components/ContactForm';
import FloatingButton from './components/FloatingButton';
import Header from './components/Header';
//import './App.css'
function App() {
  const [isFormVisible, setIsFormVisible] = useState(false);
  const [contactToEdit, setContactToAdd] = useState(null);

 const openForm = (contact = null) => {
  setContactToAdd(contact);
    setIsFormVisible(true);
  };
  const closeForm = () => {
    setIsFormVisible(false);
    setContactToAdd(null);
  };
  return (
    <>
      <Header />
      <div className="app">
        <ContactList onEdit={openForm} />
        {isFormVisible && (
          <ContactForm
            initialContact={contactToEdit}
            onClose={closeForm}
          />
        )}
        <FloatingButton onClick={() => openForm()} />
      </div>
    </>
  );
}

export default App;
