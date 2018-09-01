# ERP PeakScore

## Description
`ERP PeakScore` is a small program designed to extract amplitude and latency measures from event-related potential data exported in ASCII format from ([EEGLAB](https://sccn.ucsd.edu/eeglab/)).

The output of `ERP PeakScore` is a comma-separated value (CSV) file with the results of the peak scoring procedure. This CSV file is in ASCII format and can be edited with any text editor or, perhaps more conveniently, with a spreadsheet software.

See use instructions below. Additionally, please refer to the help tooltips on the program window, and to the "Instructions.txt" and "Citation.txt" files (accessible from the program's help menu) for additional information.

For updates, please check the ([releases section](https://github.com/ferreira-santos/ERP_PeakScore/releases)) of the GitHub repository (updates may also be announced in the software section of the website of the Laboratory of Neuropsychophysiology: http://www.fpce.up.pt/labpsi/).

## Instructions
INSTRUCTIONS

1. Preliminary steps
    
    i. Export ERP data as ASCII file in EEGLAB
    - [EEGLAB export options]
    - Make sure to note down of the sampling rate in Hz.


1.2. Verify the ASCII file (optional)
- The first row of the ASCII file should contain electrode names.
- The second row should contain numerical values corresponding to the voltages of the first EEG/ERP time point for each electrode.
- The following rows should contain the remaining EEG/ERP data points.

1.3. Ensure that each electrode corresponds to one column of the ASCII file 
- If there is any space or tabulation in the first row after the last electrode name, delete this space/tab and save the file.

2. Using ERP PeakScore

2.1. Open the ASCII file exported from EEGLAB
- After opening the file you should see the file path, electrodes, and time points.

2.2. Define the settings and measures for the peak scoring
- For information on each of the settings and measures, see the help tooltips by mousing over them in the program window (note: make sure "Help tooltips" is enabled the "Help" menu).

2.3. Score peaks and save
- The program will produce an output file with the selected peak measures for all electrodes.
- The output will be an ASCII comma-separated value (CSV) file which may be conveniently opened in a spreadsheet program.
- If there are errors, a message box will appear and you will have to go back and correct the errors before the output is produced.

Notes:
- Each ERP average file must be scored individually, i.e., there is no batch function in the program.
- If you want to score more than one ERP component for a given file, you must run the program twice. For example, run it once to score N1, then redefine the settings and run it again for P2.


## About
The `ERP PeakScore` program was developed by Fernando Ferreira-Santos as an Open Source software ([CC0 3.0](https://github.com/ferreira-santos/ERP_PeakScore/blob/master/LICENSE)). Citation information will be added here soon. Any issues or bugs that arise while using the software may be reported [here](https://github.com/ferreira-santos/ERP_PeakScore/issues).
