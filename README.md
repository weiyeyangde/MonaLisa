## Monalisa
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
### Step By Step (by generating triangles)
- Input image
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa.png" title="Original Image" style="width: 20%; height:auto;">
    </p>
- Onput images
  <div class="row">
    <div class="column">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa1.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa3.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa5.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa7.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa9.png" style="width: 15%; height:auto;">
    </div>
    <div class="column">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa11.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa13.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa15.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa17.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa19.png" style="width: 15%; height:auto;">
    </div>
     <div class="column">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa20.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa25.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa30.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa35.png" style="width: 15%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa41.png" style="width: 15%; height:auto;">
    </div>
  </div>

### Examples
- Approximate the image of Monalisa
  - by generating ellipses:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisaEllipse.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating rectangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisaRectangle.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating triangles:
    <p align="left">
       <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisaTriangle.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating ellipses, rectangles and triangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisa.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/monalisaMixPattern.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>

- Approximate the image of Mario
  - by generating ellipses:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/mario.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/marioEllipse.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating rectangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/mario.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/marioRectangle.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating triangles:
    <p align="left">
       <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/mario.png" title="Original Image" style="width: 30%; height:auto;">
       <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/marioTriangle.gif" title="Approximate Image" style="width: 30%; height:auto;">
    </p>
  - by generating ellipses, rectangles and triangles:
    <p align="left">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/mario.png" title="Original Image" style="width: 30%; height:auto;">
      <img src="https://github.com/weiyeyangde/MonaLisa/blob/main/images/marioMixPattern.gif" title="Approximate Image" style="width: 30%; height:auto;">
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
