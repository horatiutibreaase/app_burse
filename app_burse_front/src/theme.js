import { indigo } from '@mui/material/colors';

export const getDesign = (mode) => {
  return {
    palette: {
      mode,
      primary: {
        main: indigo[500], //3849aa
        contrastText: '#fff',
      },
      secondary: {
        main: '#ff7043',
        contrastText: '#fff',
      },
      neutral: {
        main: '#64748B',
        contrastText: '#fff',
      },
      contrastThreshold: 3,
      tonalOffset: 0.2,
    },
    typography: {
      fontFamily: [
        'Roboto',
        'sans-serif',
      ].join(','),
    },
  };
};