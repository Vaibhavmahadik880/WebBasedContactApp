// contactFormHandlers.js
import { RiContrastDropLine } from "react-icons/ri";
import { fetchContacts } from "../api/contactApi";
import { addContact, editContact } from "../api/contactApi";

// Validate fields to check for duplicate mobile number and email
export function getRandomNumber() {
  return Math.floor(Math.random() * 99) + 1;
}
const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

export const validateFields = (
  contact,
  contacts,
  setMobileError,
  setEmailError,
  setNameError
) => {
  let valid = true;

  // Determine if this is an existing contact being edited or a new contact
  const isEditing = !!contact.id;
  console.log(contact.id);
  // Get the current contact details if editing
  const currentContact = isEditing
    ? contacts.find((c) => c.id === contact.id)
    : null;

  // Validate Name
  if (!contact.name) {
    setNameError("**Name is required.");
    valid = false;
  } else {
    setNameError(""); // Clear previous error if name is valid
  }

  // Email validation
  if (!contact.email) {
    setEmailError("**Email is required.");
    valid = false;
  } else if (!emailRegex.test(contact.email)) {
    setEmailError("**Invalid email format.");
    valid = false;
  } else {
    // Check for duplicate email
    const isEmailExists = contacts.some(
      (c) => c.email === contact.email && (!isEditing || c.id !== contact.id)
    );
    if (isEmailExists) {
      setEmailError("**Email already exists.");
      valid = false;
    } else {
      setEmailError(""); // Clear previous error if email is valid
    }
  }

  // Mobile number validation
  if (!contact.mobileNumber) {
    setMobileError("**Mobile number is required.");
    valid = false;
  } else if (contact.mobileNumber.length !== 10) {
    setMobileError("**Mobile number must be 10 digits.");
    valid = false;
  } else {
    // Check for duplicate mobile number
    const isMobileExists = contacts.some(
      (c) =>
        c.mobileNumber === contact.mobileNumber &&
        (!isEditing || c.id !== contact.id)
    );
    if (isMobileExists) {
      setMobileError("**Mobile number already exists.");
      valid = false;
    } else {
      setMobileError(""); // Clear previous error if mobile number is valid
    }
  }

  return valid;
};

// Handle form submission
export const handleSubmitForm = async (
  e,
  contact,
  contacts,
  setMobileError,
  setEmailError,
  setNameError,
  dispatch,
  pageNumber,
  pageSize,
  sortOrder,
  sortBy,
  onClose
) => {
  e.preventDefault();

  
  // Validate fields before dispatching
  if (
    !validateFields(
      contact,
      contacts,
      setMobileError,
      setEmailError,
      setNameError
    )
  ) {
    return;
  }

  // Dispatch appropriate action based on whether it is an edit or add
  if (contact.id) {
    // Editing an existing contact
    await dispatch(editContact(contact));
    dispatch(
      fetchContacts({  pageNumber,
        pageSize,
        sortOrder,
        sortBy,})
    );

  } else {
    // Adding a new contact
    await dispatch(addContact(contact));
  }
  onClose();
};
