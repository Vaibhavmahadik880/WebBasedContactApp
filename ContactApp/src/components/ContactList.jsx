import React, { useState,useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import { deleteContact, fetchContacts } from "../api/contactApi";
import { setSort, setPage, setPageSize } from "../redux/contactsSlice";
import ContactItem from "./ContactItem";
import DataLoadingStatus from "./DataLoadingStatus";
import AlertDialog from "./AlertDialog";
import Pagination from "@mui/material/Pagination";
import SortDropdown from "./SortDropdown";
import "../styles/contactList.css";

const ContactList = ({ onEdit }) => {
  const dispatch = useDispatch();
  const {data: contacts,pageNumber,pageSize,totalPages,loading,sortBy,sortOrder,error,
  } = useSelector((state) => state.contacts);
  const searchTerm = useSelector((state) => state.search);
  const [dialogOpen, setDialogOpen] = useState(false);
  const [contactToDelete, setContactToDelete] = useState(null);

  useEffect(() => {
    dispatch(fetchContacts({pageNumber,pageSize,sortBy,sortOrder,
        searchQuery: searchTerm,
      })
    );
  }, [dispatch, pageNumber, pageSize, sortBy, sortOrder, searchTerm]);

  const handleDeleteClick = (contact) => {
    setContactToDelete(contact);
    setDialogOpen(true);
  };

  const handleConfirmDelete = async() => {
    if (contactToDelete) {
     await dispatch(deleteContact(contactToDelete.id));
     dispatch(fetchContacts({pageNumber,pageSize,sortBy,sortOrder,
      searchQuery: searchTerm,
    })
  );
    }
    setDialogOpen(false);
    setContactToDelete(null);
  };

  const handleSortChange = (field) => {
    dispatch(setSort({ sortBy: field, sortOrder: sortOrder === "asc" ? "desc" : "asc" }));
  };

  const handlePageChange = (event, value) => {
    dispatch(setPage(value));
  };
  

  return (
    <div>
      {loading ? (
        <DataLoadingStatus />
      ) : (
        <div>
          <SortDropdown
            currentSortBy={sortBy}
            currentSortOrder={sortOrder}
            onSortChange={handleSortChange}
          />
          <div className="contact-list">
            {contacts.length > 0 ? (
              contacts.map((contact) => (
                <ContactItem
                  key={contact.id}
                  contact={contact}
                  onEdit={() => onEdit(contact)}
                  onDelete={() => handleDeleteClick(contact)}
                />
              ))
            ) : (
              <h1>No contacts available</h1>
            )}
          </div>

          {totalPages > 1 && (
            <span className="sticky-pagination">
              <Pagination
                count={totalPages}
                page={pageNumber}
                onChange={handlePageChange}
                color="primary"
                shape="rounded"
                size="large"
              />
            </span>
          )}
          {contactToDelete && (
            <AlertDialog
              open={dialogOpen}
              onClose={() => setDialogOpen(false)}
              title="Delete Confirmation"
              message="Do you want to delete This Contact? This Action Cannot be Undone!!!"
              onConfirm={handleConfirmDelete}
              contactName={contactToDelete.name}
            />
          )}
        </div>
      )}
    </div>
  );
};

export default ContactList;
