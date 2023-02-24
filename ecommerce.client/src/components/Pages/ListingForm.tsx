import React from 'react';
import { FormControl, InputLabel, TextField, InputAdornment, Select, SelectChangeEvent, MenuItem} from '@mui/material';
import { useState } from 'react';


function ListingForm() {
    function handleSubmit(event: React.FormEvent) {
        event.preventDefault();
    }

    const [condition, setCondition] = useState("New");

    const conditions = ["New", "Used(Like New)", "Used(Good)", "Used(Fair)" ];

    const handleConditionChange = (event: SelectChangeEvent) =>{
        setCondition(event.target.value);
    };

  return (
    <form onSubmit={handleSubmit}>
        <TextField
            id="name-field"
            label = "Listing Name"
            variant = "outlined"
        />
        <TextField 
        id = "price-field"
        label = "Price"
        variant = "outlined"
        InputProps ={{
            startAdornment: <InputAdornment position="start">$</InputAdornment>,
        }}/>
        <TextField
            id="location-field"
            label = "Location"
            variant = "outlined"
        />
        <FormControl>
            <InputLabel id="condition-label">Condition</InputLabel>
            <Select
                labelId="condition-label"
                id="condition"
                value={condition}
                label="Condition"
                onChange={handleConditionChange}
            >
                {conditions.map((option) => (
                    <MenuItem key={option} value={option}>
                        {option}
                    </MenuItem>
                ))}
            </Select>
        </FormControl>
    </form>
  );
}

export default ListingForm;
