import React from 'react';
import { Drawer, List, ListItem, ListItemText, ListItemAvatar, Avatar } from '@mui/material';
import { useSelector } from 'react-redux';
import { useEffect } from 'react';

const ContactsDrawer = ({ open, onClose }) => {
  const { data: contacts } = useSelector((state) => state.contacts);
useEffect(()=>{},[])
  return (
    <Drawer anchor="right" open={open} onClose={onClose}sx={{
        width: 300,
        '& .MuiDrawer-paper': {
          width: 300,
          padding: 2, 
          // Add padding to the drawer
        },}}>
           <h2>All Contacts</h2>
      <List>
       
        {contacts.map((contact) => (
          <ListItem key={contact.id}>
            <ListItemAvatar>
              <Avatar src={contact.photo} />
            </ListItemAvatar>
            <ListItemText primary={contact.name} />
          </ListItem>
        ))}
      </List>
    </Drawer>
  );
};

export default ContactsDrawer;

