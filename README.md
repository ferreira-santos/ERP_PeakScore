# ![ERP PeakScore Logo](https://github.com/ferreira-santos/ERP_PeakScore/blob/master/docs/ERP_PeakScore_logo.png) ERP PeakScore

## Description
`ERP PeakScore` is a program for Windows (.NET framework) designed to extract amplitude and latency measures from event-related potential data exported in ASCII format from [EEGLAB](https://sccn.ucsd.edu/eeglab/). You can install `ERP PeakScore` by [downloading the latest release](https://github.com/ferreira-santos/ERP_PeakScore/releases), unzipping, and running the setup.

<p align="center">
<img src="https://github.com/ferreira-santos/ERP_PeakScore/blob/master/docs/ERP_PeakScore_screenshot.png" width=50%>
</p>

The output of `ERP PeakScore` is a comma-separated value (CSV) file with the results of the peak scoring procedure. This CSV file is in ASCII format and can be edited with any text editor or, perhaps more conveniently, with a spreadsheet software.

See use instructions below. Additionally, please refer to the help tooltips on the program window for additional information.

For updates, please check the [releases section](https://github.com/ferreira-santos/ERP_PeakScore/releases) of the GitHub repository (updates may also be announced in the software section of the website of the Laboratory of Neuropsychophysiology: http://www.fpce.up.pt/labpsi/).

## Instructions
### 1. Preliminary steps
- Export ERP data as ASCII file in EEGLAB
  - Open the the data set for the condition/participant of interest in EEGLAB
  - Navigate the EEGLAB GUI menu >> File | Export | Data and ICA activity to text file
  - Select the following options, define a filename, and export: 
    - <img src="https://github.com/ferreira-santos/ERP_PeakScore/blob/master/docs/EEGLAB_export_options.png" width=75%>
  - Make sure to note down of the sampling rate of the data in Hz.
- Verify the ASCII file (optional)
  - The first row of the ASCII file should contain electrode names.
  - The second row should contain numerical values corresponding to the voltages of the first EEG/ERP time point for each electrode.
  - The following rows should contain the remaining EEG/ERP data points.
- Ensure that each electrode corresponds to one column of the ASCII file 
  - If there is any space or tabulation in the first row after the last electrode name, delete this space/tab and save the file.

### 2. Using ERP PeakScore
- Open the ASCII file exported from EEGLAB
  - After opening the file you should see the file path, electrodes, and time points.
- Define the settings and measures for the peak scoring
  - For information on each of the settings and measures, see the help tooltips by mousing over them in the program window (note: make sure "Help tooltips" is enabled the "Help" menu).
- Score peaks and save
  - The program will produce an output file with the selected peak measures for all electrodes.
  - The output will be an ASCII comma-separated value (CSV) file which may be conveniently opened in a spreadsheet program.
  - If there are errors, a message box will appear and you will have to go back and correct the errors before the output is produced.

### Notes:
- Each ERP average file must be scored individually (i.e., there is no batch function in the program).
- If you want to score more than one ERP component for a given file, you must run the program twice. For example, run it once to score component N1, then redefine the settings and run it again for component P2.
- ERP PeakScore expects English OS locale configurations: dot/point `.` as decimal separator, comma `,` as separator in CSV files. Certain locale settings use the comma as a decimal separator and semi-colon as separator for CSV files -- note that ERP PeakScore will not work with these settings. If your computer is configured with a non-english locale, you must manually define these settings to the English standard.

## About
The `ERP PeakScore` program was developed by [Fernando Ferreira-Santos](http://ferreira-santos.eu) as an Open Source software licensed under the Creative Commons Attribution 3.0 Unported License ([CC0 3.0](https://creativecommons.org/licenses/by/3.0/)). Any issues or bugs that arise while using the software may be reported [here](https://github.com/ferreira-santos/ERP_PeakScore/issues).

APA style 6th edition citation:

Ferreira-Santos, F. (2013). ERP PeakScore (Version 1.0) [Computer software]. Porto: Laboratory of Neuropsychophysiology (University of Porto). Retrieved from https://github.com/ferreira-santos/ERP_PeakScore
