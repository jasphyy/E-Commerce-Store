import React from 'react';
import { Typography } from '@mui/material';
import SearchBar from '../NavBar/SearchBar';

function HomePage() {
  return (
    <div className="HomePage">
      <Typography>Home Page</Typography>
      <SearchBar></SearchBar>
    </div>
  );
}

export default HomePage;
