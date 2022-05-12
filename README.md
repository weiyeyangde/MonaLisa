## Project1 - Monalisa
Approximate an image by continuously generating random colored patterns(ellipses, rectangles, triangles).

### Usage

```
Description:
  Approximate an image by continuously generating random colored patterns(ellipses, rectangles, triangles).

Usage:
  MonaLisa [options]

Options:
  --input_image_file_path <input_image_file_path>     The path of the image(.png) file.
  --output_directory_path <output_directory_path>     The directory path for the output image file.
  --pattern <ellipse|mix_pattern|rectangle|triangle>  The patterns that will be generated.
  --version                                           Show version information
  -?, -h, --help                                      Show help and usage information
```
```
.\MonaLisa.exe --input_image_file_path "E:\input.png" --output_directory_path "E:\" --pattern "ellipse"
```
### Examples
- Approximate the image of Monalisa
  - by generating ellipses:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisa.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisaEllipse/monalisaEllipse.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating rectangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisa.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisaRectangle/monalisaRectangle.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating triangles:
    <p align="left">
       <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisa.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisaTriangle/monalisaTriangle.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating ellipses, rectangles and triangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisa.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/monalisaMixPattern/monalisaMixPattern.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>

- Approximate the image of Mario
  - by generating ellipses:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/mario.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/marioEllipse/marioEllipse.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating rectangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/mario.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/marioRectangle/marioRectangle.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating triangles:
    <p align="left">
       <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/mario.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/marioTriangle/marioTriangle.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
  - by generating ellipses, rectangles and triangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/mario.png" title="Original Image" style="width: 20%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/marioMixPattern/marioMixPattern.gif" title="Approximate Image" style="width: 20%; height:auto;">
    </p>
### Pseudocode
```
  Set target_effective_count (e.g.: 5000)
  Set curr_effective_count = 0
  Set output_image to blank image
  
  While curr_effective_count <= target_effective_count
    Generate a random colored pattern
    If the output_image is more similiar to the input image by adding the new pattern
      Add the pattern to output_image
      curr_effective_count += 1
  
 Return output_image
 ```
